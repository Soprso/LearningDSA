using System;

namespace Revision;

public interface IRepository<T>
{
    void AddElement(T item);
    List<T> GetAll();
    List<T> GetByCondition(Func<T, bool> predicate);

}
