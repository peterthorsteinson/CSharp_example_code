# DeleteNode_BinarySearchTree

```csharp
// Given a binary search tree and a target value, 
// delete the node that has the target value from the BST
using System;

public class DeleteNode_BinarySearchTree
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
    public DeleteNode_BinarySearchTree()
    {
        root = null;
    }

    public void DeleteValue(int value)
    {
        root = DeleteValue(root, value);
    }

    private Node DeleteValue(Node root, int value)
    {
        // empty tree so nothing to delete
        if (root == null) return root;

        if (value < root.value)
            root.left = DeleteValue(root.left, value);
        else if (value > root.value)
            root.right = DeleteValue(root.right, value);
        else // match founfd so value needs to be deleted
        {
            // if node has only one or zero children 
            if (root.left == null)
                return root.right;
            else if (root.right == null)
                return root.left;

            // node has two children so find inorder successor
            // (i.e. smallest value in right subtree) 
            root.value = GetMinValue(root.right);

            // delete inorder successor just calculated
            root.right = DeleteValue(root.right, root.value);
        }
        return root;
    }

    int GetMinValue(Node root)
    {
        int minValue = root.value;
        while (root.left != null)
        {
            minValue = root.left.value;
            root = root.left;
        }
        return minValue;
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

    // display in order traversal of nodes
    public void InOrderTraverse()
    {
        InOrderTraverse(root);
    }

    private void InOrderTraverse(Node root)
    {
        if (root != null)
        {
            InOrderTraverse(root.left);
            Console.Write(root.value + " ");
            InOrderTraverse(root.right);
        }
    }

    public Node FindNode(int value)
    {
        return FindNode(root, value);
    }

    private Node FindNode(Node node, int value)
    {
        if (node == null)
            return null;
        else if (value < node.value)
            return FindNode(node.left, value);
        else if (value > node.value)
            return FindNode(node.right, value);
        else // must be equal
            return node;
    }


}

class Program
{
    public static void Main(String[] args)
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

        DeleteNode_BinarySearchTree tree = new DeleteNode_BinarySearchTree();

        // populate tree with sample data
        for (int i = 0; i < randoms_ints.Length; i++)
        {
            tree.InsertValue(randoms_ints[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Inorder traversal:");
        tree.InOrderTraverse();
        Console.WriteLine();

        int value = 63;
        DeleteNode_BinarySearchTree.Node resultNode;
        resultNode = tree.FindNode(value);
        if (resultNode != null)
            Console.WriteLine("Found: " + value);
        else
            Console.WriteLine("Not found: " + value);

        Console.WriteLine("Delete 63");
        tree.DeleteValue(63);

        resultNode = tree.FindNode(value);
        if (resultNode != null)
            Console.WriteLine("Found: " + value);
        else
            Console.WriteLine("Not found: " + value);

        Console.WriteLine("Inorder traversal:");
        tree.InOrderTraverse();
        Console.WriteLine();

        Console.WriteLine("Delete 163");
        tree.DeleteValue(163);

        Console.WriteLine("Inorder traversal:");
        tree.InOrderTraverse();
        Console.WriteLine();

        value = 163;
        resultNode = tree.FindNode(value);
        if (resultNode != null)
            Console.WriteLine("Found: " + value);
        else
            Console.WriteLine("Not found: " + value);
    }
}
```
