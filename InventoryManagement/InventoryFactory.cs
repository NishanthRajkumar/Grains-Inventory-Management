using System.Text.Json;

namespace InventoryManagement;

/// <summary>
/// Generates Inventory list from Json file
/// </summary>
public class InventoryFactory
{
    // The path and the name of the json file
    private const string fileName = @"..\..\..\Inventory.json";

    /// <summary>
    /// Gets the Inventory list.
    /// </summary>
    /// <returns>a list of Inventory objects</returns>
    public static List<Inventory> GetInventory()
    {
        string jsonString = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<Inventory>>(jsonString);
    }

    /// <summary>
    /// Gets the json string for the list of inventories
    /// </summary>
    /// <param name="inventories">The inventories.</param>
    /// <returns></returns>
    public static string GetJsonString(List<Inventory> inventories)
    {
        var option = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize<List<Inventory>>(inventories, option);
    }
}
