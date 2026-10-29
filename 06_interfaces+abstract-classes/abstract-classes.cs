abstract class Item
{
    public string Name { get; set; } = "Unknown";

    public abstract void Use();
}

class Potion : Item
{
    public override void Use()
    {
        Console.WriteLine(Name + " restores health.");
    }
}

class Weapon : Item
{
    public override void Use()
    {
        Console.WriteLine(Name + " is equipped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Item[] items =
        {
            new Potion { Name = "Health Potion" },
            new Weapon { Name = "Iron Sword" }
        };

        foreach (Item item in items)
        {
            item.Use();
        }
    }
}