class Character
{
    public string Type { get; set; }
    public void Act()
    {
        if (Type == "Player")
            Console.WriteLine("Player attacks with a weapon.");
        else if (Type == "Enemy")
            Console.WriteLine("Enemy attacks the player.");
        else
            Console.WriteLine("NPC does something else.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Character player = new Character { Type = "Player" };
        Character enemy = new Character { Type = "Enemy" };
        Character npc = new Character { Type = "NPC" };

        player.Act();
        enemy.Act();
        npc.Act();
    }
}