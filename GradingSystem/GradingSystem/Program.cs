using GradingSystem.src;
using GradingSystem.src.Exceptions;

class Program
{
    static void Main()
    {
        var resultProcessor = new StudentResultProcessor();
        string inputFilePath = "students.txt";
        string outPutFilePath = "report.txt";

        try
        {
            var students = resultProcessor.ReadStudentFromFile(inputFilePath);
            resultProcessor.WriteReportToFile(students, outPutFilePath);
            Console.WriteLine("Report Complete");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (InvalidScoreFormatException ex)
        {
            Console.WriteLine("Score format is invalid");
        }
        catch (GradingSystem.src.Exceptions.MissingFieldException ex)
        {
            Console.WriteLine("Some fields are missing");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}