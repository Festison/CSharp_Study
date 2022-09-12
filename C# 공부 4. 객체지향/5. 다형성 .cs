using System;

namespace C샵_공부_4.객체지향_여행
{
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    class Knight : Player
    {
        public override void Move()
        {
            base.Move(); // 부모클래스 한번 호출

            Console.WriteLine("Knight 이동!");
        }
    }

    class SuperKnight : Knight
    {
        public override void Move()
        {
            Console.WriteLine("SuperKnight 이동!");
        }
    }

    class Mage : Player
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();

            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();
            mage.Move();

            EnterGame(mage);
        }
    }
}
