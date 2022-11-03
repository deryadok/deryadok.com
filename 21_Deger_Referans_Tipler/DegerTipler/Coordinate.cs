using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Deger_Referans_Tipler.DegerTipler
{
    struct Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int Sum()
        {
            return X + Y;
        }
    }
}
