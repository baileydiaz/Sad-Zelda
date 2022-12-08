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

}

class wall: thing{

        //public List<fallingObjects> Objects {get; set;} = new List<fallingObjects>();
        //public RandomObject(){

    }

        //public void GenerateRandomObject(Vector2 position, int whichType){
        //switch (whichType) {
       // case 0:
      //  Console.WriteLine("Creating a square");
     //   var square = new Rock(Color.YELLOW, 20);
      //  square.Position = position;
      //  square.Velocity = new Vector2(0, 1);
     //   Objects.Add(square);
     //   break;
     //   case 1:
     //   Console.WriteLine("Creating a circle");
      //   var circle = new Gem(Color.RED, 20);
      //  circle.Position = position;
     //   circle.Velocity = new Vector2(0, 1);
      //  Objects.Add(circle);
      //  break;
     //   default:
      //  break;
  //  }
//}
//}

class puddles: thing{
    
}

class armor: thing{

}
