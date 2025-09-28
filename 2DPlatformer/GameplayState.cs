using _2DPlatformer;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using System.Collections.Generic;
using System.Net.Mime;


public class GameplayState : BaseState
{
    private Texture2D megamanTexture;
    SpriteBatch _spriteBatch;
    private int spriteX = 40;
    private int spriteY = 40;

    public GameplayState(ContentManager contentManager, GraphicsDevice graphicsDevice) : 
    base(contentManager, graphicsDevice)
    {

    }
    public override void onEnter() {
        this._spriteBatch = new SpriteBatch(graphicsDevice);
        this.megamanTexture = this.contentManager.Load<Texture2D>("megaman");
    }
    public override void onExit() {

    }
    public override void update() {
    
    }

    public override void handleInput() {
    
    }

    public override void draw() {
        _spriteBatch.Begin();
        _spriteBatch.Draw(megamanTexture, new Vector2(40, 40), Color.White);
        _spriteBatch.End();
    }
}