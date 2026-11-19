// Simple Factory example: the client requests an Enemy without constructing
// the concrete enemy class itself.

EnemyFactory factory = new();

Enemy drone = factory.CreateEnemy("drone");
Enemy alien = factory.CreateEnemy("alien");

Console.WriteLine("The enemies attack:");
drone.Attack();
alien.Attack();

try
{
    factory.CreateEnemy("unknown");
}
catch (ArgumentException exception)
{
    Console.WriteLine($"Factory error: {exception.Message}");
}

public abstract class Enemy
{
    public abstract void Attack();
}

public class Drone : Enemy
{
    public override void Attack()
    {
        Console.WriteLine("Drone fires lasers.");
    }
}

public class Alien : Enemy
{
    public override void Attack()
    {
        Console.WriteLine("Alien attacks.");
    }
}

public class EnemyFactory
{
    public Enemy CreateEnemy(string type)
    {
        return type.ToLowerInvariant() switch
        {
            "drone" => new Drone(),
            "alien" => new Alien(),
            _ => throw new ArgumentException(
                $"Unknown enemy type: '{type}'.", nameof(type))
        };
    }
}
