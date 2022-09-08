using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_2.코드의_흐름_제어
{
    class _6
    {
        static void Main(string[] args)
        {
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Hello World");
            }

            int num = 98;

            for (int i = 2; i < num; i++) 
            {
                if ((num % i) == 0)
                {
                    Console.WriteLine("소수가 아닙니다!");
                    break; // 소수가 아닐시 반복문 탈출 
                }
            }

            for (int i = 1; i <= 100; i++) 
            {
                if ((i % 3) != 0)
                    continue;
                
                    Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
            }
        }
    }
}
