using System;

class Character
{
    public virtual void Act()
    {
        Console.WriteLine("Character acts.");
    }
}

class Player : Character
{
    public override void Act()
    {
        Console.WriteLine("Player acts.");
    }
}

class Enemy : Character
{
    public new void Act()
    {
        Console.WriteLine("Enemy acts.");
    }
}

class Program
{
    static void Main()
    {
        Character player = new Player();
        Character enemy = new Enemy();

        player.Act();
        enemy.Act();

        Console.WriteLine();

        Player directPlayer = new Player();
        Enemy directEnemy = new Enemy();

        directPlayer.Act();
        directEnemy.Act();
    }
}
