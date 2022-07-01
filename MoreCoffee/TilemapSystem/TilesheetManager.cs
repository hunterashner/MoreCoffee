using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoreCoffee.TilemapSystem
{
    //entire tilemap systems assumes square tiles of no more 256 pixels high/wide
    class TilesheetManager
    {
        GraphicsDevice _graphicsDevice;
        public TilesheetManager(GraphicsDevice graphicsDevice) 
        {
            this._graphicsDevice = graphicsDevice;
        }

        //reinventing the wheel
        public Tile[] TilesheetSplicer(Texture2D texture, Int16 width, Int16 height, Point cellSize) 
        {
            int totalCells = width * height;
            Tile[] tiles = new Tile[totalCells];
            Rectangle[] rectangles = new Rectangle[totalCells];

            int counter = 0;
            int counter1 = 0;
            int startingX = 0;
            int startingY = 0;

            foreach(Rectangle rectangle in rectangles)
            {
                rectangles[counter] = new Rectangle(startingX, startingY, cellSize.X, cellSize.Y);
                startingX += cellSize.X;
                counter++;
                counter1++;
                if(counter1 == width)
                {
                    startingX = 0;
                    startingY += cellSize.Y;
                    counter1 = 0;
                }
            }

            counter = 0;
            foreach(Tile tile in tiles)
            {
                Color[] tilePixels = new Color[cellSize.X * cellSize.Y];
                texture.GetData<Color>(0, rectangles[counter], tilePixels, 0, tilePixels.Length);
                Texture2D tileTexture = new Texture2D(_graphicsDevice, cellSize.X, cellSize.Y);
                tileTexture.SetData<Color>(tilePixels);
                tiles[counter] = new Tile(tileTexture, (short)cellSize.X, (short)cellSize.Y);
                counter++;
            }

            return tiles;
            
        }

        //head hitting keyboard
        public Tilemap CreateNewTilemap(Tile[] tiles, byte[] tileSelection, short width, short height, Point cellSize)
        {
            Rectangle[] rectangles = new Rectangle[width * height];

            int counter = 0;
            int counter1 = 0;
            int startingX = 0;
            int startingY = 0;

            foreach (Rectangle rectangle in rectangles)
            {
                rectangles[counter] = new Rectangle(startingX, startingY, cellSize.X, cellSize.Y);
                startingX += cellSize.X;
                counter++;
                counter1++;
                if (counter1 == width)
                {
                    startingX = 0;
                    startingY += cellSize.Y;
                    counter1 = 0;
                }
            }

            Texture2D tilemapTexture = new Texture2D(_graphicsDevice, width * cellSize.X, height * cellSize.Y);
            counter = 0;
            int pixelCounter = 0;
            foreach(Byte digit in tileSelection)
            {
                Color[] tilePixels = new Color[cellSize.X * cellSize.Y];
                int selection = tileSelection[counter];
                tiles[selection].Texture.GetData<Color>(tilePixels);
                tilemapTexture.SetData<Color>(0, rectangles[counter], tilePixels, 0, tilePixels.Length);
                pixelCounter += cellSize.X * cellSize.Y;
                if(pixelCounter >= tilePixels.Length)
                {
                    pixelCounter = tilePixels.Length - 1;
                }
                counter++;
            }

            Tilemap tilemap = new Tilemap(tilemapTexture, width, height, (byte)cellSize.X);
            return tilemap;
        }
    
    }
}
