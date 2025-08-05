namespace InventoryRecord.src
{
    public class InventoryApp
    {
        private InventoryLogger<InventoryItem> _logger;

        public InventoryApp(string filePath)
        {
            _logger = new InventoryLogger<InventoryItem>(filePath);
        }
        public void SeedSampleData()
        {
            _logger.Add(new InventoryItem(1, "Desktop", 1, DateTime.Now));
            _logger.Add(new InventoryItem(2, "Laptop", 1, DateTime.Now));
            _logger.Add(new InventoryItem(3, "Mobile Phone", 1, DateTime.Now));
        }
        public void SaveData()
        {
            _logger.SaveToFile();
        }
        public void LoadData()
        {
            _logger.LoadFromFile();
        }
        public void PrintAlllItems()
        {
            foreach (var item in _logger.GetAll())
            {
                Console.WriteLine("Item id: " + item.Id + ". Name: " + item.Name + ". Quantity: " + item.Quantity + ". Date Added: " + item.DateAdded);
            }
        }
    }
}