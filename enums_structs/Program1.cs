using System;

enum DayOfWeek
{
    Monday = 1, 
    Tuesday, 
    Wednesday, 
    Thursday, 
    Friday, 
    Saturday, 
    Sunday
}

class Program1
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        try
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 7)
                Console.WriteLine("Day: " + (DayOfWeek)number);
            else
                throw new Exception();
        }
        catch
        {
            Console.WriteLine("Error: Invalid input.");
        }
    }
}
