using System;

namespace C샵_공부_4.객체지향_여행
{
    class Knight
    {
        static public int counter = 1; // counter는 모든 나이트가 사용

        public int id;
        public int hp;
        public int attack;

        static public void Test() // static 안에서는 static 연산만 가능
        {
            counter++;
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        public Knight()
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }

        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight(); // static
        }
    }
}
