using System;
using System.Collections.Generic;
using System.Text;

namespace C샵_공부_1._데이터_갖고_놀기
{
    class Class3
    {
        static void sub4(string[] args)
        {
            int hp = 100;
            int level = 50;

            // + - * / % 매개 변수 
            hp = 1 + 2 * 100;

            hp++; // 증감 연산자 , 후위 연산자
            ++hp; // 전위 연산자 (실행 순서가 다르다)

            // < <= > >= == !=
            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);

            // && AND || OR ! NOT
            // a = 살아있는 고렙 유저인가요?
            bool a = isAlive && isHighLevel;

            // b = 살아있거나, 고렙 유저이거나, 둘 중 하나인가요?
            bool b = isAlive || isHighLevel;

            Console.WriteLine(hp);

        }
    }
}
