using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ООП_УП_ПТ1_Моника_Блажева_11е
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> movieOneInfo = new List<string>(); 
            movieOneInfo.Add("Fiction");
            movieOneInfo.Add("War");
            List<string> movieTwoInfo = new List<string>();
            movieOneInfo.Add("Fiction");
            movieOneInfo.Add("Elves");
            List<string> movieThreeInfo = new List<string>();
            movieThreeInfo.Add("Fiction");
            movieThreeInfo.Add("Hobbit");
            Movie movieOne = new Movie("Star Wars", 2003, movieOneInfo); //обект на класа филм
            Movie movieTwo = new Movie("Lord of Rings", 2002, movieTwoInfo); //обект на класа филм
            Movie movieThree = new Movie("Hobbit", 2012, movieThreeInfo); //обект на класа филм

            List<Movie> fictionMovies = new List<Movie>();
            fictionMovies.Add(movieOne);
            fictionMovies.Add(movieTwo);
            fictionMovies.Add(movieThree);
            LibraryMovies libraryMovieOne = new LibraryMovies(fictionMovies); //обект на класа библиотека

            Console.WriteLine(movieOne.CompareTo(movieThree)); //сравнява два филма
            Console.WriteLine(movieThree.CompareTo(movieOne)); //сравява два филма

            foreach (var Movie in libraryMovieOne) //обхожда и извежда библиотеката от филми
            {
                Console.WriteLine(Movie.ToString());
            }
            LibraryMovies.Sort(libraryMovieOne);
            foreach (var Movie in libraryMovieOne) //обхожда и извежда библиотеката от филми след сортиране
            {
                Console.WriteLine(Movie.ToString());
            }
        }
    }
}
