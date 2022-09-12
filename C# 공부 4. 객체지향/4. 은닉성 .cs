using System;

namespace C샵_공부_4.객체지향_여행
{

    class Player
    {
        // 접근 한정자 public protected private
        protected int hp; // 상속받은 애들만 사용가능
        protected int attack;
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        // Mage 타입 -> Player 타입 
        // Player 타입 -> Mage 타입 ? 크로스 체크 사용
        static void EnterGame(Player player)
        {
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

            EnterGame(mage);

        }
    }
}
