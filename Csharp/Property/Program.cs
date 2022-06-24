using System;

namespace Property
{
    class Program
    {

       class Knight
        {
             
            // 자동화 프로퍼티로 Mp 100 만들어 두고 게터, 세터 둘다 있는 버전
            public int Mp { get; set; } = 100;
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Mp = 50;
            int a = knight.Mp;
            Console.WriteLine(a);
        }
    }
}
