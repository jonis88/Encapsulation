using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {


            PersonHandler p1 = new PersonHandler();
            p1.CreatePerson(18, "John", "Doe", 180, 70);
            
            PersonHandler p2 = new PersonHandler();
            p2.CreatePerson(20, "Jane", "Doe", 170, 55);

            

            //var person = new Person
            //{
            //    Age = 18,
            //    Fname = "Jane",
            //    Lname = "Doe",
            //    Height = 180,
            //    Weight = 60
            //};
            
        }
    }
}
