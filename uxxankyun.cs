using System;

public class Rectangle
{
    public static void Main(string[] args)
    {
            Console.Write("Enter the height of rectangle: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of rectangle: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter the y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter the x coordinate: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);

                for (int j = 0; j < width; j++)
                {
                    if (i == 0  i == height - 1  j == 0 || j == width - 1)
                    {
                        Console.ForegroundColor = (ConsoleColor)(j % 16);
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
    }
}) 
