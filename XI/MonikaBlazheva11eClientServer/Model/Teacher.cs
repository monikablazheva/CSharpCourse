using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [SerializableAttribute]
    public class Teacher
    {
        public string ID { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Experience { get; private set; }

        public List<Subject> Subjects { get; private set; }

        private Teacher()
        {

        }

        public Teacher(string name, int age, string experience)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Name = name;
            this.Age = age;
            this.Experience = experience;
        }
    }
}