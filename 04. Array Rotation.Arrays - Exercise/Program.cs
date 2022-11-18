using System;
using System.Linq;


namespace _04._Array_Rotation.Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine() //51 47 32 61 21
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            
            int numrotation = int.Parse(Console.ReadLine());//2
            int TimesToRotate = numrotation % arr.Length;
            int[] rotation = new int[arr.Length];
            for (int r = 1; r <=TimesToRotate; r++)
            {
                int firstElement=arr[0];
                for (int i = 1; i <arr.Length; i++)
                {
                    arr[i-1]=arr[i];
                }
                arr[arr.Length-1]=firstElement;

            }

            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
