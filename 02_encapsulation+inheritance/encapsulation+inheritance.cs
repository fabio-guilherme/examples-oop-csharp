using System;

class Player
{
    private string Name = "Unknown";
    public int Health;
    private int Level;
    public int Strength;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }

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

        player1.Health = -1000;
        player1.SetLevel(-5);

        Console.WriteLine(player1.Health);
        Console.WriteLine(player1.GetLevel());

    }
}