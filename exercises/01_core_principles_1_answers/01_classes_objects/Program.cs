using System;

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
        Weapon sword = new Weapon();
        sword.Name = "Iron Sword";
        sword.Damage = 25;

        Weapon bow = new Weapon();
        bow.Name = "Wooden Bow";
        bow.Damage = 15;

        Weapon axe = new Weapon();
        axe.Name = "Battle Axe";
        axe.Damage = 40;

        sword.Attack();
        bow.Attack();
        axe.Attack();
    }
}
