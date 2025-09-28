using _2DPlatformer;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

public abstract class BaseState
{
    protected ContentManager contentManager;
    protected GraphicsDevice graphicsDevice;
	public BaseState(ContentManager contentManager, GraphicsDevice graphicsDevice)
	{
	    this.contentManager = contentManager;
        this.graphicsDevice = graphicsDevice;
    }

    public abstract void onEnter();
    public abstract void onExit();
    public abstract void update();

    //process player input in the context of whatever
    //state they are in.
    public abstract void handleInput();

    public abstract void draw();
}
