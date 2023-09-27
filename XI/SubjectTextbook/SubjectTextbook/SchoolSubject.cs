using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectTextbook
{
    class SchoolSubject : Schoolbook
    {
        private short grade;
        public short Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        public SchoolSubject()
        {
        }
        public SchoolSubject(short grade, string subject, string authors, int yearOfPublishing) : base(subject, authors, yearOfPublishing)
        {
            this.grade = grade;
        }
        public int SchoolbookAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - base.yearOfPublishing;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Subject:" + base.subject);
            Console.WriteLine("Authors:" + base.authors);
            Console.WriteLine("Grade:" + this.grade);
        }
    }
}
