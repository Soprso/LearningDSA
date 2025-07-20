using System;
using System.Transactions;

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

    public void PrintUsingRecursion(Node<T> node)
    {
        if (node == null)
        {
            System.Console.WriteLine("Exiting Head is null..");
            return;
        }
        System.Console.WriteLine("Print using recursion started");
        System.Console.WriteLine(node.Data + " -> <-");
        PrintUsingRecursion(node.Next);
    }

    //Using a public wrapper since Node<T> head is private. 
    public void PrintUsingRecursion()
    {
        PrintUsingRecursion(head);  //calling the og method with argument inside a mthod since it wont be accessible in Main.
    }

    // Again adding a wrapper since Node<T> head is private. 
    public bool SeachUsingRecursion(T tar)
    {
        return SearchUsingRecursion(head, tar);
    }

    public bool SearchUsingRecursion(Node<T> head, T tar)
    {
        if (head == null)
            return false;
        if (head.Data!.Equals(tar))  // equivalent to (head == tar) but asks to ignore null and type conversion.
            return true;
        return SearchUsingRecursion(head.Next, tar);
    }

    public int CountNodes()
    {
        var current = head;
        int length = 0;
        while (current != null)
        {
            length++;
            current = current.Next;
        }
        return length;
    }

    public int CountNodesRecursive()
    {
        return CountNodesRecursive(head);
    }
    public int CountNodesRecursive(Node<T> head)
    {
        if (head == null)
            return 0;
        return 1 + CountNodesRecursive(head.Next);
    }

}
