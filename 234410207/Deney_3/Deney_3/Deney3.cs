using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deney_3_
{
    internal class Deney3
    {
    }

    public unsafe class Dortgen
    {
        public int x;
        public int y;

        public Dortgen() 
        {
            x = 5;
            y = 10;
        }

        public Dortgen(int a, int b)
        {
            x = a;
            y = b;
        }

        public void DegerVer(int a, int b)
        {
            x = a;
            y = b;
        }

        public int Alan()
        {
            return x*y;
        } 
    }
}
