using Raylib_cs;
using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var MovementSpeed = 4;
            var Herorec = new Rectangle(ScreenWidth / 2, ScreenHeight - 30 , 20, 20);
            var Vilrec = new Rectangle(ScreenWidth / 2, ScreenHeight - 30 , 20, 20);
            var WallRec = new Rectangle(ScreenWidth / 2, ScreenHeight - 50 , 20, 20);
            var WallRec2 = new Rectangle(ScreenWidth / 2, ScreenHeight - 40 , 20, 20);
            var WallRec3 = new Rectangle(ScreenWidth / 2, ScreenHeight - 70 , 20, 20);
            
            Hero hero = new Hero(MovementSpeed, Herorec);
            Villain villain = new Villain(Vilrec);
            wall wallrec1 = new wall(WallRec);
            wall wallrec2 = new wall(WallRec2);
            wall wallrec3 = new wall(WallRec3);

            thing thing = new thing(); 
            thing.Things.Add(wallrec1);
            thing.Things.Add(wallrec2);
            thing.Things.Add(wallrec3);
            List<thing> things = thing.Things;

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                hero.drawHero();
                wallrec1.drawWall();
                wallrec2.drawWall();
                wallrec3.drawWall();
                villain.DrawVillain();
                hero.input();
                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();
        }
    }


