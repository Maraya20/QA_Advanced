string resource = Console.ReadLine();

Dictionary<string, int> mineDict = new();

while (resource != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!mineDict.ContainsKey(resource))
    {
        mineDict.Add(resource, quantity);
    }
    else
    {
        mineDict[resource] += quantity;
    }

    resource = Console.ReadLine();
}

foreach (var kvp in mineDict)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}