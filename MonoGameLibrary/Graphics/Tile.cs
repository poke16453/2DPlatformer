using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MonoGameLibrary.Graphics;

public class Tile
{
    public Tile(Char identifier, Texture2D texture)
    {
        _identifier = identifier;
        _texture = ResizeTexture(texture);

        
    }
    public char _identifier;

    public Texture2D _texture;

    public Vector2 _size;

    public void DrawTile(SpriteBatch spriteBatch, Vector2 position)
    {
        if (_texture == null) throw new SystemException("Tile Is Missing Texture");

        spriteBatch.Draw(_texture, 
            position, 
            null,
            Color.White,
            0.0f,
            Vector2.Zero,
            1f,
            SpriteEffects.None,
            0.0f);
    }
    private static Texture2D ResizeTexture(Texture2D texture2D)
    {
        return texture2D;
    }
}
