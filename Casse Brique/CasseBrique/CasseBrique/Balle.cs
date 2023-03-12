using CasseBrique.MyLib;
using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasseBrique
{
    public class Balle
    {
        public Sprite sBalle { get; set; }

        public Balle(string pImage, int pX, int pY)
        {
            sBalle = new Sprite(pImage, pX, pY);
            
        }

        public void Update(float dt)
        {

        }

        public void Draw()
        {
            Raylib.DrawTexture(sBalle.Image, sBalle.X, sBalle.Y, Raylib.WHITE);
        }

        public void Unload()
        {
            sBalle.Unload();
        }

    }
}
