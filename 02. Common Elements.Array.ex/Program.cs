using System;
using System.Linq;

namespace _02._Common_Elements.Array.ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string common = string.Empty;
            int commonCount = 0;
            string[] array1 = Console.ReadLine()
                .Split(" ");
            string[] array2 = Console.ReadLine()
                .Split(" ");
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if(array2[i]==array1[j])
                    {
                        common += array2[i] + " ";
                        commonCount++;
                        

                    }
                }
            }
            string []commonarr=common.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ",commonarr));
          

        }
    }
}
