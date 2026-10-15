using System;

abstract class Character
{
    public string Name { get; set; } = "Unknown";
    public int Health { get; private set; } = 100;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            return;

        Health -= damage;

        if (Health < 0)
            Health = 0;
    }

    public abstract void Act();
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

class Program
{
    static void Main()
    {
        Character[] characters =
        {
            new Player { Name = "Knight" },
            new Enemy { Name = "Goblin" },
            new NPC { Name = "Villager" }
        };

        foreach (Character character in characters)
        {
            character.Act();
        }

        // This would not compile:
        // Character character = new Character();
    }
}
