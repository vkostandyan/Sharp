using System;

// Էլեմենտների գումար

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
//             matrix[index] = int.Parse(Console.ReadLine());
//             sum += matrix[index++];
//         }
//         Console.WriteLine("The sum of the numbers is " + sum);
//     }
// }

// Մատրիցի անկյունագծի գումար

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
//                 if (i == j)
//                     sum += array[i, j];
//             }
//         }
//         Console.WriteLine("Sum: " + sum);
//     }
// }

// Արժեքների ֆիլտրում

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

// Փոխակերպել փոքրատառը մեծատառի

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a string: ");
//         string input = Console.ReadLine();
//         string new_str = input.ToUpper();

//         Console.WriteLine(new_str);
//     }
// }

// Անունների ցանկ ըստ երկարության

// class Program
// {
//     static void Main()
//     {
//         string[,] names = new string[2, 3]
//         {
//             { "Eva", "Ann", "Tom" },
//             { "Alice", "Frank", "David" },
//         };

//         for (int i = 0; i < 2; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 Console.Write(names[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// Աստիճանաձև char զանգված

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter words");
//         string input = Console.ReadLine();
        
//         string[] words = input.Split(' ');
//         char[][] charArray = new char[words.Length][];
//         for (int i = 0; i < words.Length; i++)
//         {
//             charArray[i] = new char[words[i].Length];
//             for (int j = 0; j < words[i].Length; j++)
//                 charArray[i][j] = words[i][j];
//         }
//         for (int i = 0; i < charArray.Length; i++)
//         {
//             for (int j = 0; j < charArray[i].Length; j++)
//                 Console.Write(charArray[i][j] + " ");
//             Console.WriteLine();
//         }
//     }
// }


// Console.Color Աստիճանաձև զանգված

// class Program
// {
//     static void Main()
//     {
//         ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

//         string[] colorNames = Enum.GetNames(typeof(ConsoleColor));

//         Random rnd = new Random();

//         for (int i = 0; i < 3; i++)
//         {
//             int rows = i + 1;
//             ConsoleColor[] selectedColors = new ConsoleColor[rows];

//             for (int j = 0; j < rows; j++)
//                 selectedColors[j] = colors[rnd.Next(colors.Length)];
//             foreach (var color in selectedColors)
//             {
//                 Console.ForegroundColor = color;
//                 Console.Write(colorNames[(int)color] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.ResetColor();
//     }
// }


// Ստուգարքային արդյունքներ պահպանում

// class Program
// {
//     static void Main()
//     {
//         string[][] student = new string[][]{
//             new string[]{"Anna", "Math", "10"},
//             new string[]{"Hayk", "Programming", "9"},
//             new string[]{"Karen", "English", "10"}
//         };
        
//         DateTime[][] date = new DateTime[][]{
//             new DateTime[]{new DateTime(2025, 04, 01)},
//             new DateTime[]{new DateTime(2025, 03, 01)},
//             new DateTime[]{new DateTime(2025, 02, 01)}
//         };

//         for (int i = 0; i < student.Length; i++)
//         {
//             Console.WriteLine($"Name: {student[i][0]}\nSubject: {student[i][1]}, Mark: {student[i][2]}, Date: {date[i][0]:yyyy-MM-dd}");
//             Console.WriteLine();
//         }
//     }
// }

// Խառը տառերի ստեղծում

// class Program
// {
//     static void Main()
//     {
//         string[] words = { "hello", "world", "example" };

//         Random rnd = new Random();
//         char[][] chars = new char[words.Length][];

//         for (int i = 0; i < words.Length; i++)
//         {
//             chars[i] = words[i].ToCharArray();
//             for (int j = chars[i].Length - 1; j > 0; j--)
//             {
//                 int k = rnd.Next(0, j + 1);
//                 char temp = chars[i][j];
//                 chars[i][j] = chars[i][k];
//                 chars[i][k] = temp;
//             }
//         }

//         for (int i = 0; i < words.Length; i++)
//         {
//             string new_word = new string(chars[i]);
//             Console.WriteLine($"{words[i]} -> {new_word}");
//         }
//     }
// }
