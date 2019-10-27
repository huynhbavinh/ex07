using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l1 = new Line(2, 7);
            l1.move(2, 10);
            l1.draw();
        }
    }
}
