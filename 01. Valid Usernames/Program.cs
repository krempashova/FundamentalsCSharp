using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] usernames = Console.ReadLine()//sh, too_long_username, !lleg@l ch@rs, jeffbutt
                 .Split(", ");

            foreach (var currName in usernames)
            {
                if (currName.Length > 3 && currName.Length <= 16)
                {
                    bool isValid = true;
                    foreach (char curChar in currName)
                    {
                        if (!(char.IsLetterOrDigit(curChar) || curChar == '-' || curChar == '_'))
                        {

                            isValid = false;
                            break;
                        }

                    }

                    if (isValid)
                    {
                        Console.WriteLine(currName);

                    }
                        

                }
               
            }
        }
    }
}
