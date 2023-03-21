using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Sprite
    {
        public Texture Image { get; private set; }
        public Vector2 Position { get; set; }
        public string Name { get; set; }
       

        public Sprite(string pImage, int pX = 0, int pY = 0)
        {
            Image = Raylib.LoadTexture(pImage);
            Name = pImage;
            Debug.Assert(Image.width != 0,$"Erreur de chargement de l'image {Name}");

            Position = new Vector2(pX, pY);
        }

        public void Unload() { 
            Raylib.UnloadTexture(Image);
        }
    }
}
