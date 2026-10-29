
using System;

// PART 1: ABSTRACT CLASSES

abstract class InteractableObject
{
    public string Name { get; private set; }

    protected InteractableObject(string name)
    {
        Name = name;
    }

    public abstract void Interact();
}

class Door : InteractableObject
{
    public Door(string name) : base(name)
    {
    }

    public override void Interact()
    {
        Console.WriteLine(Name + " opens.");
    }
}

class TreasureChest : InteractableObject
{
    public TreasureChest(string name) : base(name)
    {
    }

    public override void Interact()
    {
        Console.WriteLine(Name + " opens and reveals its treasure!");
    }
}

// PART 2: INTERFACES

interface ISaveable
{
    void Save();
}

class GameSession : ISaveable
{
    public void Save()
    {
        Console.WriteLine("Game session saved.");
    }
}

class PlayerProfile : ISaveable
{
    public void Save()
    {
        Console.WriteLine("Player profile saved.");
    }
}

// MAIN PROGRAM

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Interactable Objects ===");

        InteractableObject[] interactableObjects =
        {
            new Door("Castle Gate"),
            new TreasureChest("Ancient Chest"),
            new Door("Dungeon Door")
        };

        foreach (InteractableObject obj in interactableObjects)
        {
            obj.Interact();
        }

        Console.WriteLine();
        Console.WriteLine("=== Saveable Objects ===");

        ISaveable[] saveableObjects =
        {
            new GameSession(),
            new PlayerProfile()
        };

        foreach (ISaveable obj in saveableObjects)
        {
            obj.Save();
        }
    }
}
