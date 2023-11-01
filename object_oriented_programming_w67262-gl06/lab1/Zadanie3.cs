using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab1;

class Zadanie3
{
    private List<int> numbers = new List<int>();

    public void Process()
    {
        setNumbersList();

        Print();

        PrintReverse();

        PrintEvenNumbers();

        PrintOddNumbers();
    }

    private void setNumbersList()
    {

        for(int i = 1; i < 11; ++i)
        {
            Console.WriteLine($"Podaj liczbę {i} z 10: ");

            appendNumber();
        }
    }


    private void appendNumber()
    {
        numbers.Add(Convert.ToInt32(Console.ReadLine()));
    }

    private void Print()
    {
        Console.WriteLine("1) Print");

        for (int i = 0; i < numbers.Count(); i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    private void PrintReverse()
    {
        Console.WriteLine("2) Print Reversed");

        for ( int i = numbers.Count() - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    private void PrintEvenNumbers()
    {
        Console.WriteLine("3) Print Even Numbers");

        for (int i = 0; i < numbers.Count(); i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(numbers[i]);
        }
    }

    private void PrintOddNumbers()
    {
        Console.WriteLine("4) Print Odd Numbers");

        for (int i = 0; i < numbers.Count(); i++)
        {
            if(i % 2 != 0)
                Console.WriteLine(numbers[i]);
        }
    }


}

