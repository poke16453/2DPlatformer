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
    Sprite megamanSprite;

    public GameplayState(ContentManager contentManager, GraphicsDevice graphicsDevice) : 
    base(contentManager, graphicsDevice)
    {

    }
    public override void onEnter()
    {
        this.megamanTexture = this.contentManager.Load<Texture2D>("megaman");
        megamanSprite = new Sprite(this.megamanTexture, 40, 40, graphicsDevice);
    }
    public override void onExit() {

    }
    public override void update() {
    
    }

    public override void handleInput() {
    
    }

    public override void draw() {
        this.megamanSprite.draw();
    }
}