using System;

namespace Kattis
{
    public static void Main(string args)
    {
        int[] dice1 = new int[4];
        int[] dice2 = new int[4];

        string[] line1;
        line1 = Console.ReadLine().Split(' ');
        string[] line2;
        line2 = Console.ReadLine().Split(' ');

        for (int i = 0; i < 4; ++i)
        {
            dice1[i] = int.Parse(line1[i]);
            dice2[i] = int.Parse(line2[i]);
        }

        double[] result = new double[2];

        double sum, t;

        for (int i = 0; i < 4; ++i)
        {
            sum = 0;
            t = 0;
            for (int j = dice1[i]; j <= dice2[i]; ++j)
            {
                sum += j;
                ++t;
            }
            result[i / 2] += sum / t;
        }

        if (result[1] > result[0])
        {
            Console.WriteLine("Emma");
        }
        else if (result[1] < result[0])
        {
            Console.WriteLine("Gunnar");
        }
        else
        {
            Console.WriteLine("Tie");
        }
    }
}
