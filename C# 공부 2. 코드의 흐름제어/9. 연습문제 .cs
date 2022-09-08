using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_2.코드의_흐름_제어
{
    class _9
    {
        static int Factorial(int n)
        {
            int ret = 1;

            for (int num = 1; num <= n; num++)
            {
                ret *= num;
            }

            return ret;
        }

        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {           
                    Console.WriteLine($"{i} * {j} = {i*j}" );
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}
