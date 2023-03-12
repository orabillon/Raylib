using Raylib_CsLo;

namespace CasseBrique
{

    public static class Program
    {
        public static Game game = new Game();
        public static Task Main(string[] args)
        {
            Raylib.InitWindow(720, 720, "Mon Casse Brique Raylib");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                game.Update(Raylib.GetFrameTime());
                game.Draw();
            }

            // libere les resource
            game._Unload();

            Raylib.CloseWindow();
            return Task.CompletedTask;
        }
    }
}