using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    class Square
    {
        private int[,] space = new int[100, 100];
        private int x;
        private int y;
        private int width;
        public Square(int size)
        {
            width = size;
            x = 1;
            y = 1;
        }
        public void move(int nx,int ny)
        {
            int temp1 = 1;
            int temp2 = 1;
            x = nx * temp1;
            y = ny * temp2;
            for (int i = y; i < space.GetLength(0); i++)
            {
                for (int j = x; j < space.GetLength(1); j++)
                {
                    if (i < y + width && j < x + width)
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
            for (int i = 0; i < space.GetLength(0)  ; i++)
            {
                for (int j = 0; j < space.GetLength(1); j++)
                {
                    if (space[i,j] == 1)
                    {
                        Console.Write("O");
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
