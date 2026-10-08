using System;

class Player
{
    public string Name { get; private set; } = "Unknown";
    public int Health { get; private set; } = 100;
    public int Level { get; private set; } = 1;
    public int Strength { get; set; }

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
        Player player1 = new Player();

        player1.TakeDamage(25);
        player1.Heal(10);
        player1.LevelUp();

        Console.WriteLine(player1.Health);
        Console.WriteLine(player1.Level);
    }
}