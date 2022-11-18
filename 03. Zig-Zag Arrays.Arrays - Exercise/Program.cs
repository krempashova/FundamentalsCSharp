using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays.Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//0 1 2 3=index
            int[] arr1 = new int[n];             // 1 2 3 4=num
            int[] arr2 = new int[n];
            for (int i = 1; i <=arr1.Length; i++)
            {
                int[] current = Console.ReadLine()
                                  .Split(" ")
                                  .Select(int.Parse)
                                  .ToArray();
                int firstNum=current[0];
                int secondNum = current[1];
                
                    if (i % 2 != 0)
                    {

                        arr1[i-1] = firstNum;
                        arr2[i - 1] = secondNum;
                    }
                    else

                    {
                    arr1[i - 1] = secondNum;
                    arr2[i - 1] = firstNum;
                    }
                
            }


            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ",arr2));
        }
    }
}
