namespace _2_Objects.Models;

public class Account
{
    private int id = 56;
    public int YearStarted { get; set; }
    
    public static readonly int MAX_AMOUNT = 999;

    public static string GenerateAccountNumber()
    {
        return "BA-45558-12-F";
    }

    public int GetId()
    {
        return id;
    }

    public void SetId(int newId)
    {
        id = newId;
    }
}