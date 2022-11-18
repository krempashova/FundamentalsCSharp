using System;

namespace P5Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName=Console.ReadLine();//asus
            string password = string.Empty;
            int totalTries = 0;

            for (int i =userName.Length  - 1; i >= 0; i--)
            {
                char CurrenCh=userName[i];
                password += CurrenCh;
            }
            string EneteredPass;
            while(((EneteredPass=Console.ReadLine())!=password))
            {
                totalTries++;
               
             if(totalTries<4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
                else if (totalTries >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
            }

            Console.WriteLine($"User {userName} logged in.");
            return;
            

        }
    }
}
