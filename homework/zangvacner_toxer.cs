using System;

// Zangvacner

// 1

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         int index = 0;
//         int sum = 0;
//         int n;
        
//         Console.Write("Enter the amount of numbers: ");
//         n = int.Parse(Console.ReadLine());
        
//         int[] matrix = new int[n];
//         while(index < n)
//         {
//             Console.Write($"Enter number {index + 1}: ");
//             matrix[index++] = int.Parse(Console.ReadLine());
//         }
        
//         Console.Write("You entered the following numbers:");
//         foreach (var number in matrix)
//         {
//             Console.Write(number + " ");
//             sum += number;
//         }
//         Console.WriteLine("\nThe sum of the numbers is " + sum);
        
//     }
// }



// 2

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         int index = 0;
//         int sum = 0;
//         int n;

//         Console.Write("Enter the size of the matrix (n): ");
//         n = int.Parse(Console.ReadLine());
        
//         int[,] array = new int[n, n];
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write($"Enter element ({i + 1}, {j + 1}): ");
//                 array[i, j] = int.Parse(Console.ReadLine());
//             }
//         }
//         Console.WriteLine("\nThe entered matrix is:");
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//                 if (i == j)
//                 {
//                     sum += array[i, j];
//                 }
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine("\nThe sum is: " + sum);
//     }
// }


// 3

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         int sum = 0;
//         int n;

//         Console.Write("Enter the amount of numbers: ");
//         n = int.Parse(Console.ReadLine());

//         int[] numbers = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Enter number {i + 1}: ");
//             numbers[i] = int.Parse(Console.ReadLine());
//         }
//         int even = 0;
//         foreach (var number in numbers)
//         {
//             if (number % 2 == 0)
//                 even++;
//         }
        
//         int[] new_numbers = new int[even];
//         int index = 0;
        
//         foreach (var number in numbers)
//         {
//             if (number % 2 == 0)
//                 new_numbers[index++] = number;
//         }
//         Console.Write("Even numbers: ");
//         foreach (var number in new_numbers)
//             Console.Write(number + " ");

//     }
// }


// 4

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine();
//         string new_str = input.ToUpper();

//         Console.WriteLine("The string in uppercase is: " + new_str);
//     }
// }

// 5

// Toxer

// 1

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine();

//         char[] charArray = input.ToCharArray();
//         Array.Reverse(charArray);

//         Console.Write("The reversed string is: ");
//         Console.WriteLine(charArray);
//     }
// }

2 public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();


        int start = 0;
        int end = cleanedInput.Length - 1;

        while (start < end)
        {
            if (cleanedInput[start] != cleanedInput[end])
            {
                isPalindrome = false;
                break;
            }
            start++;
            end--;
        }

        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}