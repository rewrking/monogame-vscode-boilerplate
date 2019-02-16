using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame
{
    class Root : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Root()
        {
            graphics = new GraphicsDeviceManager(this);

            // Window
            graphics.PreferredBackBufferWidth = 960;
            graphics.PreferredBackBufferHeight = 540;

            // Fullscreen Window (Max Resolution)
            //graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            //graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

            // Fullscreen (Max Resolution)
            //graphics.IsFullScreen = true;

            graphics.ApplyChanges();

            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            Log.Clear();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            Log.Print("Terminal Active\n");
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
