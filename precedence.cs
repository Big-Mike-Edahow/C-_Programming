// Precedence Project

Console.Title = "Precedence";

int sum;

sum = 1 + 4 * 3;
Console.WriteLine("Default order:\t\t" + sum);

sum = (1 + 4) * 3;
Console.WriteLine("Forced order:\t\t" + sum + "\n");

sum = 7 - 4 + 2;
Console.WriteLine("Default direction:\t" + sum);

sum = 7 - (4 + 2);
Console.WriteLine("Forced direction:\t" + sum);

Console.ReadKey();
