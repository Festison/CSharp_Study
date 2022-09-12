using System;

namespace C샵_공부_4.객체지향_여행
{
    // 객체 (OOP)

    // Knight
    // 속성: hp, attack
    // 기능: Move, Attack, Die

    // Ref 참조

    class Knight
    {
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    // 복사
    struct Mage
    {
        public int hp;
        public int attack;
    }

    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;

            Mage mage2 = mage; // 다른 마법사를 나타낸다.
            mage2.hp = 0;

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            KillKnight(knight);

            Knight knight2 = knight; // 같은 기사를 나타낸다.
            knight.hp = 0;

            knight.Move();
            knight.Attack();
        }
    }
}
