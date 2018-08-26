using C05a.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05a.Models
{
    public class GuitarSpec : InstrumentSpec
    {
        public NumStrings NumStrings { get; set; }

        public override bool Matches(InstrumentSpec matchSpec)
        {
            if (!base.Matches(matchSpec))
                return false;

            GuitarSpec guitarMatchSpec = matchSpec as GuitarSpec;
            if (guitarMatchSpec == null)
                return false;

            if (guitarMatchSpec.NumStrings != NumStrings)
                return false;

            return true;
        }
    }
}
