// Debug Project

int pass = 0;
int unit = 2;

for (int i = 0; i <3; i++)
{
    pass = (pass + 1);
    unit = square(unit);

    Console.WriteLine($"Pass is: {pass}, Unit is: {unit}");
}

static int square(int num)
{
    return (num * num);
}
