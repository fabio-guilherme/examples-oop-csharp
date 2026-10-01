class Player
{
    public string Name;
    public int Health;

    public void TakeDamage(int damage)
    {
        Health = Math.Max(0, Health - damage);
    }

    public void Heal(int amount)
    {
        Health += amount;
    }

    public int Strength;
}

class Enemy
{
    public string Name;
    public int Health;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }

    public int Damage;
}