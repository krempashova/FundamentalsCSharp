using System;
using System. Linq;
    

namespace _04._Reverse_Array_of_Strings.Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string []items = Console.ReadLine().Split(' ').ToArray();
           
            string []reverseditems=new string[items.Length];
                
            for (int i = 0; i < items.Length; i++)
            {
                reverseditems[items.Length - 1 - i]=items[i];   

            }
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(reverseditems[i]+ " ");
            }


            
            
        }
    }
}
