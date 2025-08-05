namespace WareHouseInventory.src.Interfaces
{
    public interface IInventoryItem
    {
        public int Id { get; }
        string Name { get; }
        int Quantity { get; set; }
    }
}