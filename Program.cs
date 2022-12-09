using Raylib_cs;
using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var Herorec = new Rectangle(ScreenWidth / 2, ScreenHeight - 30 , 20, 20);
            var MovementSpeed = 4;

            Hero hero = new Hero(MovementSpeed, Herorec);
            
            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                hero.drawHero();
                hero.input();
                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();
        }
    }


