namespace ConsoleApp2;

public class Cherry: Item
{
    public Cherry(int x, int y)
    {
        _xLocation = x;
        _yLocation = y;
        Name = "Cherry";
    }

    public override void ApplyItem(Player player)
    {
        player.UpdateEnergy(+10);
        player.UpdateHealth(+10);
    }
}