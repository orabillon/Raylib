using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CasseBrique
{
    public class Game
    {
        Balle maBalle;


        private void _Init()
        {
           maBalle = new Balle("images/balle.png",10,10);
        }

        public Game()
        {
            _Init();
        }

        public void Update(float dt)
        {
            maBalle.Update(dt);
        }

        public void Draw()
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Raylib.BLACK);

           
            maBalle.Draw();

            Raylib.EndDrawing();
        }

        public void _Unload()
        {
            maBalle.Unload();
        }
    }
}

