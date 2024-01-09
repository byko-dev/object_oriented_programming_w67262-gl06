namespace object_oriented_programming_w67262_gl06.lab4.Zadanie1;

public class Rectangle : Shape
{
    public Rectangle(float X, float Y, float Height, float Width) : base(X, Y, Height, Width)
    {
            
    }
    
    public override void Draw()
    {
        Console.WriteLine($"Rectangle = (X: {X}, Y: {Y}, Height: {Height}, Width: {Width})");
    }
}