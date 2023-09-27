using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class FamilyList
    {
        List<Person> listFamilyMembers = new List<Person>();
        public void AddsPeopleToList()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                listFamilyMembers.Add(new Person
                {
                    Name = Console.ReadLine(),
                    Age = int.Parse(Console.ReadLine())
                });
            }
            listFamilyMembers.Sort((x,y) => x.Name.CompareTo(y.Name));
        }
        public void Print()
        {
            foreach(Person i in listFamilyMembers)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Age);
            }
        }
    }
}
