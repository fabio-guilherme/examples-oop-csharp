public abstract class Weapon
{
    public int Damage { get; set; }
    public abstract void Attack();
}

public class Sword : Weapon
{
    public override void Attack()
    {
        Console.WriteLine("Attacks with a sword.");
    }
}

public class Bow : Weapon
{
    public override void Attack()
    {
        Console.WriteLine("Shoots an arrow.");
    }
}

// Additional weapon class for exercise
class Staff : Weapon
{
    public override void Attack()
    {
        Console.WriteLine("Casts a magical spell.");
    }
}
//

public class Character
{
    private Weapon weapon;

    public Character(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void EquipWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void Attack()
    {
        weapon.Attack();
    }
}

public class Program
{
    public static void Main()
    {
        Character player = new Character(new Sword());
        player.Attack();

        player.EquipWeapon(new Bow());
        player.Attack();

        // Additional weapon class for exercise
        player.EquipWeapon(new Staff());
        player.Attack();
        //
    }
}