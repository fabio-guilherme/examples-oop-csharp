// Observer example: PlayerHealth is the subject. The display and warning
// systems subscribe and are notified whenever the player's health changes.

PlayerHealth playerHealth = new();
IObserver healthDisplay = new HealthDisplay();
IObserver lowHealthWarning = new LowHealthWarning();

playerHealth.Subscribe(healthDisplay);
playerHealth.Subscribe(lowHealthWarning);

Console.WriteLine("The player takes 25 damage.");
playerHealth.TakeDamage(25);

Console.WriteLine("\nThe player takes another 55 damage.");
playerHealth.TakeDamage(55);

Console.WriteLine("\nThe warning system unsubscribes.");
playerHealth.Unsubscribe(lowHealthWarning);

Console.WriteLine("The player takes another 10 damage.");
playerHealth.TakeDamage(10);

public interface IObserver
{
    void Update(int health);
}

public class HealthDisplay : IObserver
{
    public void Update(int health)
    {
        Console.WriteLine($"Health bar updated: {health}");
    }
}

public class LowHealthWarning : IObserver
{
    public void Update(int health)
    {
        if (health <= 25)
            Console.WriteLine("Warning: player health is critically low!");
    }
}

public class PlayerHealth
{
    private readonly List<IObserver> observers = new();
    private int health = 100;

    public void Subscribe(IObserver observer)
    {
        ArgumentNullException.ThrowIfNull(observer);

        if (!observers.Contains(observer))
            observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void TakeDamage(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(
                nameof(amount), "Damage cannot be negative.");

        health = Math.Max(0, health - amount);
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (IObserver observer in observers)
            observer.Update(health);
    }
}
