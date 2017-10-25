using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        /// <summary>
        /// Main method to get and print out all information of person
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool continued = true;
            //Instantiate a new Person, but could not directly access the variables, because they are private fields
            //Person per = new Person();
            

            do
            {
                //Instantiate a new PersonHandler
                PersonHandler perhandler = new PersonHandler();

                //Create and print person
                continued = AddPersonFromConsole(perhandler);
            }
            while (continued);

            Console.ReadKey();
        }


        /// <summary>
        /// Read person information inputed from console then add to an instance of PersonHandler
        /// </summary>
        /// <param name="personhandler">handle information of each person</param>
        private static bool AddPersonFromConsole(PersonHandler personhandler)
        {
            Console.Write("Please input the first name:");
            string fname = Console.ReadLine();
            if (String.IsNullOrEmpty(fname)) return false;

            Console.Write("Please input the last name:");
            string lname = Console.ReadLine();
            if (String.IsNullOrEmpty(lname)) return false;

            Console.Write("Please input the age:");
            int age = 0;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Age couldn't be parsed");
            }

            Console.Write("Please input the height:");
            double height = 0;
            if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out height))
            {
                Console.WriteLine("Height couldn't be parsed");
            }

            Console.Write("Please input the weight:");
            double weight = 0;
            if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out weight))
            {
                Console.WriteLine("Height couldn't be parsed");
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine(personhandler.PrintPerson(age, fname, lname, height, weight));
            return true;
        }
    }
}
