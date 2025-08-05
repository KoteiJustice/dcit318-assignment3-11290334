using GradingSystem.src.Exceptions;

namespace GradingSystem.src
{
    public class StudentResultProcessor
    {
        public List<Student> ReadStudentFromFile(string inputFilePath)
        {
            var students = new List<Student>();
            using var reader = new StreamReader(inputFilePath);

            string? line;
            int lineNumber = 0;

            while ((line = reader.ReadLine()) != null)
            {
                lineNumber++;
                var parts = line.Split(',');
                if (parts.Length != 3)
                {
                    throw new Exceptions.MissingFieldException("Missing " + (3 - parts.Length) + " fields ");
                }
                if (!int.TryParse(parts[0], out int id))
                {
                    throw new InvalidScoreFormatException("Invalid id format on line " + lineNumber);
                }
                if (!int.TryParse(parts[2], out int score))
                {
                    throw new InvalidScoreFormatException("Invalid score on line " + lineNumber);
                }

                string fullName = parts[1].Trim();
                students.Add(new Student(id, fullName, score));
            }
            return students;
        }

        public void WriteReportToFile(List<Student> students, string outPutFilePath)
        {
            using var writer = new StreamWriter(outPutFilePath);
            foreach (var student in students)
            {
                writer.WriteLine($"{student.FullName} (ID: {student.Id}): Score = {student.Score}, Grade = {student.GetGrade()}");
            }
        }
    }
}