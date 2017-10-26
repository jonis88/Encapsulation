using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Bird : Animal
    {
        private int wingspan;

        public int Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
        //Add property that apply to all birds here.

        public override string Stats()
        {
            return base.Stats() + "\nWith an wingspan of " + Wingspan;
        }
    }
}
