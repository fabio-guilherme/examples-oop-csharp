interface IDamageable
{
    void TakeDamage(int amount);
}

class Character : IDamageable
{
    public void TakeDamage(int amount)
    {
        Console.WriteLine("Character takes damage.");
    }
}

class Crate : IDamageable
{
    public void TakeDamage(int amount)
    {
        Console.WriteLine("Crate breaks or becomes damaged.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IDamageable[] targets =
        {
            new Character(),
            new Crate()
        };

        foreach (IDamageable target in targets)
        {
            target.TakeDamage(10);
        }

    }
}