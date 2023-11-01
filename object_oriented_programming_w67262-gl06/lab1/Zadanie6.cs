using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab1;

class Zadanie6
{
    public void Process()
    {
        while(true)
        {
            if(getInteger() < 0)
            {
                break;
            }
        }
    }

    private int getInteger()
    {
        Console.WriteLine("Type integer: ");
        return Convert.ToInt32(Console.ReadLine());
    }

}
