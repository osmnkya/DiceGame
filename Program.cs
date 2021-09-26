using System;

namespace Kattis.DiceGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                string[] emma = Console.ReadLine().Split(' ');
                string[] gunnar = Console.ReadLine().Split(' ');
                int sumEmma = 0;
                int sumGunnar = 0;

                for (int i = 0; i < emma.Length; i++)
                {
                    sumEmma += int.Parse(emma[i]);
                }
                for (int j = 0; j < gunnar.Length; j++)
                {
                    sumGunnar += int.Parse(gunnar[j]);
                }

                string whoWin = " ";

                if (sumEmma < sumGunnar)
                    whoWin = "Emma";
                else if (sumGunnar < sumEmma)
                    whoWin = "Gunnar";
                else
                    whoWin = "Tie";

            Console.WriteLine(whoWin);
        }
    }
}
