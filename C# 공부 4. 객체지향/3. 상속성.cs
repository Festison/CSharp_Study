using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_4.객체지향_여행
{
    // OOP(은닉성/상속성/다형성)
   class Player // 부모클래스
    {
        static public int counter = 1;
        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출");
        }
    }

    class Mage : Player // 자식 클래스
    {
        
    }

    class Archer : Player
    {

    }

    class Knight : Player
    {
        int c;

        public Knight() : base(100)
        {
            this.c = 10; // this :자신에게 접근
            base.hp = 100; // base :부모님에게 접근
            Console.WriteLine("Knight 생성자 호출");
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();
        }
    }
   
}
