using MathLibrary;
using Raylib_cs;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 480, "Hello World");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                Raylib.DrawText("Raylib is better than the console!", 12, 12, 20, Color.Black);
                Raylib.DrawRectangle(100, 100, 100, 100, new Color(100, 200, 150, 100));
                Raylib.DrawRectangle(150, 150, 100, 100, new Color(100, 200, 150, 100));
                Raylib.DrawRectangleV(new Vector2(100, 100), new Vector2(150, 150), Color.Red);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
