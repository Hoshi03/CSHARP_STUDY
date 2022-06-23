using System;

namespace multy_array
{
    class Program
    {
        class Map
        {
            int[,] tiles = {{1,1,1,1,1},{1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{1,1,1,1,1}};

            public void Render()
            {
                var defaultcolor = Console.ForegroundColor;
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[y, x] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = defaultcolor;
            }
        }

        

        static void Main(string[] args)
        {
            // 다차원 배열 선언하기
            Map map = new Map();
            map.Render();

            //크기가 다른 배열 여러개를 넣기
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[6];
            a[2] = new int[9];
        }
    }
}
