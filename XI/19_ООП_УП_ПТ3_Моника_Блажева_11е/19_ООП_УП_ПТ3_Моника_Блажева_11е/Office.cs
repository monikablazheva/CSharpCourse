using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ООП_УП_ПТ3_Моника_Блажева_11е
{
    class Office : Property
    {
        private int year; //ново поле
        public int Year //свойство за полето
        {
            get { return this.year; } 
            set
            {
                if(value < 1800 || value > 3000) //проверка на числото
                {
                    throw new ArgumentOutOfRangeException("Year should be between 1800 and 3000."); //хвърляне на грешка
                }
                this.year = value;
            }
        }
        public Office(string i, double b, string t, int n, string bo, int y) : base(i, b, t, n, bo) //конструктор на класа
        {
            this.Year = y;
        }
        
        //предефиниране на 3-те метода
        public override void SumBuiltUpArea() 
        {
            base.SumBuiltUpArea();
            if(NumberOfFloors > 5) { Console.WriteLine("Good office"); }
        }
        public override void InfoPrintProperties()
        {
            base.InfoPrintProperties();
            Console.WriteLine("Year: {0}", Year);
        }
        public override void ShowBoss()
        {
            Console.WriteLine("The boss of the office is {0}", Boss);
        }
        public Func<double, int, double> SingleFloorArea = (Area, Floors) => Area / Floors; //ламбда фунция, която смята площа на един етаж
    }
}
