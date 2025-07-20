using System;
using System.Collections;

namespace Revision;

public class Collection : CollectionBase
{
    public void Add(Object item)
    {
        InnerList.Add(item);
    }
    public void Remove(Object item)
    {
        InnerList.Remove(item);
    }
    public void CLear(Object item)
    {
        InnerList.Clear();
    }
    public int Count()
    {
        return InnerList.Count;
    }
}
