using System;

class Character
{
    public string Name { get; set; } = "Unknown";
    public int Health { get; private set; } = 100;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            return;

        Health -= damage;

        if (Health < 0)
            Health = 0;
    }

    public void Heal(int amount)
    {
        if (amount < 0)
            return;

        Health += amount;
    }
}

class Player : Character
{
}

class Enemy : Character
{
}

class NPC : Character
{
    public string Dialogue { get; set; } = "Hello!";
}

class Program
{
    static void Main()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();
        NPC npc = new NPC();

        player.Name = "Knight";
        enemy.Name = "Goblin";
        npc.Name = "Villager";
        npc.Dialogue = "Welcome to the village!";

        player.TakeDamage(20);
        enemy.Heal(10);

        Console.WriteLine(player.Name + ": " + player.Health);
        Console.WriteLine(enemy.Name + ": " + enemy.Health);
        Console.WriteLine(npc.Name + ": " + npc.Dialogue);
    }
}
