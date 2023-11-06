using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab2
{
    internal class Sumator
    {
        private int[] numbers { set; get; }

        public Sumator(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int Suma()
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int SumaPodziel2()
        {
            return Suma() / 2;
        }

        public int IleElementów()
        {
            return numbers.Length;
        }


        public void printAll()
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public void getFrag(int firstIndex, int lastIndex)
        {
            Console.WriteLine("getFragResult => ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (firstIndex <= i && lastIndex >= i)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
