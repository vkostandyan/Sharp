using System;


// Օգտագործողի իրավունքների կառավարում
// enum UserRole
// {
//     Guest,
//     User,
//     Moderator,
//     Admin
// }

// class Program
// {
//     static bool HasPermission(UserRole role, string action)
//     {
//         switch (role)
//         {
//             case UserRole.Admin:
//                 return true;
//             case UserRole.Moderator:
//                 return action switch
//                 {
//                     "Modify" => true,
//                     "Read" => true,
//                     _ => false
//                 };
//             case UserRole.User:
//                 return action == "Read";
//             case UserRole.Guest:
//                 return false;
//             default:
//                 return false;
//         }
//     }

//     static void Main()
//     {
//         UserRole role = UserRole.User;
//         string action = "Modify";

//         Console.WriteLine($"{role} {action} -> {HasPermission(role, action)}");
//     }
// }

// Անձրևի կանխատեսում

// using System;

// enum WeatherCondition
// {
//     Sunny,
//     Cloudy,
//     Rainy,
//     Stormy
// }

// class Program
// {
//     static string GetRecommendation(WeatherCondition weather)
//     {
//         switch (weather)
//         {
//             case WeatherCondition.Sunny:
//                 return "It's a beautiful day! Wear sunglasses and stay hydrated.";
//             case WeatherCondition.Cloudy:
//                 return "It might be a bit chilly. Consider carrying a light jacket.";
//             case WeatherCondition.Rainy:
//                 return "Don't forget your umbrella and wear waterproof shoes.";
//             case WeatherCondition.Stormy:
//                 return "Stay indoors if possible. If you must go out, be careful!";
//             default:
//                 return "Unknown weather condition.";
//         }
//     }

//     static void Main()
//     {
//         WeatherCondition currentWeather = WeatherCondition.Rainy;
//         Console.WriteLine($"Weather: {currentWeather}");
//         Console.WriteLine(GetRecommendation(currentWeather));
//     }
// }

// Ավտոմեքենայի փոխանցման տուփ
// using System;

// enum Gear
// {
//     P,
//     R, 
//     N, 
//     D 
// }

// class Program
// {
//     static void DescribeGear(Gear gear)
//     {
//         switch (gear)
//         {
//             case Gear.P:
//                 Console.WriteLine("Parking");
//                 break;
//             case Gear.R:
//                 Console.WriteLine("Reverse");
//                 break;
//             case Gear.N:
//                 Console.WriteLine("Neutral");
//                 break;
//             case Gear.D:
//                 Console.WriteLine("Drive");
//                 break;
//             default:
//                 Console.WriteLine("Unknown gear.");
//                 break;
//         }
//     }

//     static void Main()
//     {
//         Gear currentGear = Gear.D;
//         Console.WriteLine($"Current Gear: {currentGear}");
//         DescribeGear(currentGear);
//     }
// }


// Օպերացիոն համակարգի տարբերակներ

// using System;

// enum OperatingSystem
// {
//     MacOS,
//     Linux,
//     Windows
// }

// class Program
// {
//     static void PrintApplications(OperatingSystem os)
//     {
//         switch (os)
//         {
//             case OperatingSystem.MacOS:
//                 Console.WriteLine("Safari, Final Cut Pro, Xcode, Pages");
//                 break;
//             case OperatingSystem.Linux:
//                 Console.WriteLine("Firefox, GIMP, LibreOffice, Terminal");
//                 break;
//             case OperatingSystem.Windows:
//                 Console.WriteLine("Microsoft Edge, MS Office, Visual Studio, Notepad");
//                 break;
//             default:
//                 Console.WriteLine("Unknown operating system");
//                 break;
//         }
//     }

//     static void Main()
//     {
//         OperatingSystem currentOS = OperatingSystem.Linux;
//         Console.WriteLine($"Operating System: {currentOS}");
//         PrintApplications(currentOS);
//     }
// }


// Ամսվա եղանակի որոշում

// using System;

// enum Season
// {
//     Winter,
//     Spring,
//     Summer,
//     Autumn
// }

// class Program
// {
//     static Season GetSeason(int month)
//     {
//         return month switch
//         {
//             12 or 1 or 2 => Season.Winter,
//             3 or 4 or 5 => Season.Spring,
//             6 or 7 or 8 => Season.Summer,
//             9 or 10 or 11 => Season.Autumn,
//             _ => throw new ArgumentException("Invalid month. Must be between 1 and 12.")
//         };
//     }

//     static void Main()
//     {
//         int month = 3;
//         Season season = GetSeason(month);  
//         Console.WriteLine($"Month {month} belongs to {season}.");
//     }
// }


// Հեռախոսային օպերատոր

// using System;

// enum MobileOperator
// {
//     Beeline,
//     MTS,
//     Ucom
// }

// class Program
// {
//     static void PrintOperatorCodes(MobileOperator operatorName)
//     {
//         switch (operatorName)
//         {
//             case MobileOperator.Beeline:
//                 Console.WriteLine("374-99, 374-43.");
//                 break;
//             case MobileOperator.MTS:
//                 Console.WriteLine("374-93, 374-98, 374-94.");
//                 break;
//             case MobileOperator.Ucom:
//                 Console.WriteLine("374-55, 374-95, 374-41.");
//                 break;
//             default:
//                 Console.WriteLine("Unknown operator.");
//                 break;
//         }
//     }

//     static void Main()
//     {
//         MobileOperator myOperator = MobileOperator.MTS;
//         Console.WriteLine($"Operator: {myOperator}");
//         PrintOperatorCodes(myOperator);
//     }
// }


// Ծրագրավորման լեզուների տեսակավորում

// using System;

// enum ProgrammingLanguage
// {
//     CSharp,
//     Java,
//     Python,
//     JavaScript
// }

// class Program
// {
//     static void PrintUsageFields(ProgrammingLanguage language)
//     {
//         switch (language)
//         {
//             case ProgrammingLanguage.CSharp:
//                 Console.WriteLine("C# is used in: Desktop applications, Game development (Unity), Web development (ASP.NET).");
//                 break;
//             case ProgrammingLanguage.Java:
//                 Console.WriteLine("Java is used in: Enterprise applications, Mobile development (Android), Web applications.");
//                 break;
//             case ProgrammingLanguage.Python:
//                 Console.WriteLine("Python is used in: Data science, AI & Machine learning, Web development, Automation.");
//                 break;
//             case ProgrammingLanguage.JavaScript:
//                 Console.WriteLine("JavaScript is used in: Web development, Frontend frameworks, Backend (Node.js).");
//                 break;
//             default:
//                 Console.WriteLine("Unknown programming language.");
//                 break;
//         }
//     }

//     static void Main()
//     {
//         ProgrammingLanguage lang = ProgrammingLanguage.Python;
//         Console.WriteLine($"Selected Language: {lang}");
//         PrintUsageFields(lang);
//     }
// }


// Բանկային գործարքներ

// using System;

// enum TransactionType
// {
//     Deposit,
//     Withdraw,
//     Transfer
// }

// class Program
// {
//     static void ProcessTransaction(TransactionType transaction, ref decimal balance, decimal amount)
//     {
//         switch (transaction)
//         {
//             case TransactionType.Deposit:
//                 balance += amount;
//                 Console.WriteLine($"Deposited {amount}. New balance: {balance}");
//                 break;
//             case TransactionType.Withdraw:
//                 if (balance >= amount)
//                 {
//                     balance -= amount;
//                     Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Insufficient funds for withdrawal.");
//                 }
//                 break;
//             case TransactionType.Transfer:
//                 if (balance >= amount)
//                 {
//                     balance -= amount;
//                     Console.WriteLine($"Transferred {amount}. New balance: {balance}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Insufficient funds for transfer.");
//                 }
//                 break;
//             default:
//                 Console.WriteLine("Invalid transaction type.");
//                 break;
//         }
//     }

//     static void Main()
//     {
//         decimal balance = 1000m;
//         TransactionType transaction = TransactionType.Withdraw;
//         decimal amount = 200m;

//         Console.WriteLine($"Initial balance: {balance}");
//         ProcessTransaction(transaction, ref balance, amount);
//     }
// }


// Գույներ

// using System;

// enum ColorMode
// {
//     RGB,
//     CMYK,
//     Grayscale
// }

// class Program
// {
//     static void PrintColorModeDescription(ColorMode mode)
//     {
//         switch (mode)
//         {
//             case ColorMode.RGB:
//                 Console.WriteLine("RGB (Red, Green, Blue) is used for digital displays, combining these colors to create various shades.");
//                 break;
//             case ColorMode.CMYK:
//                 Console.WriteLine("CMYK (Cyan, Magenta, Yellow, Key/Black) is used in color printing to combine these four inks.");
//                 break;
//             case ColorMode.Grayscale:
//                 Console.WriteLine("Grayscale uses shades of gray, with no color, typically used for black-and-white printing or displays.");
//                 break;
//             default:
//                 Console.WriteLine("Unknown color mode.");
//                 break;
//         }
//     }

//     static void Main()
//     {
//         ColorMode mode = ColorMode.CMYK;
//         Console.WriteLine($"Selected Color Mode: {mode}");
//         PrintColorModeDescription(mode);
//     }
// }

