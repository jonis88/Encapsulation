using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Hedgehog : Animal
    {
        private int noOfSpikes;

        public int NoOfSpikes
        {
            get { return noOfSpikes; }
            set { noOfSpikes = value; }
        }

        public override string Stats()
        {
            return base.Stats() + "\nThat has " + NoOfSpikes + "spikes";
        }
    }
}
