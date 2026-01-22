namespace ConsoleApp2;

public class Banana : Item
{
    public Banana(int x, int y)
    {
        _xLocation = x;
        _yLocation = y;
        Name = "Banana";
    }

    public override void ApplyItem(Player player)
    {
        player.UpdateEnergy(+10);
        player.UpdateHealth(+10);
    }
}