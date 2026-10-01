class Character
{
    public string Name { get; private set; } = "Unknown";
    public int Health { get; private set; } = 100;

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
        Character character = new Player();
    }
}