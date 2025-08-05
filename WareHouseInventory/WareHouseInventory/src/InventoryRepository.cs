using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseInventory.src.Exceptions;
using WareHouseInventory.src.Interfaces;

namespace WareHouseInventory.src
{
    public class InventoryRepository<T> where T : IInventoryItem
    {
        Dictionary<int, T> _items = new();

        public void AddItem(T item)
        {
            if (_items.ContainsKey(item.Id))
            {
                throw new DuplicateItemException("Item already exists.");
            }
            _items[item.Id] = item;
        }
        public T GetItemById(int id)
        {
            if (!_items.ContainsKey(id))
            {
                throw new ItemNotFoundException("Item not found");
            }
            return _items[id];
        }
        public void RemoveItem(int id)
        {
            if (!_items.Remove(id))
            {
                throw new ItemNotFoundException("Item not found");
            }
            
        }
        public List<T> GetAllItems()
        {
            return _items.Values.ToList();
        }
        public void UpdateQuantity(int id, int newQuantity)
        {
            if (newQuantity < 0)
            {
                throw new InvalidQuantityException("Quantity cannot be negative.");
            }
            GetItemById(id).Quantity = newQuantity;
        }
    }
}