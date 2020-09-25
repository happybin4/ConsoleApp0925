using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            DateTime to = DateTime.Now;
            DateTime bir = new DateTime(1997, 1, 27);
            TimeSpan interval = to - bir;           
            Console.WriteLine(interval.Days); // 흐에..

            string str = DateTime.Now.AddDays(3).ToShortDateString(); //뒤에다가 형변환을 준당 흐엥
            string str1 = DateTime.Now.AddDays(-3).ToString("MM.dd"); //뒤에다가 형변환을 준당 흐엥
            DateTime jd = new DateTime(2016, 2, 17);
            string str2 = jd.AddDays(2000).ToShortDateString();
            Console.WriteLine((new DateTime(2019,4,16).AddDays(600).AddDays(-7).ToShortDateString()));
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            DateTime dDay = new DateTime(2020, 9, 26, 13, 0, 0);
            double rHour = (dDay - DateTime.Now).TotalHours;
            Console.WriteLine(rHour);
        }
    }
}
