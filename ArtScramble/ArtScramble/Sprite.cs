using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ArtScramble
{
    class Sprite
    {
        //The current position of the Sprite
        public Vector2 Position = new Vector2(0, 0);

        //The texture object used when drawing the sprite
        private Texture2D SpriteTexture;
        private Rectangle TitleSafe;
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            SpriteTexture = Content.Load<Texture2D>("ArtScrambleContent/rough_player");
            TitleSafe = GetTitleSafeArea(.8f);
        }
        protected Rectangle GetTitleSafeArea(float percent)
        {
            Rectangle retval = new Rectangle(
                graphics.GraphicsDevice.Viewport.X,
                graphics.GraphicsDevice.Viewport.Y,
                graphics.GraphicsDevice.Viewport.Width,
                graphics.GraphicsDevice.Viewport.Height);
        }
        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            Vector2 pos = new Vector2(TitleSafe.Left, TitleSafe.Top);
            spriteBatch.Draw(SpriteTexture, pos, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
