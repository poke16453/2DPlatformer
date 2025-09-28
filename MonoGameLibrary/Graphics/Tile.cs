using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MonoGameLibrary.Graphics;

public class Tile
{
    public Tile(Char identifier, string name, Texture2D texture, bool dealsDamage, bool iscollidable)
    {
        _identifier = identifier;
        _name = name;
        _texture = texture;
        _dealsDamage = dealsDamage;
        _iscollidable = iscollidable;
    }
    public char _identifier;

    public string _name;

    public Texture2D _texture;

    public bool _dealsDamage;

    public bool _iscollidable;

    //public Vector2 _size;

    public void DrawTile(SpriteBatch spriteBatch, Vector2 position)
    {
        if (_texture == null) throw new SystemException("Tile Is Missing Texture");

        spriteBatch.Draw(_texture, 
            position, 
            null,
            Color.White,
            0.0f,
            Vector2.Zero,
            2f,
            SpriteEffects.None,
            0.0f);
    }
}
