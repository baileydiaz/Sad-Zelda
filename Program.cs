// See https://aka.ms/new-console-template for more information
using Raylib_cs;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main()
        {
            var ScreenHeight = 480;
            var ScreenWidth = 800;
  

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
               
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                

                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();
        }
    }
}

