namespace _3_Flow;

public class Presentation
{
    public static void ColorizedOutput(string[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            string name = items[i];
            if (name.Length > 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(name);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            } 
            else if (name.Length > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(name);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(name);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
    }

    public static void EconomicReport(int[] accountValues)
    {
        for (int i = 0; i < accountValues.Length; i++)
        {
            if (accountValues[i] < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(accountValues[i]);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else
            {
                Console.WriteLine(accountValues[i]);
            }
        }
    }
}