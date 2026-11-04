namespace _2_Objects.Models;

public class PetrolStation
{
    private int numberOfDispensers;
    private string dispenserType;

    private string streetAddress;
    private Store store;

    public void SetStore(Store newStore)
    {
        // Does newStore have a capacity?
        store = newStore;
    }
}