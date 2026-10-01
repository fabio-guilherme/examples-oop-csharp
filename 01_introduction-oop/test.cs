class Player
{
    private string Name = "Unknown";
    public int Health;
    private int Level;
    public int Strength;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public int GetLevel()
    {
        return Level;
    }
    public void SetLevel(int level)
    {
        if (level < 1)
        {
            Console.WriteLine("Level cannot be less than 1. Setting level to 1.");
            Level = 1;
        }
        else
        {
            Level = level;
        }
    }
}

class Program
{
    static void Main()
    {
        Player player1 = new Player();
        player1.SetName("Knight");
        player1.Health = 100;
        player1.SetLevel(1);
        player1.Strength = 10;
    
        player1.TakeDamage(25);

        Player player2 = new Player();
        player2.SetName("Archer");
        player2.Health = 80;
        player2.SetLevel(1);

        Player player3 = new Player();
        player3.SetName("Mage");
        player3.Health = 60;    
        player3.SetLevel(1);

        Console.WriteLine(player1.GetName() + " has " + player1.Health + " health.");
        Console.WriteLine(player2.GetName() + " has " + player2.Health + " health.");
        Console.WriteLine(player3.GetName() + " has " + player3.Health + " health.");

        player1.Health = -1000;
        player1.SetLevel(-5);

        Console.WriteLine(player1.GetName() + " has " + player1.Health + " health at level " + player1.GetLevel() + ".");
    }
}

/*
                Player class
                    │
          ┌─────────┼─────────┐
          ↓         ↓         ↓
       player1   player2   player3
       Knight    Wizard    Rogue
       HP: 80    HP: 80    HP: 120
*/