using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C03BarkRecognizer.Models
{
    public class Remote
    {
        private DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.IsOpen)
            {
                door.Close();
            }
            else
            {
                door.Open();
            }
        }
    }
}
