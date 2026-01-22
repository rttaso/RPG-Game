namespace ConsoleApp2;

public class ExpiredFood : Item
{
    public ExpiredFood(int x, int y)
    {
        _xLocation = x;
        _yLocation = y;
        Name = "Expired Food";
    }

    public override void ApplyItem(Player player)
    {
        player.UpdateEnergy(+5);
        player.UpdateHealth(-15);
    }
}
