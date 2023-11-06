using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab2
{
    internal class DateProcessing
    {
        private DateTime baseDate { get; set; }

        public DateProcessing()
        {
            baseDate = DateTime.Now;
        }


        public void getDate()
        {
            Console.WriteLine(baseDate);
        }

        public void back(int days)
        {
            baseDate = baseDate.AddDays(-days);
        }

        public void next(int days)
        {
            baseDate = baseDate.AddDays(days);
        }
    }
}
