using System.Collections.Generic;

class Inventory
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine(item.Name + " added to inventory.");
    }

    public void ShowItems()
    {
        Console.WriteLine("Inventory:");

        foreach (Item item in items)
        {
            Console.WriteLine("- " + item.Name);
        }
    }
}
