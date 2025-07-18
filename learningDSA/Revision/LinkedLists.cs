using System;

namespace Revision;

public class LinkedLists
{
    public Node Head;
    public LinkedLists()
    {
        Head = null;
    }
    public void AddLast(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        {
            Head = newNode;
            return;
        }
        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }
}
