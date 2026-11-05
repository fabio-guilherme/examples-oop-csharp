public abstract class Weapon
{
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
    }
}
