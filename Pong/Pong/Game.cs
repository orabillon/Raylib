using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Game
    {
        Font font;

        private void _Init()
        {
            font = Raylib.GetFontDefault();
        }

        public Game()
        {
            _Init();
        }

        public void Update(float dt)
        {
            
        }

        public void Draw()
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Raylib.BLACK);

            string text = "PONG";

            Vector2 textSize = Raylib.MeasureTextEx(font, text, 90, 20);
            Vector2 pos = new Vector2((Raylib.GetScreenWidth() - textSize.X) / 2, (Raylib.GetScreenHeight() - textSize.Y) / 2);

            Raylib.DrawTextEx(font, text, pos, 90, 20, Raylib.WHITE);

            Raylib.EndDrawing();
        }

        public void _Unload()
        {
           
        }
    }
}

