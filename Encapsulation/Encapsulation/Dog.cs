using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Dog: Animal
    {
        public string Type { get; set; }

        public Dog()
        {

        }

        public Dog(string name, double weight, int age, string type)
            : base(name,weight,age)
        {
            Type = type;
        }

        //public override string Stats()
        //{
        //    return base.Stats() + ", Type: " + Type;
        //}
    }
}
