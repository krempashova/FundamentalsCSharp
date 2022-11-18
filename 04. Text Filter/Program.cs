using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] bannedwords = Console.ReadLine() //Linux,Windows
                .Split(", ",StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();//It is not Linux,
                                             //it is GNU/Linux.
                                             //Linux is merely the kernel,
                                             //while GNU adds the functionality.
                                             //Therefore we owe it to them by calling the OS
                                             //GNU/Linux! Sincerely, a Windows client
            foreach (var currentword in bannedwords)
            {
               
                


                text = text.Replace(currentword, new string ('*',currentword.Length));


            }

            Console.WriteLine(text);
        }
    }
}
