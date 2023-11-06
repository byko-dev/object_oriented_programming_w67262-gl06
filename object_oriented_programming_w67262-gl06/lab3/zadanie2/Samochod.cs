using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie2
{
    internal class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string TypNadwozia { get; set; }
        public string Color { get; set; }
        public int RokProd { get; set; }
        public int Przebieg { get; set; }

        public Samochod(string marka, string model, string typNadwozia, string color, int rokProd, int przebieg)
        {
            Marka = marka;
            Model = model;
            TypNadwozia = typNadwozia;
            Color = color;
            RokProd = rokProd;
            Przebieg = przebieg;
        }


        public void Info()
        {
            Console.WriteLine($"Car = [{Marka} - {Model} - {TypNadwozia} - {Color} - {RokProd} - {Przebieg}]");
        }
    }
}
