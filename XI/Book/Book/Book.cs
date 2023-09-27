using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        protected string title;
        protected int year;
        protected string[] authors;
        public string Title
        {
            get { return this.title; } 
            set { this.title = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public string[] Authors
        {
            get { return this.authors; }
            set { this.authors = value; }
        }
        //public IReadOnlyList<string> Austhors { get; set; }
        public Book(string title, int year, params string[] authors)
        {
            this.title = title;
            this.year = year;
            this.authors = authors;
        }
    }
}
