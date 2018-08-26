using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C03BarkRecognizer.Models;

namespace XXTests
{
    [TestClass]
    public class C03BarkRecognizerTests
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
            Console.WriteLine("Fido barks to go outside...");
            recognizer.Recognize("Woof!");

            Console.WriteLine("Fido has gone outside...");
            //Automatically close door;

            Thread.Sleep(5500);

            Console.WriteLine("Fido is all done...");
            Console.WriteLine("...but he is stuck outside!");
            Console.WriteLine("Fido barks to go INside...");
            recognizer.Recognize("Woof!");

            Console.WriteLine("Fido is back inside...");

            Thread.Sleep(5500);
        }
    }
}
