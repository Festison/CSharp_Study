using System;
using System.Collections.Generic;

namespace CSahrp_공부
{
    class Monster
    {
        public Monster(int id) { this.id = id; }

        public int id;
    }
    class Program
    {   
        // Dictionary는 Hashtable을 이용
        static void Main(string[] args)
        {
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            bool found = dic.TryGetValue(7777, out mon);

            dic.Remove(7777);
            
        }
    }
}
