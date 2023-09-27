using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectTextbook
{
    class Schoolbook
    {
        protected string subject;
        protected string authors;
        protected int yearOfPublishing;

        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }
        public string Authors
        {
            get { return this.authors; }
            set { this.authors = value; }
        }
        public int YearOfPublishing
        {
            get { return this.yearOfPublishing; }
            set { this.yearOfPublishing = value; }
        }
        public Schoolbook()
        {
        }
        public Schoolbook(string subject, string authors, int yearOfPublishing)
        {
            this.subject = subject;
            this.authors = authors;
            this.yearOfPublishing = yearOfPublishing;
        }
    }
}
