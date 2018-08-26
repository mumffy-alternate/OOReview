using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03BarkRecognizer.Models
{
    public class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void Recognize(String bark)
        {
            Console.WriteLine($"\tBarkRecognizer: heard a \"{bark}\"");
            door.Open();
        }
    }
}
