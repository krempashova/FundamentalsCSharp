using System;

namespace _02._Division_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int integer=int.Parse(Console.ReadLine());//20
        

            //y 2 or 3, or 6, or 7, or 10 bez ostatak
            if(integer%10==0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if(integer%7==0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if(integer%6==0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (integer % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if(integer %2==0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }




        }
    }
}
