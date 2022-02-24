namespace InventoryManagement;

public class InventoryManager
{
    private List<Inventory> myInventory;

    public void Manage()
    {
        myInventory = InventoryFactory.GetInventory();
        Display();
    }

    public void Display()
    {
        foreach (var item in myInventory)
        {
            Console.WriteLine(item.GetJsonString());
            Console.WriteLine($"Item Value: Rs. {item.GetValue()}\n\n");
        }
    }
}
