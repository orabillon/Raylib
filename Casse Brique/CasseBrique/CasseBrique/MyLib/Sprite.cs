using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasseBrique.MyLib
{
    public class Sprite
    {
        public Texture Image { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Sprite(string pImage, int pX = 0, int pY = 0)
        {
            Image = Raylib.LoadTexture(pImage);
            X = pX;
            Y = pY;
        }

        public void Unload() { 
            Raylib.UnloadTexture(Image);
        }
    }
}
