using System;
using System.Collections.Generic;
using System.Text;

namespace _7._기타_문법
{
    class _2
    {
        abstract class Monster // 추상 클래스 : 더 이상 생성 불가능
        {
            public abstract void Shout();
        }

        interface IFlyable
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("");
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("");
            }
        }
        
        static void DoFly(IFlyable flyable)
        {

        }

        static void Main(string[] args)
        {
            IFlyable flyable = new FlyableOrc();
            DoFly(flyable);
        }
    }
}
