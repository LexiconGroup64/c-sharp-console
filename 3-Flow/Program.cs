

using _3_Flow;

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