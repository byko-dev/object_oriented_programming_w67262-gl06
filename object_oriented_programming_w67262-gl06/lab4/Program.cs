using object_oriented_programming_w67262_gl06.lab4.Zadanie1;

namespace object_oriented_programming_w67262_gl06.lab4;

public class Program
{
    public static void Process(String[] args)
    {
        Zadanie1();
    }

    private static void Zadanie1()
    {
        Circle circle = new Circle(3, 3, 3, 3);
        Triangle triangle = new Triangle(4, 4, 5, 6);
        Rectangle rectangle = new Rectangle(8, 4, 2, 7);

        List<Shape> shapes = new List<Shape>
        {
            circle,
            triangle,
            rectangle
        };

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}