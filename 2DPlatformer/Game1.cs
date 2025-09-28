using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MogaMan.Game;
using MonoGameLibrary;

namespace _2DPlatformer;

public class Game1 : Core
{
    //private GraphicsDeviceManager _graphics;
    //private SpriteBatch _spriteBatch;
    private Level level = new();

    public Game1() : base("MogaMan 2.5", 1920, 1080, false)
    {
        //_graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        
        base.Initialize();
    }

    protected override void LoadContent()
    {
        //_spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        level.LoadContent(GraphicsDevice, Content);
        base.LoadContent();
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
        SpriteBatch.Begin();

        level.Draw(SpriteBatch);

        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
