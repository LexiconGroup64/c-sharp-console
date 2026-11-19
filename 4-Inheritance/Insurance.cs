namespace _4_Inheritance;

public abstract class Insurance
{
    public abstract bool SignUp(Person person);
    public abstract decimal ClaimCompensation(Incident incident);
    public abstract bool ChangeData(int changedData);
}