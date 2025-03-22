using System;

// Ստանում է տող և վերադարձնում հակառակը
// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a string: ");
//         string input = Console.ReadLine();

//         char[] str = input.ToCharArray();
//         Array.Reverse(str);
//         Console.WriteLine(str);
//     }
// }

// Պալինդրոմի ստուգում
// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a string: ");
//         string input = Console.ReadLine();

//         int start = 0;
//         int end  = input.Length- 1;
//         while (start < end && input[start] == input[end])
//         {
//             start++;
//             end--;
//         }
//         if (start < end)
//             Console.WriteLine("String is not palindrome");
//         else 
//             Console.WriteLine("String is palindrome");
//     }
// }

// Հաշվում է ձայնավորների քանակը
// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a string: ");
//         string input = Console.ReadLine();
//         string vowels = "aeiouAEIOU";
//         int count = 0;

//         foreach (char c in input)
//         {
//             if (vowels.IndexOf(c) != -1)
//                 count++;
//         }

//         Console.WriteLine("The number of vowels: " + count);
//     }
// }

// Հեռացնում է բացատները տողից
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string: ");
//         string input = Console.ReadLine();
//         string new_str = input.Replace(" ", "");
//         Console.WriteLine(new_str);
//     }
// }

// Փոխարինում է a -> *
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string: ");
//         string input = Console.ReadLine();
//         string new_str = input.Replace('a', '*');
//         Console.WriteLine(new_str);
//     }
// }

// Տողերի միավորում
// using System.Text;

// class Program
// {
//     static void Main()
//     {
//         StringBuilder str = new StringBuilder();

//         Console.WriteLine("Enter strings (type 'exit' to stop):");
//         while (true)
//         {
//             string input = Console.ReadLine();
//             if (input == "exit")
//                 break;

//             str.Append(input);
//             str.Append(" ");
//         }
//         Console.WriteLine(str);
//     }
// }
