using C05b.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C05b.Models
{
    public class InstrumentSpec
    {
        private Dictionary<SpecProps, Object> properties;

        public Object this[SpecProps s]
        {
            get
            {
                return properties[s];
            }
            set
            {
                properties[s] = value;
            }
        }

        public IEnumerable<SpecProps> SpecPropKeys => properties.Keys;

        public InstrumentSpec()
        {
            this.properties = new Dictionary<SpecProps, object>();
        }
        public InstrumentSpec(Dictionary<SpecProps, Object> properties)
        {
            this.properties = properties;
        }

        public virtual bool Matches(InstrumentSpec matchSpec)
        {
            // matchSpec has some property that this does not
            if (matchSpec.SpecPropKeys.Intersect(properties.Keys).Count() != matchSpec.SpecPropKeys.Count())
                return false;

            foreach (SpecProps theProperty in matchSpec.SpecPropKeys)
            {
                if (matchSpec[theProperty] is String)
                {
                    String matchValue = matchSpec[theProperty] as String;
                    if (!matchValue.Equals(properties[theProperty] as String, StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }
                else if (!matchSpec[theProperty].Equals(properties[theProperty]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}