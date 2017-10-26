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
        static void Main(string[] args)
        {
            //Create a list for Animals
            List<Animal> list = new List<Animal>();

            //Create Animals
            Dog dog1 = new Dog();
            dog1.Name = "Echo";
            dog1.Weight = 10;
            dog1.Age = 8;
            dog1.Bark = true;

            Pelican peli1 = new Pelican();
            peli1.Name = "Lisa";
            peli1.Weight = 5;
            peli1.Age = 1;
            peli1.Wingspan = 60;
            peli1.LikesFish = true;

            Swan swan1 = new Swan();
            swan1.Name = "Swhans";
            swan1.Weight = 25;
            swan1.Age = 2;
            swan1.Wingspan = 100;
            swan1.Bites = true;

            Flamingo flam1 = new Flamingo();
            flam1.Name = "Flamman";
            flam1.Weight = 10;
            flam1.Age = 1;
            flam1.Wingspan = 50;
            flam1.Colors = "red and green";

            Dog dog2 = new Dog();
            dog2.Name = "Doggo";
            dog2.Weight = 25;
            dog2.Age = 14;
            dog2.Bark = false;

            //Add animals to list
            list.Add(dog1);
            list.Add(peli1);
            list.Add(swan1);
            list.Add(flam1);
            list.Add(dog2);

            //Print all animals in list
            foreach (var Animal in list)
            {
                Console.WriteLine(Animal.GetType().Name + "\n" + Animal.Stats() + "\n" + Animal.Speak() + "\n");
            }

            //Print all dogs in list
            Console.ReadKey();
            Console.Clear();
            foreach (var Animal in list.OfType<Dog>())
            {
                Console.WriteLine(Animal.GetType().Name + "\n" + Animal.Stats() + "\n" + Animal.Speak() + "\n");

            }
            Console.ReadKey();
            Console.Clear();

            //Create list for UserError
            List<UserError> error = new List<UserError>();
            
            //Add to error list
            error.Add(new TextInputError());
            error.Add(new NumericInputError());
            
            //Loop for listing the errors
            foreach (var UserError in error)
            {
                Console.WriteLine(UserError.UEMessage());
            }
            Console.ReadKey();

            /// <summary>
            /// Main method to get and print out all information of person
            /// </summary>
            /// <param name="args"></param>
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


