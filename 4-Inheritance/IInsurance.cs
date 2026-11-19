namespace _4_Inheritance;

public interface IInsurance
{
    bool SignUp(Person person);
    Money ClaimCompensation(Incident incident);
    bool ChangeData(int changedData);
}