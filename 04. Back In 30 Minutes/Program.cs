using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());//23
            int minutes = int.Parse(Console.ReadLine())+30;// 40
            if(minutes>59)
            {
                hour += 1;
                minutes -= 60;
            }
            if(hour>23)
            {
                hour=0;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
