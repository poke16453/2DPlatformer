using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//base class for all entities in the game
public class EntityBase
{
    //each entity has a pointer to the map of tiles


    Texture2D entityTexture;
    void move(float x, float y)
    {

    }

    void update(float x, float y) { 
    
    }

    void checkCollisions()
    {

    }

    float[] position = {0, 0};    
}