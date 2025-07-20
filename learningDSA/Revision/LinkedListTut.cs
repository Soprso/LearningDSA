using System;

namespace Revision;

public class LinkedListTut<T>
{
   public T Item { get; set; }  // Capitalized for C# naming convention
    public LinkedListTut<T> Next { get; set; }

    public LinkedListTut(T itemArg, LinkedListTut<T> nextArg)
    {
        this.Item = itemArg;
        this.Next = nextArg;
    }
}

