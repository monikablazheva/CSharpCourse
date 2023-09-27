using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(List<Book> books)
        {
            this.books = books;
        }
        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator<Book> IEnumerable<Book>.GetEnumerator() => this.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        class LibraryIterator : IEnumerator<Book>
        {
            private IReadOnlyList<Book> books;
            private int currentIndex;
            public LibraryIterator(IEnumerable<Book> book)
            {
                this.Reset();
            }
            public void Dispose() {}
            public bool MoveNext() => ++this.currentIndex < this.books.Count;
            public void Reset() => this.currentIndex = -1;
            public Book Current => this.books[this.currentIndex];
            object IEnumerator.Current => this.Current;
        }
    }
}
