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
            //test person object
            TestObject testper = new TestObject();
            testper.AddPersonFromConsole();
            Console.ReadKey();

            //test animal object
            Console.Clear();
            TestObject testanimals = new TestObject();
            List<Animal> animals= testanimals.AddAnimal();
            testanimals.PrintAnimals(animals);
            Console.ReadKey();

            //check animal is dog
            Console.Clear();
            testanimals.PrintDogsOnly(animals);
            Console.ReadKey();

            //test user error
            Console.Clear();
            TestObject testerror = new TestObject();
            List<UserError> errorlist= testerror.AddUserError();
            testerror.PrintUserError(errorlist);
            Console.ReadKey();
        }


    }
}


