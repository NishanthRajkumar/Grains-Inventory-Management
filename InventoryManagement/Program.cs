using InventoryManagement;
using System.Text.Json;

Console.Title = "Inventory Management App";
Console.WriteLine("===========Grains Inventory Management===========");

// Json file name and path as string
string fileName = @"..\..\..\Inventory.json";

// Read all text from file and store in inventories2 list
string jsonString = File.ReadAllText(fileName);
List<Inventory> inventories = JsonSerializer.Deserialize<List<Inventory>>(jsonString);

// Display all inventories read from file while calculating value for each
foreach (Inventory items in inventories)
{
    Console.WriteLine($"Name: {items.Name}\n\tWeight: {items.Weight} Price/kg: {items.PricePerKG} Price: {items.Value}");
}