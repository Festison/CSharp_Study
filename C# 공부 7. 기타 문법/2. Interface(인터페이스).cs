using System;
using System.Collections.Generic;
using System.Text;

namespace _7._기타_문법
{
    class Interface
    {
        abstract class Monster // 추상 클래스 : 더 이상 생성 불가능
        {
            public abstract void Shout(); // 함수 또한 추상적으로 만들 수 있으며 어떠한 기능을 반드시 사용해야할 경우 사용
        }

        interface IFlyable // 인터페이스를 사용해 이중상속을 가능하게 한다.
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout() // 추상 클래스의 함수를 반드시 오버라이드 해야한다.
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
