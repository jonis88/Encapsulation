using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Horse : Animal
    {
        private bool shoes;

        public bool Shoes
        {
            get { return shoes; }
            set { shoes = value; }
        }
        public override string Stats()
        {
            return base.Stats() + "\nHas shoes = " + Shoes;
        }
    }
}
