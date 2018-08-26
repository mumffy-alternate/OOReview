using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05a.Models
{
    public class Mandolin : Instrument
    {
        public Mandolin(string serialNumber, double price, MandolinSpec spec) 
            : base(serialNumber, price, spec)
        {
        }
    }
}