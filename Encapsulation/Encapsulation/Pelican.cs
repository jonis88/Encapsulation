using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Pelican: Bird
    {
        public double BeakLength { get; set; }

        public Pelican()
        {

        }

        public Pelican(string name, double weight, int age, double wingSpan, double beak)
            :base(name,weight,age,wingSpan)
        {
            BeakLength = beak;
        }

        //public override string Stats()
        //{
        //    return base.Stats() + ", Beak length: " + BeakLength + "m";
        //}
    }
}
