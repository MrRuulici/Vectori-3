using System;

namespace Vectori_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibo = Fibonacci(5);
            Console.WriteLine(fibo);
            for(int i = 1; i<= fibo.Length; i++)
            {
                if (fibo[i] != 0)
                    Console.WriteLine(fibo[i]);
            }
        }

        static int[] Fibonacci(int n)
        {
            int[] v = new int[100];
            v[0] = 0;
            if (n == 0)
                return v;
            v[1] = 1;
            if (n == 1)
                return v;
            int i = 1;
            while(v[i]<n)
            {
                i++;
                v[i] = v[i - 1] + v[i - 2];
            }
            return v;
        }
    }
}
