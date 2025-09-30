using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sprite
{
    private Texture2D texture;
    private float spriteX;
    private float spriteY;
    private float spriteSize;
    private Color spriteColor;
    private SpriteBatch spriteBatch;

    public Sprite(Texture2D texture, float spriteX, float spriteY, GraphicsDevice graphicsDevice)
    {
        this.spriteBatch = new SpriteBatch(graphicsDevice);
        this.texture = texture;
        this.spriteX = spriteX;
        this.spriteY = spriteY;
        this.spriteColor = Color.White;
    }

    public void setColor(Color newColor) { this.spriteColor = newColor; }
    
    public Color getColor() { return this.spriteColor; }
    
    public void setLocation(float x, float y) {
        this.spriteX = x;
        this.spriteY = y;
    }

    public Vector2 getLocation() { 
        Vector2 v = new Vector2(this.spriteX, this.spriteY);
        return v;
    }
    public void setTexture(Texture2D texture) {
        this.texture = texture;
    }
    public Texture2D getTexture() {
        return this.texture;
    }

    public void draw()
    {
        spriteBatch.Begin();
        spriteBatch.Draw(this.texture, new Vector2(this.spriteX, this.spriteY), this.spriteColor);
        spriteBatch.End();
    }
}
