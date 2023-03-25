// Switch Project

Console.Title = "Switch";

int num = 1;
string day;

switch (num)
{
    case 1: day = "Monday"; break;
    case 2: day = "Tuesday"; break;
    case 3: day = "Wednesday"; break;
    case 4: day = "Thursday"; break;
    case 5: day = "Friday"; break;
    default: day = "Today"; break;
}

Console.WriteLine("Day " + num + ": " + day);
Console.ReadKey();
