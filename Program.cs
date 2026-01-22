// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

Player player1  = new Player();
Map.Items.Add(new Cake(2, 5));
Map.Items.Add(new Cake(-4, 2));
Map.Items.Add(new Banana(2, -2));
Map.Items.Add(new Poison(0, 4));
Map.Items.Add(new Poison(3, -5));
Map.Items.Add(new ExpiredFood(-4, -3));

Console.WriteLine("Game has started!");

while (player1.isAlive())
{
    player1.PrintPLayerStatus();
    string inp = Console.ReadLine().ToUpper();
    switch (inp)
    {
        case "W": player1.MoveUp();
            break;
        case "S": player1.MoveDown();
            break;
        case "A": player1.MoveLeft();
            break;
        case "D": player1.MoveRight();
            break;
        case "I": player1.ListItems();
            break;
        case "F": player1.Search();
            break;
    }
    if (inp == "Q")
    {
        break;
    }

    if (inp.StartsWith("U"))
    {
        String [] useString =  inp.Split(' '); 
        if (useString.Length != 2)
        {
            Console.WriteLine("input a valid item");
        }
        else
        {
            player1.UseItem(int.Parse(useString[1]) - 1);
        }
    }
}
Console.WriteLine("Game over!");
