using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie2
{
    internal class SamochodOsobowy : Samochod
    {
        private int waga, pojemnoscSilnika, miejsca;

        public SamochodOsobowy(string marka, string model, string typNadwozia, string color, int rokProd, int przebieg, int waga, int pojemnoscSilnika, int miejsca)
                                : base(marka, model, typNadwozia, color, rokProd, przebieg)
        {
            this.waga = waga;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.miejsca = miejsca;
        }

        public void Info()
        {
            Console.WriteLine($"Car = [{Marka} - {Model} - {TypNadwozia} - {Color} - {RokProd} - {Przebieg} - {waga} - {pojemnoscSilnika} - {miejsca}]");
        }
    }
}
