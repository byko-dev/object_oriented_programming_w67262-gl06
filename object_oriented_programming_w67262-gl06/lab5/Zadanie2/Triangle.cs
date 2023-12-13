namespace object_oriented_programming_w67262_gl06.lab5.Zadanie2;

public class Triangle : ICloneable
{
    public Point point1;
    public Point point2;
    public Point point3;
    public string name;

    public Triangle() { }

    public Triangle(Point point1, Point point2, Point point3, string name)
    {
        this.point1 = point1;
        this.point2 = point2;
        this.point3 = point3;
        this.name = name;
    }

    public object Clone()
    {
        return new Triangle(point1, point2, point3, name);
    }

    public override string ToString()
    {
        return $"Triangle = {name}, point1 = {point1.ToString}, point2 = {point2.ToString}, point3 = {point3.ToString}";
    }

    public override bool Equals(object? obj)
    {
        if(obj == null || obj is not Triangle)
            return false;

        Triangle triangle = (Triangle)obj;

        if(triangle == null) 
            return false;

        if(!triangle.point1.Equals(point1) || 
           !triangle.point2.Equals(point2) || 
           !triangle.point3.Equals(point3) || 
           triangle.name != name)
            return false;

        return true;
    }

    public float Obwod()
    {
        return Point.LenghtValue(point1, point2) + 
               Point.LenghtValue(point2, point3) +
               Point.LenghtValue(point3, point1);
    }

    public static bool operator <(Triangle a, Triangle b)
    {
        return a.Obwod() < b.Obwod();
    }

    public static bool operator >(Triangle a, Triangle b)
    {
        return a.Obwod() > b.Obwod();
    }

    public void PointModify(int appendX, int appendY)
    {
        point1.X += appendX;
        point2.X += appendX;
        point3.X += appendX;
        
        point1.Y += appendY;
        point2.Y += appendY;
        point3.Y += appendY;
    }
    
}    

