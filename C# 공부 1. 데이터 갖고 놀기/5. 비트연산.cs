using System;
using System.Collections.Generic;
using System.Text;

namespace C샵_공부_1._데이터_갖고_놀기
{
    class _5
    {
        static void Main(string[] args)
        {
            // << >> &(and) | (or) ^(xor) ~(not)

            int id = 123;
            int key = 401;

            int a = id ^ key;
            int b = a ^ key;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
