﻿using System;

namespace _01MoreTasksForArraysfromInternet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i] + " ");
            }

          


        }
    }
}
