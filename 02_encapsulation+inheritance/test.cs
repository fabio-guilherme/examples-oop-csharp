using System;

class Player
{
    private string Name = "Unknown";
    private int health;
    private int Level;
    private int strength;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void Heal(int amount)
    {
        health += amount;
    }

    public int Health
    {
        get { return health; }
        set
        {
            /*if (value < 0)
                health = 0;
            else
                health = value;*/
            health = value < 0 ? 0 : (value > 100 ? 100 : value);
        }
    }

    public int Strength { get => strength; set => strength = value; }

    public void SetLevel(int level)
    {
        if (level < 1)
        {
            Console.WriteLine("Level cannot be less than 1.");
            return;
        }
        Level = level;
    }

    public int GetLevel()
    {
        return Level;
    }

}
/*
class Weapon
{
    public string Name;
    public int Damage;

    public void Attack()
    {
        Console.WriteLine(Name + " attacks for " + Damage + " damage!");
    }
}
*/
class Program
{
    static void Main()
    {
        Player player1 = new Player();

        player1.Health = 1000;
        player1.SetLevel(-5);
        player1.Strength = 50;

        Console.WriteLine(player1.Health);
        Console.WriteLine(player1.GetLevel());
        Console.WriteLine(player1.Strength);

    }
}