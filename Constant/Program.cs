// Constant Project

Console.Title = "Constant";

const double pi = 3.14159265358979;
var daysType = typeof(Days);
string name = Enum.GetName(daysType, 1);
bool flag = Enum.IsDefined(daysType, "Mon");

Console.WriteLine("Pi Type: " + pi.GetType());
Console.WriteLine("Circumference: " + (pi * 3) + "\n");
Console.WriteLine("First Name: " + Days.Sat);
Console.WriteLine("1st Index: " + (int)Days.Sat + "\n");
Console.WriteLine("2nd Index: " + name);
Console.WriteLine("Contains Mon?: " + flag);

Console.ReadKey();


