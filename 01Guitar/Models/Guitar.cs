using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Guitar.Models
{
    public class Guitar
    {
        public String SerialNumber { get; }
        public double Price { get; }
        public GuitarSpec Spec { get; }

        public Guitar(String serialNumber, double price, GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }
    }
}
