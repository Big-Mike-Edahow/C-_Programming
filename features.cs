// Features Project

Console.Title = "Features";

Console.Write("Please enter text: ");
string text = Console.ReadLine();

if (String.IsNullOrWhiteSpace(text))
{
    Console.WriteLine("\nERROR: No text found!");
}
else
{
    Console.WriteLine("\nThanks. You entered:\n'" + text + "'" + "\n");
    Console.WriteLine("\nText length: " + text.Length);

    string query = text.StartsWith("C#") ? "does " : "does not ";
    Console.WriteLine("Text " + query + "start with 'C#'");

    query = text.EndsWith("steps") ? "does " : "Does not ";
    Console.WriteLine("Text " + query + "end with 'steps'");

    query = text.Contains("easy") ? "does " : "Does not ";
    Console.WriteLine("Text " + query + "contain 'easy'");
}

Console.ReadKey();