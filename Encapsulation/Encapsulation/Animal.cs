using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Animal
    {
        //Properties of animals
        private string name;
        private int weight;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //Add property that apply to all animals here.

        //Instantiate Animal
        public Animal() {}
        public Animal(string nam, int wei, int age)
        {
            Name = nam;
            Weight = wei;
            Age = age;
        }

        public virtual string Stats()
        {
            return "You are looking at: " + Name +
                "\nHe/She weights: " + Weight +
                "\nAnd is " + Age + "years old";
        }

        public virtual string Speak()
        {
            return "";
        }

    }
}
