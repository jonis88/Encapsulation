using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Hedgehog: Animal
    {
        public int NoOfSpikes { get; set; }
        public Hedgehog()
        {

        }

        public Hedgehog(string name, double weight, int age, int noOfSpikes)
            : base(name,weight,age)
        {
            NoOfSpikes = noOfSpikes;
        }

        //public override string Stats()
        //{
        //    return base.Stats() + ", Number of spikes: " + NoOfSpikes; 
        //}
    }
}
