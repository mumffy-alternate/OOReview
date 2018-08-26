using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05a.Models
{
    public class Guitar : Instrument
    {
        public Guitar(String serialNumber, double price, GuitarSpec spec) 
            : base(serialNumber, price, spec) {
        }
    }
}
