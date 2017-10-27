using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class TestObject
    {
        public void AddPersonFromConsole()
        {
            do
            {
                Console.Write("Please input the first name:");
                string fname = Console.ReadLine();
                if (String.IsNullOrEmpty(fname)) break;

                Console.Write("Please input the last name:");
                string lname = Console.ReadLine();
                if (String.IsNullOrEmpty(lname)) break;

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

                PersonHandler per = new PersonHandler();

                Console.WriteLine(per.PrintPerson(per.CreatePerson(age, fname, lname, height, weight)));
            }
            while (true);
        }

        public List<Animal> AddAnimal()
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

            Horse horse1 = new Horse();
            horse1.Name = "Pony";
            horse1.Weight = 65;
            horse1.Age = 10;
            horse1.Shoes = true;

            Hedgehog hedge1 = new Hedgehog();
            hedge1.Name = "Hegy";
            hedge1.Age = 5;
            hedge1.Weight = 2;
            hedge1.NoOfSpikes = 150;

            //Add animals to list
            list.Add(dog1);
            list.Add(peli1);
            list.Add(swan1);
            list.Add(flam1);
            list.Add(dog2);
            list.Add(horse1);
            list.Add(hedge1);

            return list;
        }

        public void PrintDogsOnly(List<Animal> list)
        {
            //Print all dogs in the list
            foreach (var Animal in list.OfType<Dog>())
            {
                Console.WriteLine(Animal.GetType().Name + "\n" + Animal.Stats() + "\n" + Animal.Speak() + "\n");

            }
        }

        public void PrintAnimals(List<Animal> list)
        {
            //Print all animals in list
            foreach (var Animal in list)
            {
                Console.WriteLine(Animal.GetType().Name + "\n" + Animal.Stats() + "\n" + "\n");
            }
        }

        public List<UserError> AddUserError()
        {
            //Create list for UserError
            List<UserError> error = new List<UserError>();

            //Add to error list
            error.Add(new TextInputError());
            error.Add(new NumericInputError());
            error.Add(new DateInputError());
            error.Add(new EmailInputError());
            error.Add(new NullInputError());

            return error;
        }

        public void PrintUserError(List<UserError> error)
        {

            //Loop for listing the errors
            foreach (var UserError in error)
            {
                Console.WriteLine(UserError.UEMessage());
            }

        }

    }
}
