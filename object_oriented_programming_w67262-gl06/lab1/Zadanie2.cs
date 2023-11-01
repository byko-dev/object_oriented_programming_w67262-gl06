using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab1;

class Zadanie2
{
    public void Process()
    {
        while (true)
        {
            printMenu();
            RunOperation();
        }
    }

    private void printMenu()
    {
        Console.WriteLine("==> Kalkulator Menu <==");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Roznica");
        Console.WriteLine("3. Iloczyn");
        Console.WriteLine("4. Iloraz");
        Console.WriteLine("5. Potegowanie");
        Console.WriteLine("6. Pierwiastek");
        Console.WriteLine("7. Funkcja trygonometryczna zadanego kata");
        Console.WriteLine("8. Exit");
        Console.WriteLine("=======================");
    }

    private void RunOperation()
    {
        Console.Write("Podaj opcje: ");
        int operationCode = Convert.ToInt32(Console.ReadLine());

        switch (operationCode)
        {
            case 1: Suma(); break;
            case 2: Roznica(); break;
            case 3: Iloczyn(); break;
            case 4: Iloraz(); break;
            case 5: Potegowanie(); break;
            case 6: Pierwiastek(); break;
            case 7: Trygo(); break;
            case 8: Close(); break;
        }
    }

    protected void Suma()
    {
        double a = GetInput();
        double b = GetInput();

        Console.WriteLine($"Suma = {a + b}");
    }

    protected void Roznica()
    {
        double a = GetInput();
        double b = GetInput();

        Console.WriteLine($"Roznica = {a - b}");
    }

    protected void Iloczyn()
    {
        double a = GetInput();
        double b = GetInput();

        Console.WriteLine($"Iloczyn = {a * b}");
    }

    protected void Iloraz()
    {
        double a = GetInput();
        double b = GetInput();

        if (b == 0)
        {
            Console.WriteLine("Nie można dzielić przez 0");
            return;
        }

        Console.WriteLine($"Iloraz = {a / b}");
    }

    protected void Potegowanie()
    {
        double a = GetInput();
        double b = GetInput();

        Console.WriteLine($"Potega = {Math.Pow(a, b)}");
    }

    protected void Pierwiastek()
    {
        double a = GetInput();

        Console.WriteLine($"Pierwiastek = {Math.Sqrt(a)}");
    }

    protected void Trygo()
    {
        double a = GetInput();

        Console.WriteLine($"Sin = {Math.Sin(a)}");
        Console.WriteLine($"Cos = {Math.Cos(a)}");
        Console.WriteLine($"Tg = {Math.Tan(a)}");
        Console.WriteLine($"Ctg = {1/Math.Tan(a)}");
    }

    protected void Close()
    {
        System.Environment.Exit(0);
    }

    public double GetInput()
    {
        Console.Write("Podaj liczbe: ");
        return Convert.ToDouble(Console.ReadLine());
    }

}

