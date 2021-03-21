using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uaine.Coord;

namespace Uaine.Monogame.Coord
{
    public class MouseCoord : coord
    {
        public MouseCoord(coord pos) : base(pos.x, pos.y)
        {
            //add here
        }
        public MouseCoord(MouseState ms) : base(ms.X, ms.Y)
        {
            //add here
        }
        public MouseCoord(int xi, int yi) : base(xi, yi)
        {
            //add here
        }
    }
}
