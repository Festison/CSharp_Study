using System;
using System.Collections.Generic;
using System.Text;

namespace C샵_공부_1._데이터_갖고_놀기
{
    class Class1
    {
        static void sub2(string[] args)
        {
            // 1바이트 (참/ 거짓)
            bool b;
            b = true;
            b = false;

            // 소수
            float f = 3.14f;        // 4바이트
            double d = 3.14;      // 8바이트

            // 2바이트
            char c = 'a';
            string str = "Hello World!";

            Console.WriteLine(str);

        }
    }
}
