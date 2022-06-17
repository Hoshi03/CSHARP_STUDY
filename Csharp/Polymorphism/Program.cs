using System;

namespace Polymorphism
{

    class Player
    {
        protected int hp;
        protected int atk;

        public virtual void Move()
        {
            Console.WriteLine("플레이어 이동");
        }
    }

    class Knight : Player
    {
        public override void Move()
        {
            Console.WriteLine("기사 이동");
        }

    }

    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            //부모인 player의 move 함수 호출하고 mage의 move 내용도 호출함!
            base.Move();
            Console.WriteLine("법사 이동");
        }
    }

    class Program
    {
        static void Entergame(Player player)
        {
            player.Move();
            //플레이어가 Mage 클래스이면 mage를 Mage 클래스로 아니면 null
            Mage mage = (player as Mage); 
            if(mage != null)
            {
                mage.mp = 10;
            }
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            Entergame(mage);
        }
    }
}
