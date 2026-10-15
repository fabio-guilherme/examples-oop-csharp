using System;

class Character
{
    public string Name { get; private set; } = "Unknown";
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
        {
            Health = 0;
        }
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
}

class Program
{
    static void Main()
    {
        Character character = new Character();

        character.TakeDamage(30);
        character.Heal(10);
        character.LevelUp();

        Console.WriteLine("Health: " + character.Health);
        Console.WriteLine("Level: " + character.Level);

        character.TakeDamage(-5);
        character.Heal(-10);

        Console.WriteLine("Health after invalid operations: " + character.Health);
    }
}
