string input = Console.ReadLine();

Dictionary<char, int> characters = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i];

    if (currentChar == ' ')
    {
        continue;
    }

    if (!characters.ContainsKey(currentChar))
    {
        characters.Add(currentChar, 1);
    }
    else
    {
        characters[currentChar]++;
    }
}

foreach (KeyValuePair<char, int> kvp in characters)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}