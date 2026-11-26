using _4_Inheritance.Exceptions;
using _4_Inheritance.Interfaces;

namespace _4_Inheritance;

public class LifeInsurance : IInsurance, IReceipt
{
    public int StartYear { get; set; }

    public bool SignUp(Person person)
    {
        string age = Console.ReadLine();
        try
        {
            int ageNumber = Int32.Parse(age);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You can not be so young");
        }

        throw new NotImplementedException();
    }

    public bool SignUp()
    {
        string age = Console.ReadLine();
        try
        {
            int ageNumber = Int16.Parse(age);
            if (ageNumber > 120) throw new AgeException();
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("You can not be so old");
        }
        


        return false;
    }

public Money ClaimCompensation(Incident incident)
    {
        throw new NotImplementedException();
    }

    public bool ChangeData(int changedData)
    {
        throw new NotImplementedException();
    }

    public Receipt GetReceipt(string transaction)
    {
        throw new NotImplementedException();
    }

    public Receipt GetReceipt(ITransaction transaction)
    {
        throw new NotImplementedException();
    }
}