using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MogaMan.Game;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;
using System.Collections.Generic;

namespace _2DPlatformer;

public class Game1 : Core
{
    //private GraphicsDeviceManager _graphics;
    //private SpriteBatch _spriteBatch;
    GameplayState gameplayState;
    List<BaseState> stateContainer;
    private Level level = new();

    public Game1() : base("MogaMan 2.5", 1350, 1350, false)
    {
        //_graphics = new GraphicsDeviceManager(this);
        //Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
        stateContainer = new List<BaseState>();
        gameplayState = new GameplayState(Content, GraphicsDevice);
        gameplayState.onEnter();
        stateContainer.Add(gameplayState);
    }

    protected override void LoadContent()
    {
        //_spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here

        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        foreach (BaseState state in stateContainer)
        {
            state.update();
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        foreach (BaseState state in stateContainer)
        {
            state.draw();
        }

        base.Draw(gameTime);
    }
}
