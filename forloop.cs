// ForLoop Project

Console.Title = "ForLoop";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Loop iteration: " +  i);
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Inner loop iteration: " + j);
    }
}

Console.ReadKey();