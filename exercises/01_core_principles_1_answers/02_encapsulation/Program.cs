using System;

class Player
{
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
        Player player = new Player();

        player.TakeDamage(25);
        player.Heal(10);
        player.LevelUp();

        Console.WriteLine("Health: " + player.Health);
        Console.WriteLine("Level: " + player.Level);

        // These would not compile:
        // player.Health = -1000;
        // player.Level = -5;
    }
}
