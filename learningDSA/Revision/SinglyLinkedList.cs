using System;

namespace Revision;

public class SinglyLinkedList<T>
{
    private Node<T> head;

    //Add to the end
    public void AddLast(T data)
    {
        var newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        var current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }
    //Add to the beginning
    public void AddFirst(T data)
    {
        var newNode = new Node<T>(data);
        newNode.Next = head;
        head = newNode;
    }
    //search for a value
    public bool Search(T data)
    {
        var current = head;
        while (current != null)
        {
            if (current.Data!.Equals(data)) // it means (current.Data.Equals(data)) ! -> is a null forgiving operator. It tells the compiler "I know current.Data isn't null, don't warn me"
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    //delete a node
    public void Delete(T data)
    {
        if (head == null)
            return;
        if (head.Data!.Equals(data))
        {
            head = head.Next;
            return;
        }
        var current = head;
        while (current.Next != null)
        {
            if (current.Next.Data!.Equals(data))
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }

    public void PrintList()
    {
        var current = head;
        while (current != null)
        {
            System.Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        System.Console.WriteLine("null");
    }
}
