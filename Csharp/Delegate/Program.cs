using System;

namespace Delegate
{
    class Program
    {
        delegate int Onclicked();
        //반환은 int고 입력은 void
        //Onclicked는 이 delegate의 이름

        static void Btnpressde(Onclicked clikedfunction)
        {
            clikedfunction();
        }


        //delegate에서 반환할 함수
        static int DelegateTest()
        {
            Console.WriteLine("delegate");
            return 0;
        }
        static void Main(string[] args)
        {
            Btnpressde(DelegateTest);
        }
    }
}
