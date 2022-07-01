using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoreCoffee.TilemapSystem
{
    class Tilemap
    {
        private Texture2D _texture;
        private Int16 _width;
        private Int16 _height;
        private Byte _cellWidthHeightInPixels;

        public Texture2D Texture { get { return this._texture; } }
        public Tilemap(Texture2D texture, Int16 width, Int16 height, Byte cellWidthHeightInPixels)
        {
            this._texture = texture;
            this._width = width;
            this._height = height;
            this._cellWidthHeightInPixels = cellWidthHeightInPixels;
        }
    }
}
