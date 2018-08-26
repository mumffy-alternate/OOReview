using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOReview.Appendix02
{
    public class Airplane
    {
        protected int speed;
        public virtual int Speed {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }

    public class Jet : Airplane
    {
        private const int SPEEDMULTIPLER = 2;

        public override int Speed
        {
            set
            {
                speed = value * SPEEDMULTIPLER;
            }
        }

        public void Accelerate()
        {

        }
    }
}
