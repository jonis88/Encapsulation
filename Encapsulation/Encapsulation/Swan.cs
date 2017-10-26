using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Swan: Bird
    {
        public string Color { get; set; }

        public Swan()
        {

        }

        public Swan(string name, double weight, int age, double wingSpan,string color)
            : base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        //public override string Stats()
        //{
        //    return base.Stats() + ", Color :" + Color;
        //}
    }
}
