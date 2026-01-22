namespace ConsoleApp2;

public abstract class Item
{
    protected int _xLocation; 
    protected int _yLocation;

    public int GetXLocation()
    {
        return this._xLocation;
    }
    public int GetYLocation()
    {
        return this._yLocation;
    }
    public string Name { get; set; }
    public abstract void ApplyItem(Player player);
    public virtual string GetItemInfo()
    {
        return $"{Name}: ({_xLocation}, {_yLocation})";
    }
    
}