namespace _2_Objects.Models;

public class PetrolStation
{
    private int numberOfDispensers;
    private string dispenserType;

    private string streetAddress;
    private Store store;

    public void SetStore(Store newStore)
    {
        Console.WriteLine("Side effect");
        // Does newStore have a capacity?
        store = newStore;
    }
    
    public int WriteToConsole(string message)
    {
        Console.WriteLine(message);
        return 34;
    }
    
    public string WriteToConsole(string firstPart, string secondPart)
    {
        string message = StringTogether(firstPart, secondPart);
        Console.WriteLine(message);
        return "test";
    }
    
    public int WriteToConsole(string group, int detail)
    {
        
        Console.WriteLine(group);
        return detail + 1;
    }
    
    public int WriteToConsole(int detail, string group)
    {
        
        Console.WriteLine(group);
        return detail + 1;
    }

    
    public int WriteToConsole(string firstPart, string secondPart, int counter)
    {
        string message = StringTogether(firstPart, secondPart);
        Console.WriteLine(message);
        return counter + 1;
    }

    private string StringTogether(string firstPart, string secondPart)
    {
        return firstPart + secondPart;
    }
    
}