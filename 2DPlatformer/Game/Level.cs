using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;
using System.IO;

using MogaMan.Game.Obj;

namespace MogaMan.Game;

public class Level
{
    string[] level;
    public TileManager tileManager = new();

    public void LoadContent(GraphicsDevice device, ContentManager Content)
    {
        ReadTxtLevelFile(Content);

        tileManager.LoadContent(Content);
    }
    private void ReadTxtLevelFile(ContentManager Content)
    {        
        var levelPath = Path.Combine(Content.RootDirectory, "levelData.txt");
        using var stream = TitleContainer.OpenStream(levelPath);
        level = File.ReadAllLines(levelPath);
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        //Debug.WriteLine(level);
        DrawLevel(spriteBatch);
    }

    private void DrawLevel(SpriteBatch spriteBatch)
    {
        // Draws from a grid of 9 by 5
        int row = 0;
        int column;
        for (int i = 0; i < level.Length; i++)
        {   
            column = 0;
            foreach (char c in level[i])
            {
                try { tileManager.tiles[c].DrawTile(spriteBatch, new(column, row)); }
                catch { Debug.WriteLine("Tile identifier not found in list: " + c); }
                column += (int)tileManager.tileSize.X;
            }
            row += (int)tileManager.tileSize.Y;
        }
    }
}
