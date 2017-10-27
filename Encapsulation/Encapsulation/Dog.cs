using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Dog : Animal
    {
        private bool bark;

        public bool Bark
        {
            get { return bark; }
            set { bark = value; }
        }

        public string Speak()
        {
            return "Woff!";
        }
        public override string Stats()
        {
            return base.Stats() + "\nThat barks = " + Bark;
        }
    }
}
