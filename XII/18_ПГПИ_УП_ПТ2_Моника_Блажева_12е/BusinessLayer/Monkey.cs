using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Monkey : Animal
    {
        public Monkey(string name, int age, string gender) : base(name, age, gender)
        {
        }
        private Monkey()
        {

        }
    }
}
