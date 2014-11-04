using Common;
using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        //Given a binary tree structure, traverse over the tree in breadth-first pattern
        var root = new Node()
        {
            Value = 1,
            LeftNode = new Node()
            {
                Value = 2,
                LeftNode = new Node()
                {
                    Value = 4,
                    RightNode = new Node() { Value = 8 },
                    LeftNode = new Node() { Value = 9 }
                },
                RightNode = new Node()
                {
                    Value = 5,
                    LeftNode = new Node() { Value = 10 },
                    RightNode = new Node() { Value = 11 }
                }
            },
            RightNode = new Node()
            {
                Value = 3,
                LeftNode = new Node()
                {
                    Value = 6,
                    LeftNode = new Node() { Value = 12 },
                    RightNode = new Node() { Value = 13 }
                },
                RightNode = new Node()
                {
                    Value = 7,
                    LeftNode = new Node() { Value = 14 },
                    RightNode = new Node() { Value = 15 }
                }
            }
        };
        Console.WriteLine("***********BREADTH-FIRST TRAVERSAL*******************");
        TraverseBreadthFirst(root);
        Console.WriteLine("***********DEPTH-FIRST TRAVERSAL*******************");
        TraverseDepthFirst(root);
        Console.ReadLine();
    }

    static void TraverseBreadthFirst(Node n)
    {
        var q = new Queue();
        q.Enqueue(n);
        while (q.Count > 0)
        {
            Node current = (Node)q.Dequeue();
            if (current == null)
            {
                continue;
            }
            q.Enqueue(current.LeftNode);
            q.Enqueue(current.RightNode);
            current.Value.Dump();
        }
    }

    static void TraverseDepthFirst(Node n)
    {
        var s = new Stack();
        s.Push(n);
        while (s.Count>0)
        {
            Node current = (Node)s.Pop();
            if (current==null)
            {
                continue;
            }
            s.Push(current.LeftNode);
            s.Push(current.RightNode);
            current.Value.Dump();
        }
    }

    //Given a balanced binary tree, find a given node

}
public class Node
{
    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }
    public int Value { get; set; }
}
