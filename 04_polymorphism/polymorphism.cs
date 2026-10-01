/*
class Character
{
    public virtual void Attack()
    {
        Console.WriteLine("Character attacks.");
    }
}

class Player : Character
{
    public override void Attack()
    {
        Console.WriteLine("Player attacks with a weapon.");
    }
}

class Enemy : Character
{
    public override void Attack()
    {
        Console.WriteLine("Enemy attacks the player.");
    }
}

class NPC : Character
{
    public override void Attack()
    {
        Console.WriteLine("NPC does something else.");
    }
}

class Pet : Character
{
}
*/

class Character
{
    public virtual void TakeTurn()
    {
        Console.WriteLine("Character takes a turn.");
    }

    class Player : Character
    {
        public override void TakeTurn()
        {
            Console.WriteLine("Player chooses an action.");
        }
    }
    class Enemy : Character
    {
        public override void TakeTurn()
        {
            Console.WriteLine("Enemy follows its AI behaviour.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Character player = new Player();
            // Character enemy = new Enemy();
            // Character npc = new NPC();
            // Character pet = new Pet();

            // player.Attack();
            // enemy.Attack();
            // npc.Attack();
            // pet.Attack();

            Character[] characters =
            {
            new Player(),
            new Enemy()
            };

            foreach (Character character in characters)
            {
                character.TakeTurn();
            }

        }
    }
}