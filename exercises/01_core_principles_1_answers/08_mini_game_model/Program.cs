using System;

abstract class Character
{
    public string Name { get; set; } = "Unknown";
    public int Health { get; private set; } = 100;
    public int Level { get; private set; } = 1;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("Damage cannot be negative.");
            return;
        }

        Health -= damage;

        if (Health < 0)
            Health = 0;
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Healing amount cannot be negative.");
            return;
        }

        Health += amount;
    }

    public void LevelUp()
    {
        Level++;
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

class Merchant : Character
{
    public override void Act()
    {
        Console.WriteLine(Name + " offers items for sale.");
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
            new Merchant { Name = "Merchant" }
        };

        foreach (Character character in characters)
        {
            character.TakeDamage(10);
            character.LevelUp();
            character.Act();

            Console.WriteLine(
                character.Name +
                " - Health: " + character.Health +
                ", Level: " + character.Level);
        }
    }
}
