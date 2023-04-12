// Parameter Project

double weight = 10;
string num;

static string getWeight()
{
    return "Ten";
}

static double lbToKg( double pounds = 5)
{
    return (pounds * .45359237);
}

num = getWeight();
Console.WriteLine( num + " lb = " + lbToKg(weight) + " kg");
lbToKg( weight );
Console.WriteLine( num + " kg = " + weight + " lb");

Console.ReadKey();