using Raylib_cs;
using System.Numerics;
abstract class Character
{
        public Rectangle VillainRectangle{get;set;}

}

class Villain: Character
 {
    public Villain(Rectangle VillainRectangle) 
{
    Vilrec = VillainRectangle;
}
    private void drawHero(){
        Raylib.DrawRectangleRec(VilRec, Color.BLACK);
    }
}

public class Hero{
    protected List<string> Posessions {get; set;} = new List<string>();
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
        Raylib.DrawRectangleRec(Herorec, Color.BLACK);
    }
}



class thing{
    public thing(){

    }
    // Public List<things> thing {get; set;} = new List<things>();
    // public Vector2 Position = new Vector2(0,0);
    // virtual public void Draw() {
    // }
    // public Color Color {get; set;}

    // public ColoredThing(Color color){
    //     Color = color;
    //     return Color;
    // }
}

class wall: thing{

    //public List<Object> Objects {get; set;} = new List<Object>();
    //public wall(int Positionx, int Positiony){
        
    //}

    //public void GenerateRandomObject(Vector2 position){
        //Console.WriteLine("Creating a square");
        //var square = new thing();
        //square.Position = position;
        //Objects.Add(Objects);
    //}

    }

class puddles: thing{
    
}

class armor: thing{

}
