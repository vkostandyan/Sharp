using System;


// 2․1 
// class Program
// {
//     static void Main()
//     {
//         ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

//         Console.WriteLine("Enter the number of colors:");
//         int size = int.Parse(Console.ReadLine());

//         string[,] colorNamesArray = new string[size, colors.Length];
//         Random rnd = new Random();

//         for (int i = 0; i < size; i++)
//         {
//             for (int j = 0; j < colors.Length; j++)
//             {
//                 int randomIndex = rnd.Next(colors.Length);
//                 colorNamesArray[i, j] = Enum.GetName(typeof(ConsoleColor), colors[randomIndex]);
//             }
//         }
//         for (int i = 0; i < size; i++)
//         {
//             for (int j = 0; j < colors.Length; j++)
//             {
//                 Console.ForegroundColor = colors[rnd.Next(colors.Length)];
//                 Console.Write(colorNamesArray[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.ResetColor();
//     }
// }

// 2․2
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the number of rows");
//         int rows = int.Parse(Console.ReadLine());

//         string[][] array = new string[rows][];

//         for (int i = 0; i < rows; i++)
//         {
//             Console.WriteLine($"Enter the number of elements for row {i + 1}:");
//             int elements = int.Parse(Console.ReadLine());
//             array[i] = new string[elements];
//             for (int j = 0; j < elements; j++)
//             {
//                 Console.WriteLine($"Enter element {j + 1} for row {i + 1}:");
//                 array[i][j] = Console.ReadLine();
//             }
//         }
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < array[i].Length; j++)
//                 Console.Write(array[i][j] + " ");
//             Console.WriteLine();
//         }
//     }
// }

// 2.3
// class Program
// {
//     static void Main()
//     {
//        Console.WriteLine("Enter the number of rows for the jagged array:");
//         int rows = int.Parse(Console.ReadLine());
//         char[][] array = new char[rows][];

//         Random rnd = new Random();

//         for (int i = 0; i < rows; i++)
//         {
//             Console.WriteLine($"Enter the number of elements for row {i + 1}:");
//             int elements = int.Parse(Console.ReadLine());

//             array[i] = new char[elements];
//             for (int j = 0; j < elements; j++)
//                 array[i][j] = (char)rnd.Next('A', 'Z' + 1); 
//         }
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < array[i].Length; j++)
//                 Console.Write(array[i][j] + " ");
//             Console.WriteLine();
//         }

//         for (int i = 0; i < rows; i++)
//         {
//             int[] letterCount = new int[26];

//             for (int j = 0; j < array[i].Length; j++)
//             {
//                 char letter = array[i][j];
//                 letterCount[letter - 'A']++;
//             }

//             Console.WriteLine($"Row {i + 1} letters");
//             for (int k = 0; k < letterCount.Length; k++)
//             {
//                 if (letterCount[k] > 0)
//                     Console.WriteLine($"{(char)(k + 'A')}: {letterCount[k]}");
//             }
//             Console.WriteLine();
//         }
//     }
// }
