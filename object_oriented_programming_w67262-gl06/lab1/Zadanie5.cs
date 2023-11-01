using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab1;

class Zadanie5
{
    List<int> excludedNumbers = new List<int> {2, 6, 9, 15, 19};

    public void Process()
    {
        for (int i = 20; i >= 0; i--)
        {
            if (excludedNumbers.Contains(i))
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
