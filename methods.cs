//Երկու թվի ամենամեծ ընդհանուր բաժանարարը

using System;

// class Program
// {
//     static void FindGCD(int a, int b, out int gcd)
//     {
//         while (b != 0)
//         {
//             int temp = b;
//             b = a % b;
//             a = temp;
//         }
//         gcd = a;
//     }
    
//     static void Main()
//     {
//         int a = 18, b = 48, result;
//         FindGCD(a, b, out result);
//         Console.WriteLine(result);
//     }
// }

// Գրել մեթոդ, որը ստանում է երկու թվային փոփոխականի արժեք ref-ի միջոցով:


// class Program
// {
//     static void AssignValue(ref int number)
//     {
//         number = 42;
//     }

//     static void Main()
//     {
//         int value = 0;
//         AssignValue(ref value);
//         Console.WriteLine(value);
//     }
// }

// Գրել մեթոդ, որը ստանում է params-ով թվերի զանգված և վերադարձնում է դրանց միջինը out-ի միջոցով:

// class Program
// {
//     static void SumArray(out int sum, params int[] numbers)
//     {
//         sum = 0;
//         foreach (var num in numbers)
//             sum += num;
//     }

//     static void Main()
//     {
//         int result;
//         SumArray(out result, 1, 2, 3, 4, 5);
//         Console.WriteLine($"Sum: {result}");
//     }
// }

// Գրել մեթոդ, որը ստանում է params-ով թվերի զանգված և վերադարձնում դրանց գումարը:

// class Program
// {
//     static int SumArray(params int[] numbers)
//     {
//         int sum = 0;
//         foreach (var num in numbers)
//             sum += num;
//         return sum;
//     }

//     static void Main()
//     {
//         Console.WriteLine($"Sum: {SumArray(1, 2, 3, 4, 5)}");
//     }
// }

// Գրել մեթոդ, որը ստուգում է, արդյոք թիվը զույգ է, թե ոչ: Արդյունքը վերադարձրեք out-ի միջոցով:

// class Program
// {
//     static void IsEven(in int number, out bool isEven)
//     {
//         isEven = (number % 2 == 0);
//     }
    
//     static void Main()
//     {
//         int num = 41;
//         bool result;
//         IsEven(in num, out result);
//         Console.WriteLine($"{num} {result}");
//     }
// }

// Գրել մեթոդ, որը գեներացնում է պատահական թիվ 1-ից 100 միջակայքում out-ի միջոցով:

// class Program
// {
//     static void GenerateRandom(out int number)
//     {
//         Random rnd = new Random();
//         number = rnd.Next(1, 101);
//     }

//     static void Main()
//     {
//         int random;
//         GenerateRandom(out random);
//         Console.WriteLine(random);
//     }
// }

// Գրել մեթոդ, որը ստանում է տողային և փոխում է այն աշխատելով ref մոդիֆիկատորով:

// class Program
// {
//     static void ModifyString(ref string text)
//     {
//         text += "456";
//     }

//     static void Main()
//     {
//         string message = "123";
//         ModifyString(ref message);
//         Console.WriteLine(message);
//     }
// }

// Գրել մեթոդ, որը ստանում է թվերի զանգված params-ով և գտնում դրանցից ամենամեծը out-ի միջոցով:

// class Program
// {
//     static void FindMaxValue(out int max, params int[] numbers)
//     {
//         if (numbers.Length == 0)
//         {
//             max = int.MinValue;
//             return;
//         }
//         max = numbers[0];
//         foreach (int num in numbers)
//         {
//             if (num > max)
//                 max = num;
//         }
//     }

//     static void Main()
//     {
//         FindMaxValue(out int max, 10, 25, 34, 99, 7);
//         Console.WriteLine("Maximum value: " + max);
//     }
// }

// Գրել մեթոդ, որը ստանում է in մոդիֆիկատորով տող և վերադարձնում դրա երկարությունը out-ի միջոցով:

// class Program
// {
//     static void GetStringLength(in string input, out int length)
//     {
//         length = input.Length;
//     }

//     static void Main()
//     {
//         string word = "HelloWorld";
//         GetStringLength(in word, out int length);
//         Console.WriteLine($"Length of '{word}': {length}");
//     }
// }



// Xndir

// public class HelloWorld
// {
//     static void CalculateAverage(int[] grades, out double average)
//     {
//         if (grades.Length == 0)
//         {
//             average = 0;
//             return;
//         }
        
//         int sum = 0;
//         foreach (var num in grades)
//             sum += num;
//         average = (double)sum / grades.Length;
//     }
    
//     static void UpdateGrade(ref int grade, int newgrade)
//     {
//         grade = newgrade;
//     }
    
//     static void Display(string name, params int[] grades)
//     {
//         Console.WriteLine($"\nStudent: {name}");
//         Console.Write("Grades: ");
//         foreach (var grade in grades)
//             Console.Write($"{grade} ");
//         Console.WriteLine();
        
//         CalculateAverage(grades, out double average);
//         Console.WriteLine($"Average: {average:F2}");
        
//         int status = IfCompleted(in average);
//         Console.WriteLine(status == 1 ? "Passed" : "Failed");
//     }
    
//     static int IfCompleted(in double average)
//     {
//         return average >= 60 ? 1 : 0;
//     }
    
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter student name: ");
//         string name = Console.ReadLine();

//         Console.Write("Enter number of grades: ");
//         int numGrades = int.Parse(Console.ReadLine());

//         int[] grades = new int[numGrades];
//         for (int i = 0; i < numGrades; i++)
//         {
//             Console.Write($"Enter grade {i + 1}: ");
//             grades[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine();
//         Display(name, grades);

//         Console.Write("Do you want to change any grades? (yes/no): ");
//         string response = Console.ReadLine();

//         while (response == "yes")
//         {
//             Console.Write("Enter the grade number you want to change (1 to " + numGrades + "): ");
//             int gradeToUpdate = int.Parse(Console.ReadLine()) - 1; 
//             if (gradeToUpdate >= 0 && gradeToUpdate < numGrades)
//             {
//                 Console.Write($"Enter the new grade for grade {gradeToUpdate + 1}: ");
//                 grades[gradeToUpdate] = int.Parse(Console.ReadLine());
//             }
//             else
//                 Console.WriteLine("Invalid grade number.");
//             Console.WriteLine();
//             Display(name, grades);
//             Console.Write("Do you want to change any other grades? (yes/no): ");
//             response = Console.ReadLine();
//         }
//     }
// }

