Dictionary<string, (double Price, int Quantity)> productDict = new();

string command = Console.ReadLine();

while (command != "buy") // beer 2.20 100
{

    string[] parts = command.Split(' '); // [beer, 2.20, 100]
    string keyEl = parts[0];
    double priceEl = double.Parse(parts[1]);
    int quantityEl = int.Parse(parts[2]);

    double price = priceEl * quantityEl;

    if (!productDict.ContainsKey(keyEl))
    {
        //productDict[keyEl] = (priceEl, quantityEl);
        productDict.Add(keyEl, (priceEl, quantityEl));  // beer: (2.20, 100)
    }
    else
    {
        var existingProduct = productDict[keyEl];
        productDict[keyEl] = (priceEl, existingProduct.Quantity + quantityEl);
    }

    command = Console.ReadLine();

}

foreach (var product in productDict)
{
    double totalPrice = product.Value.Price * product.Value.Quantity;
    Console.WriteLine($"{product.Key} -> {totalPrice:F2}"); // Format to 2 decimal places
}