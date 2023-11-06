using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab2
{
    internal class Liczba
    {
        List<int> numbers = new List<int>();


        public Liczba(string number)
        {
            foreach (char num in number)
            {
                numbers.Add(FormatNumberFromStr(num.ToString()));
            }
        }

        public void multiplyByNumbes(int[] numbers2)
        {
            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers.Count < i+1)
                {
                    numbers.Add(1);
                }

                numbers[i] *= numbers2[i];
            }
        }

        public void printNumber()
        {
            int number = FormatToSingleNumber();
            Console.WriteLine($"Number = {number}");

        }

        public void Silnia(int param)
        {
            int result = 1;
            for (int i = param; i >= 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }

        //getto flex solution
        private int FormatToSingleNumber()
        {
            string numberStr = "";

            foreach (int number in numbers)
            {
                numberStr += number.ToString();
            }

            return FormatNumberFromStr(numberStr);
        }

        private int FormatNumberFromStr(string number)
        {
            Console.WriteLine(number);
            return Convert.ToInt32(number);
        }

    }
}
