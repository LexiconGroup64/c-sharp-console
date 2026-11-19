namespace _4_Inheritance.Interfaces;

public interface IReceipt
{
    Receipt GetReceipt(ITransaction transaction);
}