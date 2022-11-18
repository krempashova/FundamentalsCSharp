using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());//15
            int []lift=Console.ReadLine()             //0 0 0 0
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++) //1 wagon
            {
                if(lift[i] <4 )
                {
                    while (lift[i] < 4 && people > 0)
                    {
                        lift[i]++;
                        people--;
                    }
                }


            }
            if(people == 0 && lift.Any(X=>X<4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ",lift));
            }
            else if(people>0 && lift.All(X=>X==4))
             {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ",lift));
            }
            else if(people==0 && lift.All(X=>X==4))
            {
                Console.WriteLine(string.Join(" ",lift));
            }

        }
    }
}
