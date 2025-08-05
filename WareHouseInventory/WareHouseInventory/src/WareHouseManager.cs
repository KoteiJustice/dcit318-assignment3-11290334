using WareHouseInventory.src.Interfaces;

namespace WareHouseInventory.src
{
    public class WareHouseManager
    {
        public InventoryRepository<ElectronicItem> _electronics = new();
        public InventoryRepository<GroceryItem> _groceries = new();

        public void SeedData()
        {
            _electronics.AddItem(new ElectronicItem(101, "TV", 1, "Samsung", 36));
            _electronics.AddItem(new ElectronicItem(102, "Mobile Phone", 1, "Samsung", 12));

            _groceries.AddItem(new GroceryItem(201, "Fruits", 5, DateTime.MaxValue));
            _groceries.AddItem(new GroceryItem(202, "Vegetables", 7, DateTime.MaxValue));
        }
        public void PrintAllItems<T>(InventoryRepository<T> repo) where T : IInventoryItem
        {
            foreach (var item in repo.GetAllItems())
            {
                Console.WriteLine("ID: " + item.Id + ". Name: " + item.Name + ". Quantity: " + item.Quantity + ".");
            }
        }
        public void IncreaseStock<T>(InventoryRepository<T> repo, int id, int quantity) where T : IInventoryItem
        {
            try
            {
                var item = repo.GetItemById(id);
                repo.UpdateQuantity(id, item.Quantity + quantity);
                Console.WriteLine("Stock for " + item.Id + " has been updated to " + item.Quantity);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating stock: " + ex.Message);
            }
        }
        public void RemoveItemById<T>(InventoryRepository<T> repo, int id) where T : IInventoryItem
        {
            try
            {
                repo.RemoveItem(id);
                Console.WriteLine("Item " + id + " removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error removing item: " + ex.Message);
            }

        }
    }
}