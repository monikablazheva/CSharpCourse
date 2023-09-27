using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    [SerializableAttribute]
    public class Subject
    {
        public string ID { get; private set; }

        public string Title { get; private set; }

        public string Type { get; private set; }

        public List<Teacher> Teachers { get; private set; }

        private Subject()
        {

        }

        public Subject(string title, string type)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Title = title;
            this.Type = type;
        }
    }
}
