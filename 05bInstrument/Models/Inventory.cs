using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05b.Models
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

        public IEnumerable<Instrument> Search(InstrumentSpec searchSpec)
        {
            //TODO why doesn't this work?
            //IEnumerable<Instrument> matches = inventory.Where(i => i.Spec.Matches(searchSpec));
            List<Instrument> matches = new List<Instrument>();

            foreach(Instrument instrument in inventory)
            {
                if (instrument.Spec.Matches(searchSpec))
                {
                    matches.Add(instrument);
                }
            }

            return matches;
        }

    }
}
