using System;

namespace Constructor
{

    class Knight
    {
        public int hp;
        public int atk;

        public Knight()
        {
            hp = 100;
            atk = 10;
            Console.WriteLine("생성자 호출");
        }

        public Knight(int hp) : this() // hp 100 atk 10 의 기본 생성자를 생성하고 int 생성자 내용을 실행
        {
            this.hp = hp;
            Console.WriteLine("int 생성자");
        }


        public void Move()
        {
            Console.WriteLine("무빙");
        }

        public void attack()
        {
            Console.WriteLine("knight attack");
        }

    }

    class Constructor
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Knight knight2 = new Knight(50);
        }
    }
}
