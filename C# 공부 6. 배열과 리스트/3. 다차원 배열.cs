using System;

namespace CSahrp_공부
{
    class Program
    {
        class Map
        {
            int[,] tiles =
            {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 },
            };

            public void Render()
            {
                ConsoleColor defaultColor = Console.ForegroundColor;

                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[y,x]==1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = defaultColor;
            }
        }
          static void Main(string[] args)
        {
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            // 2차원 배열
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Map map = new Map();
            map.Render();

  
        }
    }
}
