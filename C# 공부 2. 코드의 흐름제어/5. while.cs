using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_2.코드의_흐름_제어
{
    class _5
    {
        static void Main(string[] args)
        {
            // while 반복문
            int count = 5;

            while (count>0) // 조건 
            {
                Console.WriteLine("Hello World");
                count--;
            }

            string answer;

            do
            {
                Console.WriteLine("do while문은 반복문 입니까? (y/n) : ");
                answer = Console.ReadLine();
            } while (answer != "y"); // y가아니면 반복

            Console.WriteLine("정답입니다.");
        }
    }
}
