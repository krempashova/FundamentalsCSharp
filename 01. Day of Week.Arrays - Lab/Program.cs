using System;

namespace _01._Day_of_Week.Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] dayOFWeek = {"Monday",
                                  "Tuesday",
                                   "Wednesday",
                                    "Thursday",
                                     "Friday",
                                     "Saturday",
                                      "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if(day<1 ||day >7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(dayOFWeek[day-1]);
            }




        }
    }
}
