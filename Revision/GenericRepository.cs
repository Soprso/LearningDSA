using System;

namespace Revision;

public class GenericRepository<T> : IRepository<T> where T : IEntity
{
    private List<T> elem = new List<T>();
    public void AddElement(T item)
    {
        elem.Add(item);
    }
    public List<T> GetAll()
    {
        return elem;
    }
    public List<T> GetByCondition(Func<T, bool>predicate)
    {
        return elem.Where(predicate).ToList();
    }
}
