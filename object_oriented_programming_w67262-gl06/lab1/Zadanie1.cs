using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab1;

class Zadanie1
{
    public void Process()
    {
        double a = DoubleInput();
        double b = DoubleInput();
        double c = DoubleInput();

        double delta, x1, x2;

        if (a == 0)
        {
            Console.WriteLine("To nie jest równanie kwadratowe");
            return;
        }

        delta = (Math.Pow(b, 2) - (4 * a * c));
        if (delta < 0)
        {
            Console.WriteLine("Brak rozwiazania");
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);

            Console.WriteLine("x1 = " + x1);
        }
        else
        {
            x1 = -b - Math.Sqrt(delta) / (2 * a);
            x2 = b - Math.Sqrt(delta) / (2 * a);
            Console.WriteLine($"x1 = {x1} \nx2 = {x2}");
        }
    }

    public double DoubleInput()
    {
        Console.WriteLine("Podaj wartosc:");
        return Convert.ToDouble(Console.ReadLine());
    }

}

