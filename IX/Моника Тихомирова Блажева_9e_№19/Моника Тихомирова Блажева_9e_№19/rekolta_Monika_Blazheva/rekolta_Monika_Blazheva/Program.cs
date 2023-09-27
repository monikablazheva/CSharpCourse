using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekolta_Monika_Blazheva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete x(plosht na lozeto):");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete y:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete z(nujnoto vino)");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete broq na rabotnicite:");
            int broiRabotnici = int.Parse(Console.ReadLine());

            double obshtoGrozde = x * y;
            double wine = 0.4 * obshtoGrozde / 2.5;

            if (z > wine)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z - wine));
            }
            else if (z <= wine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Ceiling(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - z), Math.Ceiling((wine - z) / broiRabotnici));
            }
            Console.ReadLine();
        }
    }
}
