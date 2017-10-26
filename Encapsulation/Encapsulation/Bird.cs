using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Bird: Animal
    {
        public double WingSpan { get; set; }
        public Bird()
        {

        }

        public Bird(string name, double weight, int age, double wingSpan) 
            : base(name,weight,age)
        {
            WingSpan = wingSpan;
        }

        //public override string Stats()
        //{
        //    return base.Stats() + ", Wing Span: " + WingSpan + "m";
        //}
    }
}
