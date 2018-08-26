using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Guitar.Models
{
    public class Inventory
    {
        private List<Guitar> guitars;
        public int GuitarCount => guitars.Count;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(Guitar guitar)
        {
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(String serialNumber)
        {
            return guitars.FirstOrDefault(g=>g.SerialNumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach(Guitar guitar in guitars)
            {
                if (guitar.Spec.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;
        }
    }
}
