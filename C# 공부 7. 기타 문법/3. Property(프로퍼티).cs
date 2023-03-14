using System;
using System.Collections.Generic;
using System.Text;

namespace _7._기타_문법
{
    class Property
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            public int GetHp() { return hp; }

            public void SetHp(int hp) { this.hp = hp; }

            public int Hp
            {
                get { return hp; } // 꺼내올때는 get 사용
                private set { hp = value; } // value=100
            }

            protected int hp;
        }

        // 자동완성 프로퍼티
        class Mage
        {
            public int Mp { get; set; } = 100; // 바로 초기화 가능

            private int _mp;
            public int GetMp() { return _mp; }
            public void SetMp(int value) { _mp = value; }
        }

        static void Main(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            knight.Hp = 100;

            int hp = knight.Hp;          
        }
    }
}
