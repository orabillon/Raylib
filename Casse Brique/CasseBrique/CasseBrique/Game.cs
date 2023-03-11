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
      
        private void _Init()
        {
           
        }

        public Game()
        {
            _Init();
        }

        public void Update()
        {
           
        }

        public void Draw()
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Raylib.WHITE);

            Raylib.DrawText("CASSE BRIQUE", 1, 1, 20, Raylib.DARKBLUE);

            Raylib.EndDrawing();
        }
    }
}

