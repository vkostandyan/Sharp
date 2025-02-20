using System;

// // 1

// public class Hello
// {
//     public static void Main(string[] args)
//     {
//         string name;
//         int age;
//         Console.Write("Enter your name: ");
//         name = Console.ReadLine();
//         Console.Write("Enter your age: ");
//         age = 1 + int.Parse(Console.ReadLine());
//         Console.Write("Hello " + name + ", next year you will be " + age + " years old ");
//     }
// }


// // 2

// public class Numbers
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter the first number: ");
//         var first = int.Parse(Console.ReadLine());
//         Console.Write("Enter the second number: ");
//         var second = int.Parse(Console.ReadLine());
        
//         Console.WriteLine("Sum: " + (first + second));
//         Console.WriteLine("Sub: " + (first - second));
//         Console.WriteLine("Mul: " + (first * second));
//         Console.WriteLine("Div: " + ((float)first / second));
//     }
// }

// // 3

// public class EvenOdd
// {
//     public static void Main(string[] args)
//     {
//         int number;

//         Console.Write("Enter the number: ");
        
//         while (true)
//         {
//             try
//             {
//                 number = int.Parse(Console.ReadLine());
//                 if (number < 0)
//                 {
//                     Console.WriteLine("Number must be positive. Try again!");
//                     Console.Write("Enter the number: ");
//                 }
//                 else
//                     break;
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Invalid input. Please enter valid number.");
//                 Console.Write("Enter the number: ");
//             }
//         }
//         if (number % 2 == 0)
//             Console.WriteLine("The number is even");
//         else
//             Console.WriteLine("The number is odd");
//     }
// }

// // 4

// public class Hello2
// {
//     public static void Main(string[] args)
//     {
//         string name;
//         int age;
//         Console.Write("Enter your name: ");
//         name = Console.ReadLine();
//         Console.Write("Enter your age: ");
//         age = int.Parse(Console.ReadLine());
//         Console.WriteLine("Hello " + name + ", next year you will be " + (age + 1) + " years old ");
//         if (age >= 18)
//             Console.WriteLine("You are an adult");
//         else
//             Console.WriteLine("You are not an adult");
//     }
// }

// // 5

// public class PrintData
// {
//     public static void Main(string[] args)
//     {
//         string[] names = {"Davit", "Tigran", "Gevorg", "Karen", "Alex"};
//         int[] ages = {19, 20, 22, 12, 13};
//         int i = 0;
        
//         Console.Write("Would you like to print data (yes or no) ? ");
//         string input = Console.ReadLine();
        
//         if (input == "yes")
//         {
//             while(i < 5)
//             {
//                 Console.WriteLine(names[i] + " " + ages[i] + " years old, " + (ages[i] >= 18 ? "adult " : "not adult"));
//                 i++;
//             }
//         }
//         else if (input == "no")
//             Console.WriteLine("No data will be shown");
//         else
//             Main(args);
//     }
// }

// // Rectangle

// public class Rectangle
// {
//     public static void Main(string[] args)
//     {
//             Console.Write("Enter the height of rectangle: ");
//             int height = int.Parse(Console.ReadLine());
//             Console.Write("Enter the width of rectangle: ");
//             int width = int.Parse(Console.ReadLine());
//             Console.Write("Enter the y coordinate: ");
//             int y = int.Parse(Console.ReadLine());
//             Console.Write("Enter the x coordinate: ");
//             int x = int.Parse(Console.ReadLine());

//             for (int i = 0; i < height; i++)
//             {
//                 Console.SetCursorPosition(x, y + i);

//                 for (int j = 0; j < width; j++)
//                 {
//                     if (i == 0  j == 0 || j == width - 1)
//                     {
//                         Console.ForegroundColor = (ConsoleColor)(j % 16);
//                         Console.Write("*");
//                     }
//                     else
//                         Console.Write(" ");
//                 }
//                 Console.WriteLine();
//             }
//     }
// }