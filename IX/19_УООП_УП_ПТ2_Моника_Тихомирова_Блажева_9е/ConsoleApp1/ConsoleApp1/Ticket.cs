using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ticket
    {
        private string idNumber; //поле, съхраняващо идентификационен 
        private string name; //поле, съхраняващо името на билета
        private double bet; //поле, съхраняващо стойността на залога на играча

        public void goTicket() // метод за въвеждането на данните
        {
            Console.WriteLine("Enter the id number of your ticket:");
            idNumber = Console.ReadLine();
            Console.WriteLine("Enter the name of your ticket:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your bet:");
            bet = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void LuckyTicket() // метод, проверяващ дали билета е късметлийски
        {
            int lenght = IdNumber.Length;
            string lastNumber = IdNumber.Remove(0, lenght - 1);
            if (lastNumber == "7")
            {
                Console.WriteLine("Your {0} ticket IS a Lucky ticket!", Name);
                Console.WriteLine("You win an award with the cost of your bet x4 - {0:f2}lv", Bet * 4);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Your {0} ticket IS NOT not a Lucky ticket. Try again!", Name);
                Console.WriteLine("You just lost your bet - {0:f2}lv. We are sorry.", Bet);
                Console.WriteLine();
            }
        }
        public string IdNumber
        {
            get { return idNumber; }
            set { this.idNumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public double Bet
        {
            get { return bet; }
            set { this.bet = value; }
        }
    }
}
