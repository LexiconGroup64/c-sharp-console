namespace _4_Inheritance;

public class Location
{
    public int Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }

    public Location(int id, string street, string city)
    {
        (Id, Street, City) = (id, street, city);
    }
}