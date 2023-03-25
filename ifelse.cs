// IfElse Project

Console.Title = "IfElse";

Console.Write("Please enter a number: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Thanks. Now enter a letter: ");
char letter = Convert.ToChar(Console.ReadLine());

if (num > 5)
{
    Console.WriteLine("\nNumber is greater than 5.");
}
else if (num < 5)
{
    Console.WriteLine("\nNumber is less than 5.");
}
else
{
    Console.WriteLine("\nNumber is 5.");
}

Console.ReadKey();

if (letter == 'C')
{
    Console.WriteLine("\nLetter is equal to C.");
}
