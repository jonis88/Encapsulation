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

        public Bird() { }
        public Bird(string nam, int wei, int age, int win) :
            base(nam, wei, age)
        { Wingspan = win; }

        public override string Stats()
        {
            return base.Stats() + "\nWith an wingspan of " + Wingspan;
        }
    }
}
