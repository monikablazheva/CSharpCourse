using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace putuvane_s_koli_Monika9e
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (i = 0; i < n; i++)
            {
                cars[i] = new Car();
            }
            for (i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                string[] splits = str.Split(' ');
                cars[i].model = splits[0];
                cars[i].kolichestvoGorivo = double.Parse(splits[1]);
                cars[i].razhod1km = double.Parse(splits[2]);
            }
            while(true)
            {
                string str = Console.ReadLine();
                if(str == "End")
                {
                    break;
                }
                string[] splits = str.Split(' ');
                for(i = 0; i < n; i++)
                {
                    if(splits[1] == cars[i].model)
                    {
                        cars[i].IzminatiKm += double.Parse(splits[2]); 
                        break;
                    }
                }

            }
            for (i = 0; i < n; i++)
            {
                cars[i].CheckTheNeededFuel();
            }
        }
    }
}
