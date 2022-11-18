using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programming is cool!
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (char currchar in text)
            {
                int position = currchar;
                position += 3;

                sb.Append((char)position);
                
            }

            Console.WriteLine(sb);

        }
    }
}
