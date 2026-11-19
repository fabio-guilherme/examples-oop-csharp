// Basic lazy Singleton example, matching the introductory lecture example.
// This implementation is intentionally not thread-safe.

GameManager.Instance.StartGame();
GameManager.Instance.AddScore(100);
GameManager.Instance.AddScore(50);

Console.WriteLine($"Final score: {GameManager.Instance.Score}");

GameManager anotherReference = GameManager.Instance;
Console.WriteLine($"Both references point to the same instance: " +
                  $"{ReferenceEquals(GameManager.Instance, anotherReference)}");

public class GameManager
{
    private static GameManager? instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GameManager();

            return instance;
        }
    }

    public int Score { get; private set; }

    private GameManager()
    {
    }

    public void StartGame()
    {
        Score = 0;
        Console.WriteLine("Game started.");
    }

    public void AddScore(int points)
    {
        Score += points;
        Console.WriteLine($"Score increased by {points}. Current score: {Score}");
    }
}
