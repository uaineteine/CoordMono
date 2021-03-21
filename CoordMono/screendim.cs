using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uaine.Monogame.Coord
{
    public class screendim
    {
        coord size;
        public coord getSize()
        {
            return size;
        }

        coord aspratio;
        
        public screendim(coord s, coord ratio)
        {
            size = s;
            aspratio = ratio;
        }
        public screendim(coord ratio, int width)
        {
            int unit = width / ratio.x;
            size = new coord(width, unit * ratio.y);
            aspratio = ratio;
        }

        private static coord calcRatio(coord s)
        {
            int whl = s.x / s.y;
            int rem = s.x % s.y;
            coord rat = new coord(whl*s.y + rem, s.y);

            return rat;
        }

        public bool hasRat(int v1, int v2)
        {
            if (aspratio.x == v1 && aspratio.y == v2)
                return true;
            else
            {
                fcoord asp = new fcoord(aspratio);
                fcoord v = new fcoord(v1, v2);
                float a1 = asp.x / asp.y;
                float a2 = v.x / v.y;
                if (a1 == a2)
                    return true;
                else
                    return false;
            }
        }
    }
}
