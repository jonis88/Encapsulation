using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }


        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }


        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        

    }
}
