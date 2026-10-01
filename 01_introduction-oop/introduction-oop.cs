using System;

class Player
{
    private int health = 100;

    public string Name;
    public int Level;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void Heal(int amount)
    {
        health += amount;
    }

    public int GetHealth()
    {
        return health;
    }
}

class Weapon
{
    public string Name;
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

        Console.WriteLine(player1.GetHealth());

        Weapon sword = new Weapon();

        sword.Name = "Iron Sword";
        sword.Damage = 25;

        sword.Attack();
    }
}