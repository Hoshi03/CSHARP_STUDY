using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class InputManager
    {
        public delegate void Oninputkey();
        public event Oninputkey Inputkey;
        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;
            ConsoleKeyInfo info =  Console.ReadKey();
            if(info.Key == ConsoleKey.A)
            {
                Inputkey();
            }
        }   
    }
    class Program
    {
        static void Oninputtest()
        {
            Console.WriteLine("input 확인!");
        }
        static void Main(string[] args)
        {
            InputManager input = new InputManager();
            input.Inputkey += Oninputtest;

            while (true)
            {
                input.Update();
            }
        }
    }
}
