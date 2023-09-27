using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ООП_УП_ПТ1_Моника_Блажева_11е
{
    class Movie : IComparable<Movie> //клас за филмите, който наследява интерфейса, който казва Аз съм нещо сравнимо
    {
        protected string title; // поле, което може да се наследява от по-долни в йерархията
        protected int year; // поле, което може да се наследява от по-долни в йерархията
        public string Title //публично свойство за заглавието
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int Year //публично свойство за годината
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public IReadOnlyList<string> Movies {get; set;} //свойство за лист, който само може да бъде четен

        public Movie(string title, int year, List<string> movies) //конструктора на класа с параметри
        {
            this.Title = title;
            this.Year = year;
            this.Movies = movies;
        }
        public int CompareTo(Movie otherMovie) //предефиниране на метода от наследения интерфейс, който сравнявя два филма 
        {
            int result = this.Year.CompareTo(otherMovie.Year); //сравнява два филма по година
            if(result == 0)
            {
                result = this.Title.CompareTo(otherMovie.Title); //ако филмите имат равни години, проверявя по заглавие
            }
            return result; // връща резултата от сравняването
        }
        public override string ToString() // предефиниране на метода от наследения интерфейс, който изписва заглавието и годината му
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
