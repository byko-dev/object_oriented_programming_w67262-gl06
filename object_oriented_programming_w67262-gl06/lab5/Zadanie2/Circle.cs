namespace object_oriented_programming_w67262_gl06.lab5.Zadanie2;

internal class Circle : ICloneable , IFigure
{
    public Point point;
    public float r;
    public string name;

    public Circle() { }

    public Circle(Point point, float r, string name)
    {
        this.point = point;
        this.r = r;
        this.name = name;
    }

    public object Clone()
    {
        return new Circle(point, r, name);
    }

    public float Obwod()
    {
        return (float) (2 * Math.PI * r);
    }


    public static bool operator <(Circle a, Circle b)
    {
        return a.Obwod() < b.Obwod();
    }

    public static bool operator >(Circle a, Circle b)
    {
        return a.Obwod() > b.Obwod();
    }

    public override string ToString()
    {
        return $"Circle = {name}, r = {r}, points = {point}";
    }
    
    public override bool Equals(object? obj)
    {
        if(obj == null || obj is not Circle)
            return false;

        Circle circle = (Circle)obj;

        if(circle == null)
            return false;

        if(!circle.point.Equals(point) ||
           circle.r != r ||
           circle.name != name)
            return false;

        return true;
    }
    
    public void InputData()
    {
        Console.WriteLine("Draw your circle");
        Console.Write("Type point X: ");

        bool resultX = int.TryParse(Console.ReadLine(), out int xPoint);
        
        Console.Write("Type point Y:");
        
        bool resultY = int.TryParse(Console.ReadLine(), out int yPoint);

        Point newPoint = new Point();
        newPoint.X = (resultX ? xPoint : 0);
        newPoint.Y = (resultY ? yPoint : 0);

        point = newPoint;
        
        Console.Write("Type name: ");

        name = Console.ReadLine() ?? "";
        
        Console.Write("Type r: ");
        
        bool resultR = int.TryParse(Console.ReadLine(), out int rPoint);

        r = resultR ? rPoint : 0;
    }

    public void PrintingResult()
    {
        Console.WriteLine(ToString() + $" obwod = {Obwod()}");
    }

    public void PointModify(int appendX, int appendY)
    {
        point.X += appendX;
        point.Y += appendY;
    }
}

