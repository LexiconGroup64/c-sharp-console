using _4_Inheritance.Enums;

namespace _4_Inheritance;

public class Person
{
    public ScreenMode DisplayPreference { get; set; }

    public Person()
    {
        DisplayPreference = ScreenMode.Light;
    }
}