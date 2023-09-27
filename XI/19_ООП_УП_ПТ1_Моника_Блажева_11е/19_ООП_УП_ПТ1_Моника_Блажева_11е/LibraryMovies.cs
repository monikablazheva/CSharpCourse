using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ООП_УП_ПТ1_Моника_Блажева_11е
{
    class LibraryMovies : IEnumerable<Movie> //класа наследява интерфейса за обхождане на колекции
    {
        private List<Movie> movies; //лист, който съхранява филмите
        public LibraryMovies(List<Movie> movies) //конструктор на класа
        {
            this.movies = movies;
        }
        public IEnumerator<Movie> GetEnumerator() //предефиниране на метода на наследения интерфейс
        {
            return new LibraryMovieIterator(this.movies);
        }
        IEnumerator<Movie> IEnumerable<Movie>.GetEnumerator() => this.GetEnumerator(); //предефиниране на метода на наследения интерфейс
        IEnumerator IEnumerable.GetEnumerator() //предефиниране на метода на наследения интерфейс
        {
            throw new NotImplementedException();
        }
        class LibraryMovieIterator : IEnumerator<Movie> // вложен клас, който наследява интерфейса за обхождане
        {
            private IReadOnlyList<Movie> movies; //лист който само може да се чете и съхранява филмите
            private int currentIndex; // индексатор, който паказва на кой филм се намираме
            public LibraryMovieIterator(IEnumerable<Movie> movies) //конструктор на класа
            {
                this.Reset();
                this.movies = new List<Movie>(movies);
            }
            public void Dispose() { } //предефиниране на метода на наследения интерфейс
            public bool MoveNext() => ++this.currentIndex < this.movies.Count; //предефиниране на метода на наследения интерфейс, ако има елемент пред елемента на който се намираме връща true, ако е крайния елемент false 
            public void Reset() => this.currentIndex = -1; //започва от начало
            public Movie Current => this.movies[this.currentIndex]; // връща елемента, на който се намираме
            object IEnumerator.Current => this.Current;
        }
        public static void Sort(LibraryMovies library) //статичен метод за сортиране на филмите по година
        {
            library.movies.Sort();
        }
    }
}
