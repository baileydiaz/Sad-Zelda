using Raylib_cs;
using System.Numerics;
abstract class Character
{
    protected Rectangle VillainRectangle{get;set;}

}

class Villain: Character
 {
    public Villain(Rectangle VillainRectangle) 
{
    Vilrec = VillainRectangle;
}
    public Rectangle Vilrec{get;set;}

    public void DrawVillain(){
        Raylib.DrawRectangleRec(Vilrec, Color.YELLOW);
    }
}

public class Hero{
    protected List<string> Posessions {get; set;} = new List<string>();
    bool has_sword = false;
    public Hero(int MovementSpeed, Rectangle HeroRectangle){
        Herorec = HeroRectangle;
        Speed = MovementSpeed;
    }
    public Rectangle Herorec{get;set;}
    int Speed;
    public void input(){
                var rec = Herorec; 
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) {
                if (Herorec.x < 780)
                rec.x += Speed;
                }
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) {
                if (Herorec.x > 0)
                rec.x -= Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) {
                if (Herorec.y > 0)
                rec.y -= Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) {
                if (Herorec.y < 460)
                
                rec.y += Speed;
                }
                Herorec = rec;
    }

    public void drawHero(){
        Raylib.DrawRectangleRec(Herorec, Color.BLUE);
    }
}



class thing{
    public List<thing> Things {get; set;} = new List<thing>();
    public thing(){

    }
    public Vector2 Position = new Vector2(0,0);
    virtual public void Draw() {
    }
    public Color Color {get; set;}
    
}

class wall: thing{

    public List<thing> Objects {get; set;} = new List<thing>();
    public wall(Rectangle wall){
        Wall = wall;
    }
    public Rectangle Wall{get;set;}

    public void drawWall(){
    Raylib.DrawRectangleRec(Wall, Color.RED);
    }

    }

class puddles: thing{
    
}

