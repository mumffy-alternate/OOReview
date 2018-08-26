using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04BarkType.Models
{
    public class Bark
    {
        public String BarkSound { get; }

        public Bark(string bardSound)
        {
            BarkSound = bardSound;
        }

        public override bool Equals(object obj)
        {
            Bark barkObj = obj as Bark;
            if (barkObj == null)
                return false;

            return BarkSound.Equals(barkObj.BarkSound, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return BarkSound.GetHashCode();
        }

        public override string ToString()
        {
            return BarkSound;
        }
    }
}
