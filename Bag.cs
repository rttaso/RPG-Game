namespace ConsoleApp2;

public class Bag
{
    private static List<Item>_itemsList = new List<Item>();
    
    public void AddItem(Item item)
    {
        _itemsList.Add(item);
    }

    public void RemoveItem(Item item)
    {
        _itemsList.Remove(item);
    }

    public List<Item> GetItems()
    {
        return _itemsList;
    }

    public void ListItems()
    {
        if (_itemsList.Count == 0)
        {
            Console.WriteLine("bag is empty");
            return;
        }

        for (int i = 0; i < _itemsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_itemsList[i].Name}");
        }
    }
}

