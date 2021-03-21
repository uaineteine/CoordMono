using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uaine.Coord;
using Microsoft.Xna.Framework;

namespace Uaine.Monogame.Coord
{
    public static class CVec
    {
        public static Vector2 toVec2(coord p)
        {
            return new Vector2(p.x, p.y);
        }

        public static fcoord fromVec(Vector2 p)
        {
            return new fcoord(p.X, p.Y);
        }

        public static void NormaliseValues(ref Vector3 values)
        {
            abs(ref values.X);
            abs(ref values.Y);
            abs(ref values.Z);
        }

        private static void abs(ref float v)
        {
            v = Math.Abs(v);
        }
    }
}
