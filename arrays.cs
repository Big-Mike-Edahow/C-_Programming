// Arrays Project

Console.Title = "Arrays";

// Declare and initialize two new arrays
string[] cars = new string[3] { "BMW", "Ford", "Opel" };
int[,] coords = new int[2,3] { { 1,2,3}, {4,5,6} };

// Print the values of the array elements
Console.WriteLine("Second Car: " + cars[1]);
Console.WriteLine("X1, Y1: " + coords[0, 0]);
Console.WriteLine("X2, Y3: " + coords[1, 2]);

Console.ReadKey();