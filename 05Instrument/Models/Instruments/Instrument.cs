using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05a.Models
{
    public abstract class Instrument
    {
        public String SerialNumber { get; }
        public double Price { get; }
        public InstrumentSpec Spec { get; }

        public Instrument(String serialNumber, double price, InstrumentSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }

        public Instrument(InstrumentSpec spec)
        {
            Spec = spec;
        }
    }
}