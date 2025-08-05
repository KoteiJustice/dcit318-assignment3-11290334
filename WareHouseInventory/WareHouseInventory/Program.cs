using WareHouseInventory.src;
using WareHouseInventory.src.Exceptions;

public class Program
{
    public static void Main()
    {
        WareHouseManager manage = new();

        manage.SeedData();
        Console.WriteLine("List of all groceries:");
        manage.PrintAllItems(manage._groceries);
        Console.WriteLine("\nList of all electronics:");
        manage.PrintAllItems(manage._electronics);

        Console.WriteLine("\n Testing new Exceptions");
        try
        {
            manage._electronics.AddItem(new ElectronicItem(3, "Tablet", 1, "Tecno", 18));
        }
        catch (DuplicateItemException ex)
        {
            Console.WriteLine(ex.Message);
        }
        manage.RemoveItemById(manage._groceries, 90);
        manage.IncreaseStock(manage._electronics, 2, -5);
    }
}