using System;

namespace Bubble;

public class Program
{
    public static void Main(string[] args)
    {

        int[] x = new int[20] { 2, 33, 44, 55, 66, 55, 6, 77, 88, 333, 888, 9999, 22222, 6666, 444444, 333, 444, 555, 666, 7777 };
        int n = 22, i, j, val, flag;
        for (i = 0; i < 20; i++)
        {
            for (j = 0; j < 20 - i - 1; j++)
            {
                if (x[j] > x[j + 1])
                {
                    int temp = x[j];

                    x[j] = x[j + 1];
                    x[j + 1] = temp;
                }


            }
            Console.WriteLine("Sorted order" + x[i]);
        }

    }
}