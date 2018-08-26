using C05a.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05a.Models
{
    public abstract class InstrumentSpec
    {
        public Builder Builder { get; set; }
        public String ModelName { get; set; }
        public GuitarType Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }

        public virtual bool Matches(InstrumentSpec matchSpec)
        {
            if (matchSpec.Builder != Builder)
                return false;

            if (!String.IsNullOrWhiteSpace(matchSpec.ModelName) &&
                !matchSpec.ModelName.Equals(ModelName, StringComparison.OrdinalIgnoreCase))
                return false;

            if (matchSpec.Type != Type)
                return false;

            if (matchSpec.BackWood != BackWood)
                return false;

            if (matchSpec.TopWood != TopWood)
                return false;

            return true;
        }
    }
}