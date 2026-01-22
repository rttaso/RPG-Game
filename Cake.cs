namespace ConsoleApp2;

public class Cake : Item
{
    public Cake(int x, int y)
    {
        _xLocation = x;
        _yLocation = y;
        Name = "Cake";
    }

    public override void ApplyItem(Player player)
    {
        player.UpdateEnergy(+10);
    }
}