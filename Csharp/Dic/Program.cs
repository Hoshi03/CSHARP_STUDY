using System;
using System.Collections.Generic;


namespace Dic
{
    class Monster
    {
        public int id;
        public Monster(int id)
        {
            this.id = id;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            for(int i =0; i< 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster monster1000;
            bool found1000 = dic.TryGetValue(1000, out monster1000);
        }
    }
}
