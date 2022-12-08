using Raylib_cs;
using System.Numerics;
class character{

}

class villain: character{

}

public class Hero{
    public Hero(int MovementSpeed, Rectangle HeroRectangle){
        Herorec = HeroRectangle;
        Speed = MovementSpeed;
    }
    public Rectangle Herorec{get;set;}
    int Speed;
    public void input(){
                var rec = Herorec; 
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) {
                rec.x += Speed;
                }
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) {
                rec.x -= Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) {
                rec.y -= Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) {
                rec.y += Speed;
                }
                Herorec = rec;
    }

    public void drawHero(){
        Raylib.DrawRectangleRec(Herorec, Color.BLACK);
    }
}



class thing{
    //public thing(){

    //}
    //Public List<things> thing {get; set;} = new List<things>();
    //public Vector2 Position = new Vector2(0,0);
    //virtual public void Draw() {
    //}
    //public Color Color {get; set;}

    //public ColoredThing(Color color){
        //Color = color;
        //return Color;
    //}
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
