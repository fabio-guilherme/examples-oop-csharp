using System;

abstract class Character
{
    public string Name { get; set; } = "Unknown";
    public int Health { get; private set; } = 100;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("Damage cannot be negative.");
            return;
        }

        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public abstract void Act();
}

class Player : Character
{
    public override void Act()
    {
        Console.WriteLine("Player attacks with a weapon.");
    }
}

class Enemy : Character
{
    public override void Act()
    {
        Console.WriteLine("Enemy attacks the player.");
    }
}

class NPC : Character
{
    public override void Act()
    {
        Console.WriteLine("NPC talks to the player.");
    }
}

class Program
{
    static void Main()
    {
        Character[] characters =
        {
            new Player(),
            new Enemy(),
            new NPC()
        };

        foreach (Character character in characters)
        {
            character.Act();
        }
    }
}