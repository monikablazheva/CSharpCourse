using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public Person(string f, string l, int a)
        {
            this.FirstName = f;
            this.LastName = l;
            this.Age = a;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty");    
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if(value < 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative number or bigger than 130.");
                }
                this.age = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("{0} {1} is {2} years old.", FirstName, LastName, Age);
        }
    }
}
