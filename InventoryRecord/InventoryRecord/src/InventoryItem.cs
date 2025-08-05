using InventoryRecord.src.Interface;

namespace InventoryRecord.src
{
    public record InventoryItem(int Id, string Name, int Quantity,DateTime DateAdded) : IInventoryEntity;

    
}