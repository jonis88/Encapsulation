using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Flamingo : Bird
    {
        private string colors;

        public string Colors
        {
            get { return colors; }
            set { colors = value; }
        }

        public override string Stats()
        {
            return base.Stats() + "\nWith a color of " + Colors;
        }
    }
}
