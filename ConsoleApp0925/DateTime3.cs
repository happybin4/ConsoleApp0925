using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
    class DateTime3
    {
        static void Main()
        {
            DateTime fd = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime ld = fd.AddMonths(1).AddDays(-1);
            Console.WriteLine(fd.ToShortDateString() + " ~ " + ld.ToShortDateString()); // 월간

            fd = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            ld = fd.AddDays(6);
            Console.WriteLine(fd.ToShortDateString() + " ~ " + ld.ToShortDateString());
            
        }
    }
}
