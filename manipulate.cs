// Manipulate Project

Console.Title = "Manipulate";

Console.Write("Please enter text: ");
string text = Console.ReadLine();

Console.Write("\nThanks. You entered:\n'" + text + "'");
Console.WriteLine("\t\tText length: " + text.Length);

text = text.Trim();
Console.Write("\nTrimmed:\t'" + text + "'");
Console.WriteLine("\tText length: " + text.Length);

string upper = text.ToUpper();
Console.WriteLine("\nUpperCase:\t'" + upper + "'");

string lower = text.ToLower();
Console.WriteLine("LowerCase:\t'" + lower + "'");

upper = upper.PadLeft(40);
lower = lower.PadRight(40, '#');
text = text.PadLeft(30, '*');
text = text.PadRight(40, '*');

Console.WriteLine("\nPadded left:\t'" + upper + "'");
Console.WriteLine("\nPadded right:\t'" + lower + "'");
Console.WriteLine("\nPadded both:\t'" + text + "'");

Console.WriteLine("\nTrimmed start:\t'" + upper.TrimStart() + "'");
Console.WriteLine("\nTrimmed end:\t'" + text.TrimEnd('*') + "'");

Console.ReadKey();