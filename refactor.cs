// Refactor Project

Console.Title = "Refactor";

static int factorial(int num)
{
    int result;
    if(num == 1)
    {
        result = 1;
    }
    else
    {
        result = (factorial(num - 1) * num);
    }
    return result;
}

static void computeFactorials(int num, int max)
{
    while(num <= max)
    {
        Console.Write("Factorial of " + num + " :");
        Console.WriteLine(factorial(num));
        num++;
    }
}

computeFactorials(1, 16);
Console.ReadKey();