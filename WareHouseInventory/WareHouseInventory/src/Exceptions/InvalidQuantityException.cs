namespace WareHouseInventory.src.Exceptions
{
    public class InvalidQuantityException : Exception
    {
        public InvalidQuantityException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}