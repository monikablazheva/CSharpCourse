using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ООП_УП_ПТ3_Моника_Блажева_11е
{
    class Program
    {
        static void Main(string[] args)
        {
            Office a = new Office("bg55", 100, "ofis", 6, "Angel", 2004); //обект на класа офис
            Office b = new Office("bg66", 100, "ofis", 9, "Petkp", 2009); //обект на класа офис
            Office c = new Office("bg33", 50, "ofis", 3, "Zoro", 2016); //обект на класа офис

            a.SumBuiltUpArea();
            a.ShowBoss();
            Console.WriteLine(a.SingleFloorArea(a.BuildUpArea, a.NumberOfFloors)); //изписваме резултата от ламбда функцията

            List<Office> list = new List<Office>(); //лист с всички офиси
            list.Add(a);
            list.Add(b);
            list.Add(c);

            List<Office> SortedList = list.OrderBy(x => x.ID).ToList<Office>(); //сортиране на листа по ID
            foreach(var i in SortedList)
            {
                i.InfoPrintProperties(); //Извеждане на сортираните данни за офиса чрез метода InfoPrintProperties
            }

            string age = Console.ReadLine(); //четем годинити като стринг
            try
            {
                Int32.Parse(age); //пробваме кода за парсване към интиджър
            }
            catch (FormatException)
            {
                Console.WriteLine("The age must be integer"); //при неуспех извежда съобщение за грешка
            }
            Shop m = new Shop("bg34", 300, "shop", 2, "Joro", Int32.Parse(age)); // обект на класа магазин
            Shop n = new Shop("bg23", 150, "shop", 4, "Mitko", 3); // обект на класа магазин
            m.SumBuiltUpArea();
            m.ShowBoss();
            List<Shop> list2 = new List<Shop>(); //лист с всички офиси
            list2.Add(m);
            list2.Add(n);

            List<Shop> SortedList2 = list2.OrderBy(x => x.ID).ToList<Shop>(); //сортиране на листа по ID
            foreach (var i in SortedList2)
            {
                i.InfoPrintProperties(); //Извеждане на сортираните данни за офиса чрез метода InfoPrintProperties
            }
        }
    }
}
