using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lottary
    {
        private string name; //поле, съхраняващо името на лотарията
        private string winningNumbers; //поле, съхраняващо печелившите числа на лотарията
        private string playersNumbers; //поле, съхраняващо числата на играча

        public void goLottary() //метод за въвеждане на данните
        {
            Console.WriteLine("Enter the name of the lottary:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the winning numbers of this week:");
            winningNumbers = Console.ReadLine();
            Console.WriteLine("Enter the numbers of the player:");
            playersNumbers = Console.ReadLine();
        }
        public void WinningTicket() //метод, проверяващ печелившите числа
        {
            int check = 0;
            for (int i = 0; i < 5; i++)
            {
                if (WinningNumbers.Contains(PlayersNumbers[i]))
                {
                    check++;
                    continue;
                }
            }
            if (check <= 2)
            {
                Console.WriteLine("Your ticket from {0} is not a winning one. Try again!", Name);
                Console.WriteLine();
            }
            else if (check == 3)
            {
                Console.WriteLine("Congratulations! Your ticket from {0} is a winning one! You have won 1 000 lv!", Name);
                Console.WriteLine();
            }
            else if (check == 4)
            {
                Console.WriteLine("Congratulations! Your ticket from {0} is a winning one! You have won 5 000 leva!", Name);
                Console.WriteLine();
            }
            else if (check == 5)
            {
                Console.WriteLine("Congratulations! Your ticket from {0} is a winning one! You have won 10 000 leva!", Name);
                Console.WriteLine();
            }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string WinningNumbers
        {
            get { return winningNumbers; }
            set { this.winningNumbers = value; }
        }
        public string PlayersNumbers
        {
            get { return playersNumbers; }
            set { this.playersNumbers = value; }
        }
    }

}
