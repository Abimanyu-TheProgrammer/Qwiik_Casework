using System;
namespace Qwiik_Casework.Services
{
    public class FibonacciService : IFibonacciService
    {
        public int[] GenerateFibonacci(int n)
        {
            int[] l = new int[n];

            if(n == 0)
            {
                return l;
            }

            l[0] = 0;
            if(n == 1)
            {
                return l;
            }

            l[1] = 1;
            if(n == 2)
            {
                return l;
            }

            for(int i = 2; i < n; i++)
            {
                l[i] = l[i - 2] + l[i - 1];
            }

            return l;
        }
    }
}

