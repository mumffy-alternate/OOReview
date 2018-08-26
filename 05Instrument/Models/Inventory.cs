using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05a.Models
{
    public class Inventory
    {
        private List<Instrument> inventory;
        public int InventoryCount => inventory.Count;

        public Inventory()
        {
            inventory = new List<Instrument>();
        }

        public void AddInstrument(Instrument i)
        {
            inventory.Add(i);
        }

        public Instrument GetInstrument(String serialNumber)
        {
            return inventory.FirstOrDefault(g=>g.SerialNumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach(Instrument instrument in inventory)
            {
                if (!(instrument is Guitar))
                    continue;

                Guitar guitar = instrument as Guitar;
                if (guitar.Spec.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;
        }

        public IEnumerable<Mandolin> Search(MandolinSpec searchSpec)
        {
            List<Mandolin> matchingMandolins = new List<Mandolin>();

            foreach (Mandolin mandolin in inventory)
            {
                if (mandolin.Spec.Matches(searchSpec))
                {
                    matchingMandolins.Add(mandolin);
                }
            }

            return matchingMandolins;
        }
    }
}
