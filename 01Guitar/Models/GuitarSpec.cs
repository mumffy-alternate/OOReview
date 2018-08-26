using _01Guitar.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Guitar.Models
{
    public class GuitarSpec
    {
        public Builder Builder { get; set; }
        public String ModelName { get; set; }
        public GuitarType Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public NumStrings NumStrings { get; set; }

        internal bool Matches(GuitarSpec matchSpec)
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

        //public GuitarSpec(Builder builder, String modelName, GuitarType type, Wood backwood, Wood topWood, NumStrings numStrings)
        //{
        //    this.Builder = builder;
        //    this.ModelName = modelName;
        //    this.Type = type;
        //    this.BackWood = backwood;
        //    this.TopWood = topWood;
        //    this.NumStrings = numStrings;
        //}
    }

}
