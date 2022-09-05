using System;

namespace C샵_공부_1._데이터_갖고_놀기
{
    class Program
    {
        static void sub1(string[] args)
        {
            // 데이터  + 로직
            // 체력 0 = 죽음

            // byte(1바이트 0~255), short(2바이트) , int(4바이트) , long(8바이트)
            // sbyte(1바이트 -128~127), ushort, uint, ulong
            int hp = 100;
            short level = 100;
            long id; // id 는 long으로 만드는게 좋다.

            byte attack = 0;

            // 10 진수
            // 0 1 2 3 4 5 6 7 8 9 10

            // 2진수
            // 0 1

            // 16 진수
            // 0~9 A B C D E F
            // 0x00 0x01 0x02 .. 0x0F
            // 0x10 0x11 0x12 .. 0x1F

            Console.WriteLine("Hello Number ! {0}", hp);
        }
    }
}
