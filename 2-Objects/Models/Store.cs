namespace _2_Objects.Models;

public class Store
{    
    public int StoreCapacity { get; private set; }
    public int Capacity { get; private set; }
    public string Name { get; private set; }

    public Store() { }
    
    public Store (int storeCapacity, int capacity) 
    {
        StoreCapacity = storeCapacity;
        Capacity = capacity;
    }
    
    public Store (int storeCapacity, int capacity, string name) 
    {
        StoreCapacity = storeCapacity;
        Capacity = capacity;
        Name = name;
    }
}