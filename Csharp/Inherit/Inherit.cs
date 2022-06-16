using System;

namespace Constructor
{
    class Inherit
    {

        class Player
        {
            static public int counter = 1; // 카운터는 하나만 존재
            public int id = 1;
            public int hp;
            public int atk;

            public Player()
            {
                Console.WriteLine("플레이어 생성자 호출");
            }

            public Player(int hp)
            {
                this.hp = hp;
                Console.WriteLine("플레이어 hp 생성자 호출");
            }
        }

        class Knight : Player
        {
            public Knight() : base(100)// 
            {
                Console.WriteLine("knight 생성자 호출");
            }
        }

        class Archer : Player
        {

        }
        class Mage : Player
        {

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
        }

    }
}
