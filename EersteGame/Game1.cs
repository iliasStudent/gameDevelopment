using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace EersteGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _texture;

        private Vector2 _position;
        private Rectangle _deelRectangle;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _deelRectangle = new Rectangle(0,0,160, 111);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _texture = Content.Load<Texture2D>("Characters/Hero/Idle");
            _position = new Vector2(0, 0);
           
        }

        protected override void Update(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //    Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _position.Y += 1;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                _position.Y -= 1;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Q))
            {
                _position.X -= 1;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _position.X += 1;
            }
            // TODO: Add your update logic here
            //Debug.WriteLine("update");
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Red);
            _spriteBatch.Begin();
            // TODO: Add your drawing code here
            //7de parameter is om de zoom van uw sprite te bepalen
            _spriteBatch.Draw(_texture, _position, _deelRectangle, Color.White, 0f, Vector2.Zero, 2f, SpriteEffects.None, 0f);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}