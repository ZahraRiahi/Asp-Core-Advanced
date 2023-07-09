// Read five nouns from the input
Console.WriteLine("Please enter five names:");
string[] names = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("{0}: ", i + 1);
    names[i] = Console.ReadLine();
}

// Sort and print the result
Array.Sort(names);
Console.WriteLine("Names in alphabetical order:");
foreach (string name in names)
{
    Console.WriteLine(name);
}