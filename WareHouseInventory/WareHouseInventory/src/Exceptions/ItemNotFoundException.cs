namespace WareHouseInventory.src.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}