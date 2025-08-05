using System.Text.Json;
using InventoryRecord.src.Interface;

namespace InventoryRecord.src
{
    public class InventoryLogger<T> where T : IInventoryEntity
    {
        private List<T> _log;
        private string _filePath;

        public InventoryLogger(string filePath)
        {
            _filePath = filePath;
            _log = new List<T>();
        }
        public void Add(T item)
        {
            _log.Add(item);
        }

        public List<T> GetAll()
        {
            return _log;
        }
        public void SaveToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_log, new JsonSerializerOptions { WriteIndented = true });
                using var writer = new StreamWriter(_filePath);
                writer.Write(json);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error saving to file :" + ex);
            }
        }
        public void LoadFromFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    Console.WriteLine("File not found");
                    return;
                }
                using var reader = new StreamReader(_filePath);
                var json = reader.ReadToEnd();
                var items = JsonSerializer.Deserialize<List<T>>(json);
                if (items != null)
                {
                    _log = items;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}