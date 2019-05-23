using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public static class Timer
    {
        public static DateTime BirthDay { get; set; }


        public static int Yer { get; set; }
        static Timer()
        {
            Console.Write("Enter your birt day...");
            BirthDay = DateTime.Parse(Console.ReadLine());

        }
        public static void PrintAge()
        {
            TimeSpan ts = DateTime.Now - BirthDay;

            Console.WriteLine("Age BY Milisecond" + "\t" + ts.Milliseconds);

            Yer = 365;



        }
    }
    }
