namespace object_oriented_programming_w67262_gl06.lab5.Zadanie2;


public class Point
{
    private float x, y;

    public float X { get { return x; } set { x = value; } }
    public float Y { get { return y; } set { y = value; } }

    public Point()
    {

    }

    public Point(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }

    public static float LenghtValue(Point a, Point b)
    {
        return (float)Math.Sqrt((Math.Pow((b.X - a.X), 2) - Math.Pow((b.Y - a.Y), 2)));
    }
    
    public override bool Equals(object? obj)
    {
        if(obj == null || obj is not Point)
            return false;

        Point point = (Point)obj;

        if(point == null || point.X != X || point.Y != Y) 
            return false;

        return true;
    }
}

