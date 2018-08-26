using C05a.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05a.Models
{
    public class MandolinSpec : InstrumentSpec
    {
        public Style Style;

        public override bool Matches(InstrumentSpec matchSpec)
        {
            if (!base.Matches(matchSpec))
                return false;

            MandolinSpec mandolinMatchSpec = matchSpec as MandolinSpec;
            if (mandolinMatchSpec == null)
                return false;

            if (mandolinMatchSpec.Style != Style)
                return false;

            return true;
        }
    }
}