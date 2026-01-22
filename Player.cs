namespace ConsoleApp2;

public class Player
{
    private Bag Bag = new Bag();

    private int _xLocation;
    private int _yLocation;
    private int _health;
    private bool _isAlive;
    private int _energy;
    public Player()
    {
        _health = 100;
        _energy = 100;
        _isAlive = true;
        _xLocation = 0;
        _yLocation = 0;
    }

    
    public void UpdateEnergy(int amount)
    {
        if (_energy > 0 && _energy <= 100)
        {
            _energy += amount;
        } }
    public void UpdateHealth(int amount)
    {
        if (_health > 0 && _health <= 100)
        {
            _health += amount;
        }
        if (_health < 0)
        {
            _isAlive = false;
        }
    }
    
    public void MoveUp()
    {
        _yLocation++;
        if (_energy > 0)
        {
            UpdateEnergy(-5);
        }
        else 

        {
            UpdateEnergy(-5);
        }
    }

    public void MoveDown()
    {
        _yLocation--;
        if (_energy > 0)
        {
            UpdateEnergy(-5);
        }
        else 

        {
            UpdateEnergy(-5);
        }
    }

    public void MoveLeft()
    {
        _xLocation--;
        if (_energy > 0)
        {
            UpdateEnergy(-5);
        }
        else 

        {
            UpdateEnergy(-5);
        }
    }

    public void MoveRight()
    {
        _xLocation++;
        if (_energy > 0)
        {
            UpdateEnergy(-5);
        }
        else 

        {
            UpdateEnergy(-5);
        }
    }
    
    public void UseItem(int itemIndex)
    {
        List<Item> items = Bag.GetItems();
        if (itemIndex < 0 || itemIndex >= items.Count)
        {
            Console.WriteLine("invalid index");
            return;
        }
        Item item = items[itemIndex];
        item.ApplyItem(this);
        Bag.RemoveItem(item);
        Console.WriteLine("you used this item");
    }
    public void ListItems()
    {
        List<Item> items = Bag.GetItems();

        Console.WriteLine("items in your bag:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i].Name}");
        }
    }


    public bool isAlive()
    {
        return _isAlive;
    }
    
    
    public void Search()
    {
        bool found = false;
        int foundIndex = -1;
        
        for (int i = 0; i < Map.Items.Count; i++)
        {
            Item item = Map.Items[i];

            if (item.GetXLocation() == _xLocation &&
                item.GetYLocation() == _yLocation)
            {
                found = true;
                foundIndex = i;
                break;
            }
        }
        if (found == false)
        {
            Console.WriteLine("you didnt find anything");
            return;
        }
        Item foundItem = Map.Items[foundIndex];
        Bag.AddItem(foundItem);
        Map.Items.RemoveAt(foundIndex);

        Console.WriteLine($"You found: {foundItem.Name}");
    }
    
    
    public void PrintPLayerStatus()
    {
        Console.WriteLine($"Health: {_health}, Energy: {_energy}, Location: ({_xLocation}, {_yLocation})");
    }
}