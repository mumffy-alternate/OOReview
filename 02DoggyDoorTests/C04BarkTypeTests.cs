using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C04BarkType.Models;

namespace XXTests
{
    [TestClass]
    public class C04BarkTypeTests
    {
        private DogDoor door;
        private Remote remote;
        private BarkRecognizer recognizer;

        [TestInitialize]
        public void TestSetup()
        {
            door = new DogDoor();
            remote = new Remote(door);
            recognizer = new BarkRecognizer(door);
        }

        [TestMethod]
        public void ButtonPressOpensDoor()
        {
            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("Fido has gone outside...");
            remote.PressButton();

            Console.WriteLine("Fido is all done...");
            remote.PressButton();

            Console.WriteLine("Fido is back inside...");
            remote.PressButton();
        }

        [TestMethod]
        public void DoorAutomaticallyClosesAfterDelay()
        {
            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("Fido has gone outside...");
            //Automatically close door;

            Thread.Sleep(5500);

            Console.WriteLine("Fido is all done...");
            remote.PressButton();

            Console.WriteLine("Fido is back inside...");
            //remote.PressButton();

            Thread.Sleep(5500);
        }

        [TestMethod]
        public void BarkRecognizerOpensDoor()
        {
            recognizer.AddAllowedBark(new Bark("wooF!"));

            Console.WriteLine("Fido barks to go outside...");
            recognizer.Recognize(new Bark("Woof!"));

            Console.WriteLine("Fido has gone outside...");
            //Automatically close door;

            Thread.Sleep(5500);

            Console.WriteLine("Fido is all done...");
            Console.WriteLine("...but he is stuck outside!");
            Console.WriteLine("Fido barks to go INside...");
            recognizer.Recognize(new Bark("Woof!"));

            Console.WriteLine("Fido is back inside...");

            Thread.Sleep(5500);
        }

        [TestMethod]
        public void BarkRecognizerRejectsUnknownBarks()
        {
            recognizer.AddAllowedBark(new Bark("aaa"));
            recognizer.AddAllowedBark(new Bark("bbb"));
            recognizer.AddAllowedBark(new Bark("ccc"));
            recognizer.AddAllowedBark(new Bark("ddd"));

            Console.WriteLine("Bruce starts barking...");
            recognizer.Recognize(new Bark("aaa"));
            Console.WriteLine("Bruce goes outside...");
           
            // rando starts barking
            recognizer.Recognize(new Bark("yap"));
            Thread.Sleep(2000);
            recognizer.Recognize(new Bark("yip"));
            Thread.Sleep(2000);
            recognizer.Recognize(new Bark("yop"));
            Thread.Sleep(2000);

            Console.WriteLine("Bruce is all done... but he's stuck outside");
            Console.WriteLine("Bruce starts barking again...");
            recognizer.Recognize(new Bark("ccc"));
            Console.WriteLine("Bruce goes back inside...");

            Thread.Sleep(5500);
        }
    }
}
