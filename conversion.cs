// Conversion Project

Console.Title = "Conversion";

Console.Write("Please enter a number: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter another number: ");
double sum = num + Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Total = " + sum);
Console.ReadKey();