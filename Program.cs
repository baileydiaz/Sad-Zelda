using Raylib_cs;
using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var MovementSpeed = 4;
            var Herorec = new Rectangle(10, 460, 20, 20);
            var Vilrec = new Rectangle(750, 50 , 20, 20);

            var WallRec = new Rectangle(0, 100 , 450, 20);
            var WallRec2 = new Rectangle(0, 400 , 250, 20);
            var WallRec3 = new Rectangle(400 ,150 , 20, 400);
            var WallRec4 = new Rectangle(700 ,10 , 20, 400);
            
            Hero hero = new Hero(MovementSpeed, Herorec);
            Villain villain = new Villain(Vilrec);
            wall wallrec1 = new wall(WallRec);
            wall wallrec2 = new wall(WallRec2);
            wall wallrec3 = new wall(WallRec3);
            wall wallrec4 = new wall(WallRec4);

            thing thing = new thing(); 
            thing.Things.Add(wallrec1);
            thing.Things.Add(wallrec2);
            thing.Things.Add(wallrec3);
            thing.Things.Add(wallrec4);
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
                wallrec4.drawWall();
                villain.DrawVillain();
                hero.input();
                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();
        }
    }


