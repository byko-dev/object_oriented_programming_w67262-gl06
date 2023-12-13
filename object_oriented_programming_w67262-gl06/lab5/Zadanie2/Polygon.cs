namespace object_oriented_programming_w67262_gl06.lab5.Zadanie2;

public class Polygon : ICloneable
{
    public List<Point> points;
    public string name;

    public Polygon() { }

    public Polygon(List<Point> points, string name)
    {
        this.points = points;
        this.name = name;
    }

    public object Clone()
    {
        return new Polygon(points, name);
    }

    public float Obwod()
    {
        if (points.Count() == 3 || points.Count() < 2)
            return 0f;
        
        float result = 0;

        for (int i = 0; i < points.Count - 1; i++)
        {
            result += Point.LenghtValue(points[i], points[i+1]);
        }
        
        return result; 
    }

    public override string ToString()
    {
        string pointsStr = "";

        foreach (Point p in points)
        {
            pointsStr += p.ToString();
        }

        return $"Polygon = {name}, points = {pointsStr}";
    }


    public static bool operator <(Polygon a, Polygon b)
    {
        return a.Obwod() < b.Obwod();
    }

    public static bool operator >(Polygon a, Polygon b)
    {
        return a.Obwod() > b.Obwod();
    }
    
    public override bool Equals(object? obj)
    {
        if(obj == null || obj is not Polygon)
            return false;

        Polygon polygon = (Polygon)obj;

        if(polygon == null || polygon.name != name) 
            return false;

        foreach (Point point in points)
        {
            foreach (var polygonPoint in polygon.points)
            {
                if (!polygonPoint.Equals(point))
                    return false;
            }
        }
        
        return true;
    }

    public void AddPoint(Point point)
    {
        points.Add(point);
    }
    
    public void PointModify(int appendX, int appendY)
    {
        foreach (Point point in points)
        {
            point.X += appendX;
            point.Y += appendY;
        }
    }
    
}

