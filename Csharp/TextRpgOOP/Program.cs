using System;

namespace TextRpgOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager game = new GameManager();

            while (true)
            {
                Console.WriteLine("시작!");
                game.Process();
            }
        }
    }
}
