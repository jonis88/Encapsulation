using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Flamingo: Bird
    {
        public double FootLength { get; set; }
        public Flamingo()
        {

        }

        public Flamingo(string name, double weight, int age, double wingSpan,double foot)
            : base(name,weight,age,wingSpan)
        {
            FootLength = foot;
        }

        //public override string Stats()
        //{
        //    return base.Stats() + ", Foot Length: " + FootLength + "m";
        //}
    }
}
