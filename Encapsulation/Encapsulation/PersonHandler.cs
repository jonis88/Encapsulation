using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class PersonHandler
    {
          
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            var person = new Person();
            person.Age = age;
            person.Fname = fname;
            person.Lname = lname;
            person.Height = height;
            person.Weight = weight;
            return person;

            

        }
    }
}




























        //public void SetFname(Person pers, string fname)
        //{
        //    pers.Fname = fname;
        //}
        //public void SetLname(Person pers, string lname)
        //{
        //    pers.Lname = lname;
        //}
        //public void SetHeight(Person pers, double height)
        //{
        //    pers.Height = height;
        //}
        //public void SetName(Person pers, double weight)
        //{
        //    pers.Weight = weight;
        //}












