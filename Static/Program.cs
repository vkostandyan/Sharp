using System;

// 1 Ստեղծել SumCalculator ստատիկ դաս, որը պետք է հաշվի երկու թվի գումարը 
// և պահպանի կատարած հաշվարկների քանակը

// public static class SumCalculator
// {
//     public static int count = 0;
//     public static int sum = 0;

//     public static int Add(int a, int b)
//     {
//         count++;
//         sum += (a + b);
//         return a + b;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(SumCalculator.Add(5, 3)); // 8
//         Console.WriteLine(SumCalculator.Add(10, 20)); // 30
//         Console.WriteLine("Total Calculations: " + SumCalculator.count); // 2
//         Console.WriteLine("Sum: " + SumCalculator.sum); // 38
//     }
// }





// 2 Օգտատերերի հաշվիչ
// class User
// {
//     private static int userCount;

//     static User()
//     {
//         Console.WriteLine("Static constructor called.");
//         userCount = 0;
//     }
//     public User()
//     {
//         userCount++;
//         Console.WriteLine("User created.");
//     }
//     public static int GetUserCount()
//     {
//         return userCount;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         User user1 = new User();
//         User user2 = new User();
//         Console.WriteLine($"Total Users: {User.GetUserCount()}");
//     }
// }





// 3 ID գեներատոր

// class IdGenerator
// {
//     private static int id;
//     static IdGenerator()
//     {
//         Console.WriteLine("Static constructor called.");
//         id = 1; 
//     }
//     public static int Getid()
//     {
//         return id++;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine($"Generated ID: {IdGenerator.Getid()}");
//         Console.WriteLine($"Generated ID: {IdGenerator.Getid()}");
//         Console.WriteLine($"Generated ID: {IdGenerator.Getid()}");
//     }
// }




// 4 Փոխարժեք

// class CurrencyConverter
// {
//     private static double exchangeRate = 1.10;

//     public static double ConvertEuroToDollar(double euros)
//     {
//         return euros * exchangeRate;
//     }
//     public static double ConvertDollarToEuro(double dollars)
//     {
//         return dollars / exchangeRate;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         double euros = 50;
//         double dollars = 100;

//         Console.WriteLine($"{euros} EUR = {CurrencyConverter.ConvertEuroToDollar(euros)} USD");
//         Console.WriteLine($"{dollars} USD = {CurrencyConverter.ConvertDollarToEuro(dollars)} EUR");
//     }
// }





// 5 Անվտանգ գաղտնաբառի գեներատոր

// class PasswordGenerator
// {
//     private static readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";

//     public static string Generate(int length)
//     {
//         Random random = new Random();
//         char[] password = new char[length];

//         for (int i = 0; i < length; i++)
//             password[i] = chars[random.Next(chars.Length)];
//         return new string(password); 
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine($"New Password: {PasswordGenerator.Generate(9)}");
//         Console.WriteLine($"New Password: {PasswordGenerator.Generate(13)}");
//     }
// }




// 6 Մաթեմատիկական ֆունկցիաներ

// class MathUtils
// {    public static long Factorial(int n)
//     {
//         long result = 1;
//         for (int i = 1; i <= n; i++)
//             result *= i;
//         return result;
//     }

//     public static double Power(double baseNum, int exponent)
//     {
//         double result = 1;
//         for (int i = 0; i < exponent; i++)
//             result *= baseNum;
//         return result;
//     }

//     public static int GCD(int a, int b)
//     {
//         while (b != 0)
//         {
//             int temp = b;
//             b = a % b;
//             a = temp;
//         }
//         return a;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine($"Factorial of 5: {MathUtils.Factorial(5)}");
//         Console.WriteLine($"2^5: {MathUtils.Power(2, 5)}");
//         Console.WriteLine($"GCD of 48 and 18: {MathUtils.GCD(48, 18)}");
//     }
// }





// 7 վիճակագրական հաշվարկներ
.333
// class Statistics
// {
//     public static double FindAverage(int[] numbers)
//     {
//         double sum = 0;
//         foreach (int num in numbers)
//             sum += num;
//         return sum / numbers.Length;
//     }

//     public static int FindMin(int[] numbers)
//     {
//         int min = numbers[0];
//         foreach (int num in numbers)
//         {
//             if (num < min)
//                 min = num;
//         }
//         return min;
//     }

//     public static int FindMax(int[] numbers)
//     {
//         int max = numbers[0];
//         foreach (int num in numbers)
//         {
//             if (num > max)
//                 max = num;
//         }
//         return max;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 1, 2, 3, 4, 5 };

//         Console.WriteLine($"Average: {Statistics.FindAverage(numbers)}");
//         Console.WriteLine($"Min: {Statistics.FindMin(numbers)}");
//         Console.WriteLine($"Max: {Statistics.FindMax(numbers)}");
//     }
// }
