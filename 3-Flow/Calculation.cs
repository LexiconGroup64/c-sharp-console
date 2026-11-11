using Microsoft.VisualBasic;

namespace _3_Flow;

public class Calculation
{
    public static void MathExample()
    {
        decimal price = Math.Round(100 * 12.34m * 1.11m)/100;
        

        decimal moneyIn = 13.70m;
        
        Console.WriteLine(price);

        Console.ReadLine();
        
        int g = 5 % 2;  // 5 / 2 = 2 => 5 - 2 * 2 = 1 
        Console.WriteLine(g);
        Console.WriteLine("Enter a number");
        string input = Console.ReadLine();
        int possibleNumber;
        int.TryParse(input, out possibleNumber);

        float a = 3.1f;
        float b = 1.1f;

        int c = (int)b;
        float d = 56.1f;
        double e = 56.1d;
        decimal f = (decimal)b;

        Math.Abs(-35);  // 35
        Math.Sqrt(16);  // 4
        Math.Pow(4, 3); // 256
        Math.Floor(45.7); // 45
        Math.Ceiling(45.7); // 46
        Math.Round(45.5);  // 46
        Math.Round(44.5);  // 44

        
        
        Random random = new Random();
        random.Next(24, 206);
        
        Console.WriteLine(a - b);
    }
}