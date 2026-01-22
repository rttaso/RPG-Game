namespace ConsoleApp2;

public class Poison : Item
{
    public Poison(int x, int y)
    {
        _xLocation = x;
        _yLocation = y;
        Name = "Poison";
    }

    public override void ApplyItem(Player player)
    {
        player.UpdateHealth(-20);
    }
}
