using System;

namespace C샵_공부_2.코드의_흐름_제어
{
    class overriding  // 오버로딩이란 매개변수및 함수를 재사용하는 것이다.
    {
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        static int Add(int a, int b, int c = 0, float d = 1.0f , double e = 3.0)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }

        static float Add(float a, float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }

        static void Main(string[] args)
        {
            int ret = overriding.Add(2, 3);
            float ret2 = overriding.Add(2.0f, 3.0f);
            overriding.Add(1, 2, d: 2.0f); // 지정한 값만 대입가능 

            Console.WriteLine(ret);
        }
    }
}
