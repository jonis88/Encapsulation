using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    /// <summary>
    /// Class to handle and process all information of person
    /// </summary>
    public class PersonHandler
    {


        /// <summary>
        /// Set age of the person
        /// </summary>
        /// <param name="per">Person object to set age</param>
        /// <param name="age">age with integer value</param>
        private void SetAge(Person per, int age)
        {
            per.Age = age;
        }

        private int GetAge(Person per)
        {
            return per.Age;
        }

        /// <summary>
        /// Set First Name to the person
        /// </summary>
        /// <param name="per">Person object to set age</param>
        /// <param name="fname">first name with string value</param>
        private void SetFName(Person per, string fname)
        {
            per.FName = fname;
        }

        /// <summary>
        /// Set Last Name to the person
        /// </summary>
        /// <param name="per">Person object to set age</param>
        /// <param name="lname">last name with string value</param>
        private void SetLName(Person per, string lname)
        {
            per.LName = lname;
        }

        private string GetName(Person per)
        {
            return per.FName + " " + per.LName;
        }

        /// <summary>
        /// Set Weight to the person
        /// </summary>
        /// <param name="per">Person object to set age</param>
        /// <param name="fname">weight with double value eg 75.9</param>
        private void SetWeight(Person per, double weight)
        {
            per.Weight = weight;
        }

        private double GetWeight(Person per)
        {
            return per.Weight;
        }

        /// <summary>
        /// Set Height to the person
        /// </summary>
        /// <param name="per">Person object to set age</param>
        /// <param name="fname">height with double value eg. 165.8</param>
        private void SetHeight(Person per, double height)
        {
            per.Height = height;
        }

        private double GetHeight(Person per)
        {
            return per.Height;
        }

        /// <summary>
        /// Create a person with all values
        /// </summary>
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person per = new Person();
            SetAge(per, age);
            SetFName(per, fname);
            SetLName(per, lname);
            SetHeight(per, height);
            SetWeight(per, weight);
            return per;
        }




        /// <summary>
        /// Print out the string contain information of person
        /// </summary>
        public string PrintPerson(Person per)
        {
           string output = "Name: " + GetName(per) + "\nAge: " + per.Age+ "\nHeight: " + per.Height + " cm \nWeight: " + per.Weight + " kg \n";
                      
           return output;
        }


       


    }
}
