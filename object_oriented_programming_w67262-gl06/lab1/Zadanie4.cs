using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab1;

class Zadanie4
{

    private List<double> numbers = new List<double>();

    public void Process()
    {
        setNumbersList();

        SumAll();

        MultiplyAll();

        Average();

        MinValue();

        MaxValue();
    }

    private void setNumbersList()
    {

        for (int i = 1; i < 11; ++i)
        {
            Console.WriteLine($"Podaj liczbę {i} z 10: ");

            appendNumber();
        }
    }


    private void appendNumber()
    {
        numbers.Add(Convert.ToDouble(Console.ReadLine()));
    }


    private void SumAll()
    {
        double sumResult = 0;

        numbers.ForEach(value =>
        {
            sumResult += value;
        });

        Console.WriteLine($"Sum = {sumResult}");
    }

    private void MultiplyAll()
    {
        double multiResult = 1;

        numbers.ForEach(value =>
        {
            multiResult *= value;
        });

        Console.WriteLine($"Multiply = {multiResult}");
    }

    private void Average()
    {
        double sumResult = 0;

        numbers.ForEach(value =>
        {
            sumResult += value;
        });

        Console.WriteLine($"Average = {sumResult/numbers.Count()}");
    }

    private void MinValue()
    {
        Console.WriteLine($"Min Value = {numbers.Min()}");
    }

    private void MaxValue()
    {
        Console.WriteLine($"Max Value = {numbers.Max()}");
    }
}
