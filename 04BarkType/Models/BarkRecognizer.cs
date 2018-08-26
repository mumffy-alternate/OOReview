using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04BarkType.Models
{
    public class BarkRecognizer
    {
        private DogDoor door;
        private List<Bark> allowedBarks;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
            allowedBarks = new List<Bark>();
        }

        public void AddAllowedBark(Bark bark)
        {
            allowedBarks.Add(bark);
        }

        public void Recognize(Bark bark)
        {
            Console.WriteLine($"\tBarkRecognizer: heard a \"{bark}\"");

            var matchingBark = allowedBarks.FirstOrDefault(b => b.Equals(bark));
            if (matchingBark != null)
            {
                Console.WriteLine($"\tBarkRecognizer: the \"{bark}\" bark is allowed");
                door.Open();
            }
            else
            {
                Console.WriteLine($"\tBarkRecognizer: the \"{bark}\" bark is NOT allowed");
            }
        }
    }
}
