﻿namespace InventoryManagement;

public class Inventory
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double PricePerKG { get; set; }
    public double Value { get { return Weight * PricePerKG; } }

    public Inventory()
    {
        Name = "Grains";
        Weight = 0;
        PricePerKG = 0;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Inventory"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="weight">The weight in kg.</param>
    /// <param name="pricePerKG">The price per kg in Rs.</param>
    public Inventory(string name, double weight, double pricePerKG)
    {
        Update(name, weight, pricePerKG);
    }

    /// <summary>
    /// Updates the inventory.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="weight">The weight.</param>
    /// <param name="pricePerKG">The price per kg.</param>
    public void Update(string name, double weight, double pricePerKG)
    {
        Name = name;
        Weight = weight;
        PricePerKG = pricePerKG;
    }
}
