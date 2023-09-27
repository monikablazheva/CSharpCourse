using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [SerializableAttribute]
    public class User
    {
        public string ID { get; private set; }

        public int Age { get; private set; }

        public string Name { get; private set; }

        public List<Message> Messages { get; set; }

        private User()
        {

        }

        public User(int age, string name)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Age = age;
            this.Name = name;
        }

    }
}
