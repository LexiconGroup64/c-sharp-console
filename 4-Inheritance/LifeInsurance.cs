using _4_Inheritance.Interfaces;

namespace _4_Inheritance;

public class LifeInsurance : IInsurance, IReceipt
{
    public int StartYear { get; set; }

    public bool SignUp(Person person)
    {
        throw new NotImplementedException();
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