using Raylib_CsLo;

namespace Pong
{

    public static class Program
    {
        public static Game game = new Game();
        public static Task Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Pong Raylib");
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