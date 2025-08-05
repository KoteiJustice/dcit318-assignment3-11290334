namespace HealthcareSystem.src
{
    public class Repository<T>
    {
        private List<T> items = [];

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll() => new(items);
        public T? GetById(Func<T, bool> predicate)
        {
            return items.FirstOrDefault(predicate);
        }

        public bool Remove(Func<T, bool> predicate)
        {
            var item = GetById(predicate);
            if (item != null)
            {
                items.Remove(item);
                return true;
            }
            return false;
        }
    }
}