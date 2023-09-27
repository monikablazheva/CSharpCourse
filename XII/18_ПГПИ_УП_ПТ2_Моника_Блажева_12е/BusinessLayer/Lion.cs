using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Lion : Animal
    {
        public Lion(string name, int age, string gender) : base(name, age, gender)
        {
        }
        private Lion()
        {

        }
    }
}
