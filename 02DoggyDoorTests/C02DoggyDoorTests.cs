using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02DoggyDoor.Models;

namespace XXTests
{
    [TestClass]
    public class _02DoggyDoorTests
    {
        private Remote remote;

        [TestInitialize]
        public void TestSetup()
        {
            remote = new Remote(new DogDoor());
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
    }
}
