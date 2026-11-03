using _1_Console.Models;

Counter counterA = new Counter();
Counter counterB;

counterA.count = 88;

counterB = counterA;
counterA.count = 99;

Console.WriteLine(counterB.count);

Console.Read();

Console.WriteLine("No" + " " + "way");
Console.WriteLine(45 + 90);
Console.WriteLine("The text" + 62 + 91);
Console.WriteLine(62 + "The text" + 62 + 91);
Console.WriteLine(62 + 91 + "The text");
string summation = 62 + 91 + "The text";


// int, string, bool
Console.WriteLine(23 != 45 || 23 == 23);


Console.ReadLine();

Console.WriteLine("Hello, World!");
int number = 7;
number = 56;
string inputText = Console.ReadLine();
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("The next part");

// String, Object (Counter) –––– Reference types

// int, double, char,bool ...  --- Value types



