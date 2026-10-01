class Character
{
    public string Name = "Unknown";
    public int Health = 100;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }
}

class Player : Character
{
    public int Strength { get; set; }
}

class Enemy : Character
{
    public int Damage { get; set; }
}

class NPC : Character
{
    public string Dialogue { get; set; }
}

class Program
{
    static void Main()
    {
        //Character character = new Player();
        Player player = new Player();
        Enemy enemy = new Enemy();
        player.Name = "Hero";
        player.Strength = 10;
        enemy.Name = "Goblin";
        enemy.Damage = 5;
        Console.WriteLine($"Player: {player.Name}, Health: {player.Health}, Strength: {player.Strength}");
        Console.WriteLine($"Enemy: {enemy.Name}, Health: {enemy.Health}, Damage: {enemy.Damage}");
        //---
        Character character1 = new Player();
        Character character2 = new Enemy();

        Character[] characters =
        {
        new Player(),
        new Enemy(),
        new NPC()
        };

        foreach (Character character in characters)
        {
            Console.WriteLine($"Character: {character.Name}, Health: {character.Health}");
        }
        for(int i = 0; i < characters.Length; i++)
        {
            Console.WriteLine($"Character: {characters[i].Name}, Health: {characters[i].Health}");
        }
    }
}