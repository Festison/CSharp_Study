using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace _7._기타_문법
{
    class Reflection // X-Ray같은 기능 정보를 빼올 수 있다.
    {
        class Important : System.Attribute // 컴퓨터가 런타임을 체크할수 있는 주석
        {
            string message;

            public Important(string message) { this.message = message; }
        }

        class Monster
        {
            [Important("Important")] // 유니티의 [SerializeField] private로 선언해도 유니티 인스펙터에서 접근할 수 있다.
            public int hp;

            protected int attack;
            private float speed;

            void Attack() { }
        }

        static void Main(string[] args)
        {
            Monster monster = new Monster();
            Type type=monster.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                {
                    access = "public";
                }
                else if (field.IsPrivate)
                {
                    access = "private";
                }

                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }      
        }
    }
}
