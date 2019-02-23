# GetAllPaths_BinaryTree

```csharp
// Get all paths of a binary tree

using System;
using System.Collections.Generic;

public class BinarySearchTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }

    Node root;
    public BinarySearchTree()
    {
        root = null;
    }

    public void InsertValue(int value)
    {
        root = InsertValue(root, value);
    }

    private Node InsertValue(Node root, int value)
    {
        // if empty tree then insert and return a new node
        if (root == null)
        {
            root = new Node(value);
            return root;
        }

        if (value < root.value)
            root.left = InsertValue(root.left, value);
        else if (value > root.value)
            root.right = InsertValue(root.right, value);

        return root;
    }

    public virtual void DisplayPaths()
    {
        int[] paths = new int[1000];
        DisplayPaths(root, paths, 0);
    }

    public virtual void DisplayPaths(Node node, int[] paths, int pathLength)
    {
        if (node == null)
        {
            return;
        }

        // accumulate paths
        paths[pathLength] = node.value;
        pathLength++;

        // display path from root to leaf
        if (node.left == null && node.right == null)
        {
            DisplayArray(paths, pathLength);
        }
        else
        {
            DisplayPaths(node.left, paths, pathLength);
            DisplayPaths(node.right, paths, pathLength);
        }
    }

    public virtual void DisplayArray(int[] values, int pathLength)
    {
        int i;
        for (i = 0; i < pathLength; i++)
        {
            Console.Write(values[i] + " ");
        }
        Console.WriteLine("");
    }
}

class Program
{
    public static void Main()
    {

        // create random sample data
        //int SIZE = 10;
        //int[] randoms_ints = new int[SIZE];
        //Random random = new Random();
        //for (int i = 0; i < SIZE; i++)
        //{
        //    randoms_ints[i] = random.Next(100); // returns an int from 0 to 99 inclusive
        //}

        // create non-random sample data
        int[] randoms_ints = new[] { 35, 84, 18, 63, 36, 73, 31, 72, 20, 5 };

        // display sample data
        Console.WriteLine("Display sample data:");
        for (int i = 0; i < randoms_ints.Length; i++)
        {
            Console.Write(randoms_ints[i] + " ");
        }
        Console.WriteLine();

        BinarySearchTree tree = new BinarySearchTree();

        // populate tree with sample data
        for (int i = 0; i < randoms_ints.Length; i++)
        {
            tree.InsertValue(randoms_ints[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Paths:");
        tree.DisplayPaths();
    }
}
```
