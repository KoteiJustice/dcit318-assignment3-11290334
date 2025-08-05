namespace WareHouseInventory.src.Exceptions
{
    public class DuplicateItemException :Exception
    {
        public DuplicateItemException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}