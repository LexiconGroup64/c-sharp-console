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

    public static string CapitalizeFirstLine(string text)
    {
        string[] words = text.Split(" ");
        List<string> newWords = text.Split(" ").ToList();
        newWords.Add("The last sentence.");
        words = newWords.ToArray();
        
        
        string formattedText = "";
        int textLength = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (textLength < 60)
            {
                words[i] = words[i].ToUpper();
            }

            textLength = textLength + words[i].Length + 1;
            formattedText = formattedText + " " + words[i];
        }
        formattedText.TrimStart();
        return formattedText;
    }
}