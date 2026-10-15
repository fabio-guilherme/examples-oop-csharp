using System;
using System.Collections.Generic;

class Inventory
{
    private readonly int capacity;
    private readonly List<string> items = new List<string>();

    public int Count => items.Count;
    public int Capacity => capacity;

    public Inventory(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than zero.");

        this.capacity = capacity;
    }

    public bool AddItem(string item)
    {
        if (string.IsNullOrWhiteSpace(item) || items.Count >= capacity)
            return false;

        items.Add(item);
        return true;
    }

    public bool RemoveItem(string item)
    {
        return items.Remove(item);
    }

    public void ShowItems()
    {
        foreach (string item in items)
            Console.WriteLine("- " + item);
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory(2);

        Console.WriteLine(inventory.AddItem("Potion"));
        Console.WriteLine(inventory.AddItem("Key"));
        Console.WriteLine(inventory.AddItem("Sword"));

        inventory.ShowItems();

        inventory.RemoveItem("Key");
        inventory.ShowItems();
    }
}
