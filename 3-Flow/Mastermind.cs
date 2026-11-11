namespace _3_Flow;

public class Mastermind
{
    private int currentPosition = 0;
    private int[] currentColor = [0, 0, 0, 0];

    public void Run()
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Clear();
            UpdateDisplay();
            int choice = UserInput();
            if(choice == 1 || choice == 2)
            {
                MoveSideways(choice);
            } 
            else if (choice == 3 || choice == 4)
            {
                ChangeColor(choice);
            } 
            else if (choice == 5)
            {
                keepRunning = false;
            }
        }

    }
    
    private void MoveSideways(int choice)
    {
        if (currentPosition > 0 && choice == 1)
        {
            currentPosition--;
        } 
        else if (currentPosition < 3 && choice == 2)
        {
            currentPosition++;
        }
        
    }

    private void ChangeColor(int choice)
    {
        int color = currentColor[currentPosition];
        if (color == 0 && choice == 3)
        {
            currentColor[currentPosition] = 6;
        }
        else if (color == 6 && choice == 4)
        {
            currentColor[currentPosition] = 1;
        }
        else if (color == 1 && choice == 3)
        {
            currentColor[currentPosition] = 6;
        }
        else if (choice == 4)
        {
            currentColor[currentPosition] = color + 1;
        }
        else if (choice == 3)
        {
            currentColor[currentPosition] = color - 1;
        }

    }

    private void SetColor(int color)
    {
        switch (color)
        {
            case 0:
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.Magenta;
                break;
            case 5:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case 6:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            default:
                break;
        }
    }

    private void UpdateDisplay()
    {
        foreach (int color in currentColor)
        {
            SetColor(color);
            Console.Write('\u2b24');
            Console.Write("  ");
        }
    }
    
    private int UserInput()
    {
        ConsoleKey userChoice = Console.ReadKey().Key;
        switch (userChoice)
        {
            case ConsoleKey.LeftArrow:
                return 1;
            case ConsoleKey.RightArrow:
                return 2;
            case ConsoleKey.DownArrow:
                return 3;
            case ConsoleKey.UpArrow:
                return 4;
            case ConsoleKey.Enter:
                return 5;
            default:
                return 6;
        }
    }
}