using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ООП_УП_ПТ3_Моника_Блажева_11е
{
    class Shop : Property
    {
        private int age; //ново поле
        public int Age //свойство за полето
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100) //проверка на числото
                {
                    throw new ArgumentOutOfRangeException("Age should be between 1 and 100."); //хвърляне на грешка
                }
                this.age = value;
            }
        }
        public Shop(string i, double b, string t, int n, string bo, int a) : base(i, b, t, n, bo) //конструктор на класа
        {
            this.Age = a;
        }

        //предефиниране на 3-те метода
        public override void SumBuiltUpArea()
        {
            base.SumBuiltUpArea();
            if (NumberOfFloors > 2)
            { 
                Console.WriteLine("Good shop"); 
            }
        }
        public override void InfoPrintProperties()
        {
            base.InfoPrintProperties();
            Console.WriteLine("Age:{0}", Age);
        }
        public override void ShowBoss()
        {
            Console.WriteLine("The boss of the shop is {0}", Boss);
        }
    }
}
