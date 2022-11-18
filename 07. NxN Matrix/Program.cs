using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            NxNMatrix(N);


        }
        static void NxNMatrix(int N)
        {
            for (int i =0 ; i<N; i++)//ROWS
            {
                for (int j = 0; j <N; j++)
                {
                    Console.Write(N + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
