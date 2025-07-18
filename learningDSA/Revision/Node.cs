using System;

namespace Revision;

public class Node
{
    public int Data;
    public Node Next;
    public Node(int data)
    {
        this.Data = data;
        this.Next = null;
    }

}
