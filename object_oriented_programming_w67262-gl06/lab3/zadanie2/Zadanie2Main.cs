using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie2
{
    internal class Zadanie2Main
    {
        public Zadanie2Main()
        {
            Samochod car1 = new Samochod("Vw", "Golf", "SportPlus", "Czarny", 2030, 100);
            car1.Info();
            Samochod car2 = new Samochod("A3", "Audi", "SportPlus", "Szare", 2050, 0);
            car2.Info();

            SamochodOsobowy samochodOsobowy = new SamochodOsobowy("A3", "Audi", "SportPlusPlus", "Szary Metalik", 2013, 250000, 2000, 1600, 5);
            samochodOsobowy.Info();
        }
    }
}
