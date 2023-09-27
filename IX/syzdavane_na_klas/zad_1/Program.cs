using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human stoyan = new Human();
            Human ivan = new Human();

            stoyan.name = "Stoyan";
            stoyan.age = 20;

            ivan.name = "Ivan";
            ivan.age = 16;


            Book nemiliNedragi = new Book();
            Book nejnaENoshta = new Book();

            nemiliNedragi.name = "Nemili-nedragi";
            nemiliNedragi.author = "Ivan Vazov";
            nemiliNedragi.price = 25;

            nejnaENoshta.name = "Nejna e noshta";
            nejnaENoshta.author = "Francis Scott";
            nejnaENoshta.price = 20;


            Film starWars = new Film();
            Film hobbit = new Film();

            starWars.name = "Star Wars";
            starWars.mainCharacter = "Anakin SkyWalker";
            starWars.year = 2005;

            hobbit.name = "Hobbit";
            hobbit.mainCharacter = "Bilbo Begins";
            hobbit.year = 2012;


            Shop jysk = new Shop();
            Shop lidl = new Shop();

            jysk.name = "Jysk";
            jysk.type = "furniture shop";
            jysk.count = 3;

            lidl.name = "Lidl";
            lidl.type = "food shop";
            lidl.count = 9;
             
            //Console.WriteLine(stoyan.name);
            //Console.WriteLine(ivan.name);

            //stoyan.introduseYourSelf();
            //ivan.introduseYourSelf();

            Console.WriteLine(stoyan.Name);
            Console.WriteLine(stoyan.Age);

            Console.WriteLine(" ------------ ");

            Console.WriteLine(nemiliNedragi.Name);
            Console.WriteLine(nemiliNedragi.Author);
            Console.WriteLine(nemiliNedragi.Price);

            Console.WriteLine(" ------------ ");

            Console.WriteLine(starWars.Name);
            Console.WriteLine(starWars.Year);
            Console.WriteLine(starWars.MainCharacter);

            Console.WriteLine(" ------------ ");

            Console.WriteLine(jysk.Name);
            Console.WriteLine(jysk.Type);
            Console.WriteLine(jysk.Count);

            Console.WriteLine(" ------------ ");

            Console.ReadKey();
        }
    }
}
