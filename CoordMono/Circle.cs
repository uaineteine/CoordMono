using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uaine.Monogame.Coord
{
    public class Circle
    {
        public Circle(Vector2 centre, float rad)
        {
            r = rad;
            origin = CVec.fromVec(centre);
        }
        public Circle(fcoord centre, float rad)
        {
            r = rad;
            origin = centre;
        }

        float r;
        fcoord origin;

        public void updateOrigin(fcoord point)
        {
            origin = point;
        }

        public void updateOrigin(Vector2 point)
        {
            updateOrigin(CVec.fromVec(point));
        }

        public bool Contains(Vector2 point)
        {
            return Contains(CVec.fromVec(point));
        }

        public bool Contains(Point point)
        {
            return Contains(new Vector2(point.X, point.Y));
        }

        public bool Contains(fcoord point)
        {
            fcoord diff = point - origin;
            float rad = (float)diff.Norm();
            if (rad <= r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
