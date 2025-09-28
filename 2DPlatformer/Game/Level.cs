using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MogaMan.Game;

public class Level
{
    string[] level;

    Tile ground;

    Dictionary<char, Tile> tiles = [];

    public void InitializeTiles(GraphicsDevice device)
    {
        ReadLevelTextFile();
        
        ground = new('x', Texture2D.FromFile(device, "C:\\Users\\jacob\\Desktop\\gamesIveMade\\2DPlatformerMonoGames\\2DPlatformer\\2DPlatformer\\Grass.jpg"));
        tiles.Add(ground._identifier, ground);
    }
    // 6x6
    public void ReadLevelTextFile()
    {
        level = File.ReadAllLines("C:\\Users\\jacob\\Desktop\\gamesIveMade\\2DPlatformerMonoGames\\2DPlatformer\\2DPlatformer\\levelData.txt");       
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        //Debug.WriteLine(level);
        DrawLevel(spriteBatch);
    }

    private void DrawLevel(SpriteBatch spriteBatch)
    {
        int row = 0;
        int column = 0;
        for (int i = 0; i < level.Length; i++)
        {   
            column = 0;
            foreach (char c in level[i])
            {
                try { tiles[c].DrawTile(spriteBatch, new(column, row)); }
                catch { Debug.WriteLine("Tile identifier not found in list: " + c); }
                column += 225;
            }
            row += 225;
        }
    }
}
