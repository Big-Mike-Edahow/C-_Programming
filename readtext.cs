// ReadText Project

Console.Title = "ReadText";

string path = "./word.txt";

if (File.Exists(path))
{
    try
    {

        Console.WriteLine("Three different ways to display the text from the file.\n");
        Console.WriteLine("File Read: " + path + "\n");

        Console.WriteLine("A string variable with ReadAllText:\n");
        string text = File.ReadAllText(path);
        Console.WriteLine(text + "\n");

        Console.WriteLine("A string array with ReadAllLines and a for loop:\n");
        string[] lines = File.ReadAllLines(path);
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        Console.WriteLine("\nA string array with ReadAllLines and a foreach loop:\n");
        lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
    catch (Exception error)
    {
        Console.WriteLine(error.Message);
    }
}
else
{
    Console.WriteLine("File Not Found: " + path);
}
Console.ReadKey();