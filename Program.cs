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
            var StartRec = new Rectangle(10, 460, 30, 30);
            var Vilrec = new Rectangle(750, 50 , 20, 20);

            var WallRec = new Rectangle(0, 100 , 450, 20);
            var WallRec2 = new Rectangle(0, 400 , 250, 20);
            var WallRec3 = new Rectangle(400 ,150 , 20, 400);
            var WallRec4 = new Rectangle(700 ,10 , 20, 400);

            var Puddle = new Rectangle(10 ,10 , 10, 10);
            
            bool sword_encounter = false;
            Hero hero = new Hero(MovementSpeed, Herorec);
            Villain villain = new Villain(Vilrec);
            wall wallrec1 = new wall(WallRec);
            wall wallrec2 = new wall(WallRec2);
            wall wallrec3 = new wall(WallRec3);
            wall wallrec4 = new wall(WallRec4);
            puddles puddle1 = new puddles(Puddle);
            startSquares start1 = new startSquares(StartRec);

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
                start1.drawStartSquare();
                hero.drawHero();
                wallrec1.drawWall();
                wallrec2.drawWall();
                wallrec3.drawWall();
                wallrec4.drawWall();
                villain.DrawVillain();
                puddle1.drawPuddle();
                hero.input();
                foreach (var obj in thing.Things.ToList()){
                    if (obj is wall){
                        var thespike = (wall)obj;
                        if (Raylib.CheckCollisionRecs(hero.Herorec, WallRec)){
                            Raylib.DrawRectangleRec(Herorec, Color.GREEN);
                            Raylib.CloseWindow();
                        }
                        if (Raylib.CheckCollisionRecs(hero.Herorec, WallRec2)){
                            Raylib.DrawRectangleRec(Herorec, Color.GREEN);
                            Raylib.CloseWindow();
                        }
                        if (Raylib.CheckCollisionRecs(hero.Herorec, WallRec3)){
                            Raylib.DrawRectangleRec(Herorec, Color.GREEN);
                            Raylib.CloseWindow();
                        }
                        if (Raylib.CheckCollisionRecs(hero.Herorec, WallRec4)){
                            Raylib.DrawRectangleRec(Herorec, Color.GREEN);
                            Raylib.CloseWindow();
                        }
                    }
                }

                if (Raylib.CheckCollisionRecs(hero.Herorec, start1.StartRec)){
                    Raylib.DrawText("You are the hero. There is a goblin on the other side of the room.", ScreenWidth / 2 - 300, (ScreenHeight / 2)-30, 15, Color.WHITE);
                    Raylib.DrawText("Stay away from the walls, but look around, you will find something to help you beat the goblin.", ScreenWidth / 2 - 300, (ScreenHeight / 2)-15, 15, Color.WHITE);
                    Raylib.DrawText("Good Luck!", ScreenWidth / 2 - 300, ScreenHeight / 2, 15, Color.WHITE);
                }

                if (Raylib.CheckCollisionRecs(hero.Herorec, puddle1.Puddle)){
                    if (hero.has_sword == false){
                        hero.has_sword = true;
                        }

                    else{
                        
                    }

                if (hero.has_sword == true)
                    Raylib.DrawText("You have the goblin slaying greatsword!", ScreenWidth / 2 - 80, ScreenHeight / 2, 15, Color.WHITE);

                    }


                if (Raylib.CheckCollisionRecs(hero.Herorec, villain.Vilrec)){
                    if (hero.has_sword){
                        Raylib.DrawText("You won!", ScreenWidth / 2 - 80, ScreenHeight / 2, 15, Color.WHITE);
                            }
                    else{
                        Raylib.DrawText("You died!", ScreenWidth / 2 - 80, ScreenHeight / 2, 15, Color.WHITE);
                        Raylib.CloseWindow();
                    }}


                Raylib.EndDrawing();

            }

            Raylib.CloseWindow();
        }
    }


