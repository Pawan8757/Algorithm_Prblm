using System;

namespace Prime_Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int flag = 0;
            for (int n = 0; n <= 1000; n++)
            {
                flag = 0;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("prime" + n);
                }

                if (n % 11 == 0)
                {
                    Console.WriteLine("Palindrome" + n);
                }
            }
        }
    }
}



