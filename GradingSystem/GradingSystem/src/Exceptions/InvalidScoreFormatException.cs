namespace GradingSystem.src.Exceptions
{
    public class InvalidScoreFormatException : Exception
    {
        public InvalidScoreFormatException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}