using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab2
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            //Zadanie 1 
            Licz licz = new Licz(10);
            licz.addToValue(1321);
            licz.odejToValue(523);
            licz.print();


            //Zadanie 2 
            int[] numbers =
            {
                10, 20, 4434, 43253, 431, 1, 342, 321, 34232, 3221
            };

            Sumator sumator = new Sumator(numbers);
            int suma = sumator.Suma();
            int sumaPodziel2 = sumator.SumaPodziel2();
            int ile = sumator.IleElementów();
            sumator.printAll();
            sumator.getFrag(2, 6);
            Console.WriteLine($"Suma {suma}, Suma podziel przez 2: {sumaPodziel2}, ile: {ile}");

            //Zadnaie 3
            DateProcessing dateProcessing = new DateProcessing();
            dateProcessing.next(10);
            dateProcessing.getDate();
            dateProcessing.back(30);
            dateProcessing.getDate();

            //Zadanie 4 
            string number = "343198";
            int[] numberArray = { 1, 1, 1, 1, 1, 1, 1 };

            Liczba liczba = new Liczba(number);
            liczba.multiplyByNumbes(numberArray);
            liczba.printNumber();
            liczba.Silnia(10);
        }

    }
}
