class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character attacks.");
    }
}

class PlayerWithSword : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks with a sword.");
    }
}

class PlayerWithBow : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks with a bow.");
    }
}

class EnemyWithSword : Character
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks with a sword.");
    }
}