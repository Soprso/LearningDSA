using System;

namespace Revision;

public class LinkedList<T>
{
    public T data { get; set; }

    public LinkedList<T> link { get; set; }

    public LinkedList(T dataItem, LinkedList<T> linkRef)
    {
        this.data = dataItem;
        this.link = linkRef;
    }
}
