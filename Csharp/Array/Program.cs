using System;

namespace Array
{
    class Program
    {

        static int Gethigh(int[] scores)
        {
            int high = 0;

            for(int i = 0; i < scores.Length-1; i++)
            {
                if (scores[i] >= scores[i + 1])
                    high = scores[i];
                else
                    high = scores[i + 1];
            }
            return high;
        }

        static int Getavg(int[] scores)
        {
            int avg = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                avg += scores[i];
            }

            avg /= (scores.Length);

            return avg;
        }

        static int Getindex(int[] scores, int value)
        {
            int index = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if(scores[i] == value)
                {
                    return i+1;
                }
            }

            return 0;
        }

        static int Sort(int[] scores)
        {
            int just = 0;
            for(int i = 0; i < scores.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(scores[i] < scores[j])
                    {
                        just = scores[i];
                        scores[i] = scores[j];
                        scores[j] = just;
                    }
                }
            }

            return 0;
        }


        static void Main(string[] args)
        {
            int[] scores = new int[] { 30, 10, 20, 50, 40 }; // 입력을 한번에 하는 방법
            /*int a = Getindex(scores,2);*/

            Sort(scores);
            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }
            /*Console.WriteLine(a);*/
        }
    }
}
