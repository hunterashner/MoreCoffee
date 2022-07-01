using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MoreCoffee.TilemapSystem;

namespace MoreCoffee.AnimationSystem
{
    class AnimatedTile : DrawableGameComponent
    {
        private Game _game;
        private Tile[] _tiles;
        private Tile _currentTile;
        private int _currentFrame;
        private int _totalFrames;

        public AnimatedTile(Game game, Tile[] tiles) : base(game)
        {
            this._game = game;
            this._tiles = tiles;
        }

        public override void Update(GameTime gameTime)
        {
            _currentFrame++;
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
