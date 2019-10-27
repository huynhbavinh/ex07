using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    class Line
    {
        private int[,] space = new int[100, 100];
        private int x;
        private int y;
        private int x1;
        private int y1;
        public Line(int start,int end)
        {
            x1 = start;
            y1 = end;
            x = 1;
            y = 1;
        }
        public void move(int nx, int ny)
        {
            int size = Math.Abs(x1 - y1);
            int temp = 1;
            x = nx * temp;
            y = ny * temp;
            for (int i = y; i < space.GetLength(0); i++)
            {
                for (int j = x; j < space.GetLength(1); j++)
                {
                    if (j < x+size && i == y )
                    {
                        space[i, j] = 1;
                    }
                    else
                    {
                        space[i, j] = 0;
                    }
                }
            }
        }
        public void draw()
        {
            for (int i = 0; i < space.GetLength(0); i++)
            {
                for (int j = 0; j < space.GetLength(1); j++)
                {
                    if (space[i, j] == 1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
