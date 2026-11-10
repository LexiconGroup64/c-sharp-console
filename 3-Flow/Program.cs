

using _3_Flow;

bool continueExecution = true;
while (continueExecution)
{
    int choice = Presentation.BetterMenu();
    if (choice == -1)
    {
        continueExecution = false;
    }
}

string snippet =
    "The Array class is not part of the System.Collections namespaces. However, it is still considered a collection because it is based on the IList interface.\n\nThe Array class is the base class for language implementations that support arrays. However, only the system and compilers can derive explicitly from the Array class. Users should employ the array constructs provided by the language.\n\nAn element is a value in an Array. The length of an Array is the total number of elements it can contain. The lower bound of an Array is the index of its first element. An Array can have any lower bound, but it has a lower bound of zero by default. A different lower bound can be defined when creating an instance of the Array class using CreateInstance. A multidimensional Array can have different bounds for each dimension. An array can have a maximum of 32 dimensions.";

string formattedText = Presentation.CapitalizeFirstLine(snippet);

Console.WriteLine(formattedText);

Console.Read();

int[] accounting = [-80020, 400220, 911000, -90000, 488200];
Presentation.EconomicReport(accounting);

Console.Read();


string[] textCollection = ["Fredric", "Bertrand", "Augustus", "Bob", "Larry"];

Presentation.ColorizedOutput(textCollection);

Console.Read();



string name1 = textCollection[0];
string name2 = textCollection[1];
string name3 = textCollection[2];

for (int i = 0; i < textCollection.Length; i++)
{
    Console.WriteLine(textCollection[i]);
}


if (textCollection[0] == "Greg")
{
    Console.WriteLine("Name is Greg");
}
else if (textCollection[0] == "Scarlet")
{
    Console.WriteLine("Name is Scarlet");
}
else
{
    Console.WriteLine("Not Greg, nor Scarlet");
}