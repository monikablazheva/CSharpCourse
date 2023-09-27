using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Film
    {
        public string name;
        public string mainCharacter;
        public uint year;
        public string Name
        {
            get { return name; }
            set { this.name = value; }

        }
        public string MainCharacter
        {
            get { return mainCharacter; }
            set { this.mainCharacter = value; }

        }
        public uint Year
        {
            get { return year; }
            set { this.year = value; }

        }
    }
}
