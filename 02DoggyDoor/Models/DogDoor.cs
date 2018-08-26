using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DoggyDoor.Models
{
    public class DogDoor
    {
        private bool isOpen;
        public bool IsOpen => isOpen;

        public DogDoor()
        {
            isOpen = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            isOpen = true;
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            isOpen = false;
        }

    }
}
