using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Horse: Animal
    {
        public double Speed { get; set; }


        public Horse()
        {

        }

        public Horse(string name, double weight, int age, double speed) 
            : base(name, weight, age)
        {
            Speed = speed;
        }

        //public override string Stats()
        //{
        //    return base.Stats() + ", Speed: " + Speed + "km/h";
        //}
    }



}
