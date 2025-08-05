using InventoryRecord.src;

public class Program
{
    static void Main()
    {
        string filePath = "inventory.json";
        var app = new InventoryApp(filePath);

        app.SeedSampleData();
        app.SaveData();

        app = new InventoryApp(filePath);
        app.LoadData();
        app.PrintAlllItems();
        
    }
}