using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_2.코드의_흐름_제어
{
    class Program
    {
        // 메소드 함수
        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static void AddOne(ref int number) // ref를 붙이면 참조 number가 a를 참조한다 
        {
            number = number + 1;
        }

        static int AddOne2(int number) 
        {
            return number = number + 1;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a; // a를 임시저장
            a = b;
            b = temp;
        }

        static void Divide(int a, int b, out int result1, out int result2) // out도 참조이다.
        {
            result1 = a / b;
            result2 = a % b;
        }

        static void Main(string[] args)
        {
            int result = Program.Add(4, 5);
            Console.WriteLine(result);

            // 복사 , 참조 
            int a = 0;
            Program.AddOne(ref a);
            Console.WriteLine(a);

            int b = Program.AddOne2(a);
            a = b;
            Console.WriteLine(a);

            int num1 = 1;
            int num2 = 2;
            Program.Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            // 10 / 3 = 나머지 1 
            int num3 = 10;
            int num4 = 3;

            int result1;
            int result2;
            Divide(10, 3, out result1, out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
