using System;

class Item
{
    public string Name { get; set; } = "Unknown";
    public double Weight { get; set; }
    public int Value { get; set; }
}

class Weapon : Item
{
    public int Damage { get; set; }
}

class Potion : Item
{
    public int HealingAmount { get; set; }
}

class Armour : Item
{
    public int Defence { get; set; }
}

class Program
{
    static void Main()
    {
        Weapon sword = new Weapon
        {
            Name = "Iron Sword",
            Weight = 3.5,
            Value = 100,
            Damage = 25
        };

        Potion potion = new Potion
        {
            Name = "Health Potion",
            Weight = 0.5,
            Value = 25,
            HealingAmount = 50
        };

        Armour armour = new Armour
        {
            Name = "Leather Armour",
            Weight = 8,
            Value = 120,
            Defence = 15
        };

        Console.WriteLine($"{sword.Name} - Damage: {sword.Damage}");
        Console.WriteLine($"{potion.Name} - Healing: {potion.HealingAmount}");
        Console.WriteLine($"{armour.Name} - Defence: {armour.Defence}");
    }
}
