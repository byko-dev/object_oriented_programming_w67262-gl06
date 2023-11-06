using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab2
{
    internal class Licz
    {
        private int value;

        public Licz(int value)
        {
            this.value = value;
        }

        public void addToValue(int value)
        {
            this.value += value;
        }

        public void odejToValue(int value)
        {
            this.value -= value;
        }

        public void print()
        {
            Console.WriteLine($"Value = {value}");
        }
    }
}
