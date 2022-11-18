using System;

namespace _1._Ages_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            //· 0-2 – baby

            //3 - 13 – child

            //14 - 19 – teenager

            // 20 - 65 – adult

            // >= 66 – elder

            // All the values are inclusive

            if (age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if(age>2 && age<=13)
            {
                Console.WriteLine("child");
            }
            else if(age>=14 && age<=19)
            {
                Console.WriteLine("teenager");
            }
            else if(age>=20 && age<=65)
            {
                Console.WriteLine("adult");
            }
            else if(age>=66)
            {
                Console.WriteLine("elder");
            }
            
        }
    }
}
