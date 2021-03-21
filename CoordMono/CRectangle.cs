using Microsoft.Xna.Framework;
using Uaine.Coord;

namespace Uaine.Monogame.Coord
{
    public static class CRectangle
    {
        public static Rectangle toRect(coord pos, coord size)
        {
            return new Rectangle(pos.x, pos.y, size.x, size.y);
        }
        public static Rectangle toRect(int posx, int posy, coord size)
        {
            return toRect(new coord(posx, posy), size);
        }

        public static Rectangle toRect(coord pos, int sizex, int sizey)
        {
            return toRect(pos, new coord(sizex, sizey));
        }
    }
}
