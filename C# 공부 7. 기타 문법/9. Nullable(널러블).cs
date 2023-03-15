using System;
using System.Collections.Generic;
using System.Text;

namespace _7._기타_문법
{
    
    class Nullable
    {
        static int Find()
        {
            return 0;
        }

        class Monster
        {
            public int Id { get; set; }
        }

        static void Main(string[] args)
        {
            // Nullable -> Null + able
            Monster monster = null;

            if (monster != null) 
            {
                int monsterId = monster.Id;
            }

            int? id = monster?.Id; // monster값이 null이 아닐시 값을 넣고 null일시 null을 넣는다.
        }
    }
}
