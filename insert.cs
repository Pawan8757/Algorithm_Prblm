using System;

namespace Insertsort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5] { 23, 56, 88, 99, 11 };
            int n = 6, i, j, val, flag;

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine(a[i]);
            }

            for (i = 1; i <= n; i++)
            {
                val = a[i];
            }

            flag = 0;

            for (j = i - 1; j >= 0 && flag != 1;)
            {
                if (val < a[j])
                {
                    a[j + 1] = a[j];
                    j--;
                    a[j + 1] = val;
                }


                else flag = 1;
            }

            Console.WriteLine("sorted");
        }
    }
}


