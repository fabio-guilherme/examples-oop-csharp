using System;

class Character
{
    public string Name { get; set; } = "Unknown";
    public int Health { get; private set; } = 100;

    public virtual void Act()
    {
        Console.WriteLine(Name + " acts.");
    }
}

class Player : Character
{
    public override void Act()
    {
        Console.WriteLine(Name + " attacks with a weapon.");
    }
}

class Enemy : Character
{
    public override void Act()
    {
        Console.WriteLine(Name + " attacks the player.");
    }
}

class NPC : Character
{
    public override void Act()
    {
        Console.WriteLine(Name + " talks to the player.");
    }
}

class Boss : Character
{
    public override void Act()
    {
        Console.WriteLine(Name + " performs a powerful attack.");
    }
}

class Program
{
    static void Main()
    {
        Character[] characters =
        {
            new Player { Name = "Knight" },
            new Enemy { Name = "Goblin" },
            new NPC { Name = "Villager" },
            new Boss { Name = "Dragon" }
        };

        foreach (Character character in characters)
        {
            character.Act();
        }
    }
}
