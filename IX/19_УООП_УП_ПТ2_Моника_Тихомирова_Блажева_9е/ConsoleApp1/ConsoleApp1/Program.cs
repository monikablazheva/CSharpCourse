using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lucky ticket");

            Ticket ticket = new Ticket();
            ticket.goTicket();
            ticket.LuckyTicket();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Winning ticket");

            Lottary lottary = new Lottary();
            lottary.goLottary();
            lottary.WinningTicket();

            Console.WriteLine("----------------------------------------");
        }
    }
}
