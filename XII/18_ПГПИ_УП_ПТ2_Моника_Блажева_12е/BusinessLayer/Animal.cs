using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //абстрактен клас животно
    public abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        protected Animal() { }
    }
}
