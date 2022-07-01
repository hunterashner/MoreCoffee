using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoreCoffee.TilemapSystem
{
    public class Tile
    {
        public Texture2D _texture;
        private Int16 _pixelsWide;
        private Int16 _pixelsHigh;
        private Rectangle _rect;

        public Texture2D Texture { get { return this._texture; } }
        public Rectangle Rect { get { return this._rect; } }

        public Tile(Texture2D texture, Int16 pixelsWide, Int16 pixelsHigh)
        {
            this._texture = texture;
            this._pixelsWide = pixelsWide;
            this._pixelsHigh = pixelsHigh;
        }
        public Tile(Texture2D texture, Int16 pixelsWide, Int16 pixelsHigh, Rectangle rect)
        {
            this._texture = texture;
            this._pixelsWide = pixelsWide;
            this._pixelsHigh = pixelsHigh;
            this._rect = rect;
        }
    }
}
