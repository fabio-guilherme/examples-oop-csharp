using System;

class Player
{
    public string Name = "Unknown";
    public int Health = 100;
    public int Level;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }
}

class Weapon
{
    public string Name = "Unknown";
    public int Damage;

    public void Attack()
    {
        Console.WriteLine(Name + " attacks for " + Damage + " damage!");
    }
}

class Program
{
    static void Main()
    {
        Player player1 = new Player();

        player1.Name = "Knight";
        player1.Level = 1;

        player1.TakeDamage(25);

        Console.WriteLine(player1.Health);

        Weapon sword = new Weapon();

        sword.Name = "Iron Sword";
        sword.Damage = 25;

        sword.Attack();
    }
}