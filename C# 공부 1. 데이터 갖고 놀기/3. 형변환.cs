using System;
using System.Collections.Generic;
using System.Text;

namespace C샵_공부_1._데이터_갖고_놀기
{
    class Class2
    {
        static void sub3(string[] args)
        {
            // 1. 바구니 크기가 다른 경우
            int a = 0x0FFFFFF;
            short f = (short)a;
            // short b = a;  X   short b = (short)a; O 

            short b = 100;
            int c = b; // 상관없음

            // 2 . 바구니 크기는 같긴 한데, 부호가 다를 경우
            byte d= 255;
            sbyte sb = (sbyte)d;
            // 언더 플로우 , 오버플로우 sb= -1, d=255

            // 3. 소수 
            float e = 3.1414f;
            double  g= e;

        }
    }
}
