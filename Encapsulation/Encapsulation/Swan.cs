using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Swan : Bird
    {
        private bool bites;

        public bool Bites
        {
            get { return bites; }
            set { bites = value; }
        }

        public override string Stats()
        {
            return base.Stats() + "\nThat bites = " + Bites;
        }
    }
}
