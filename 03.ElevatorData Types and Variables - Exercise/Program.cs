using System;

namespace _03.ElevatorData_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int elevatorCourses = (int)Math.Ceiling((double)NumPeople / elevatorCapacity);
            Console.WriteLine(elevatorCourses);

        }
    }
}
