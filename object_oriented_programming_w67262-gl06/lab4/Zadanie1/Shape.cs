namespace object_oriented_programming_w67262_gl06.lab4.Zadanie1;

public class Shape
{
    public float X;
    public float Y;

    public float Height;
    public float Width;


    public Shape(float X, float Y, float Height, float Width)
    {
        this.X = X;
        this.Y = Y;
        this.Height = Height;
        this.Width = Width;
    }


    public virtual void Draw()
    {
        Console.WriteLine($"Shape = (X: {X}, Y: {Y}, Height: {Height}, Width: {Width})");
    }
}