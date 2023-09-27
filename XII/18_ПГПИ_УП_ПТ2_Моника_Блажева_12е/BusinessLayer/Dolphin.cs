using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Dolphin:Animal
    {
        public Dolphin(string name, int age, string gender) : base(name, age, gender)
        {
        }
        private Dolphin()
        {

        }
    }
}
