using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a mathematical expression (or 'Q' to quit): ");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Q")
                break;

            try
            {
                double result = SolveExpression(input);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in expression: " + ex.Message);
            }
        }
    }

    static double SolveExpression(string expression)
    {
        string[] terms = expression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
        double result = 0;
        
        foreach (var term in terms)
        {
            string[] parts = term.Split(new char[] { '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            double tempResult = Convert.ToDouble(parts[0]);
            
            for (int i = 1; i < parts.Length; i++)
            {
                if (term.Contains('*'))
                {
                    tempResult *= Convert.ToDouble(parts[i]);
                }
                else if (term.Contains('/'))
                {
                    tempResult /= Convert.ToDouble(parts[i]);
                }
            }
            result += tempResult;
        }

        return result;
    }
}