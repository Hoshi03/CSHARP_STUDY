using System;

namespace Interface
{
    class Program
    {
        //추상 클래스, 추상 클래스 + 다른 클래스 사용은 불가능
        abstract class Monster
        {
            public abstract void Shout();
        }

        class Orc: Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타");
            }
        }

        interface IFlyable
        {
            void Fly();
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        //인터페이스 IFlyable을 가진 클래스에선 사용 가능한 함수
        static void Dofly(IFlyable flying)
        {
            flying.Fly();
        }
        static void Main(string[] args)
        {
            IFlyable orc = new FlyableOrc();
            Dofly(orc);
        }
    }
}
