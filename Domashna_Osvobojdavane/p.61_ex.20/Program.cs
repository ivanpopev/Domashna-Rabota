using System;
//Homework by Ivan Popev p.61/ex.20

namespace p._61_ex._20
{
    class Node
    {
        public int stoinost;
        public Node left;
        public Node right;
    }
    class Tree
    {
        public Node Insert(Node root, int qwe)
        {
            if (root == null)
            {
                root = new Node();
                root.stoinost = qwe;
            }
            else if (qwe < root.stoinost)
            {
                root.left = Insert(root.left, qwe);
            }
            else
            {
                root.right = Insert(root.right, qwe);
            }
            return root;
        }
        public bool Correct(Node root, int a)
        {
            return root.stoinost == a;
        }
        public bool Search(Node root, int stoinost2)
        {
            try
            {
                if (root == null || root.stoinost == stoinost2)
                {
                    if (root.stoinost == stoinost2) Console.WriteLine($"[{stoinost2}] namereno!");
                    return true;
                }
                if (root.stoinost > stoinost2) return Search(root.left, stoinost2);
                return Search(root.right, stoinost2);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"[{stoinost2}] ne e namereno!");
                return false;
            }
        }
        public int MinVal(Node root)
        {
            Node current = root;

            while (current.left != null)
            {
                current = current.left;
            }
            return current.stoinost;
        }
        public int MaxVal(Node root)
        {
            Node current = root;

            while (current.right != null)
            {
                current = current.right;
            }
            return current.stoinost;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] vhod = new int[12] { 3, 5, 18, 10, 12, 5, 10, 22, 65, 33, 7, 1 };
            Node root = null;
            Tree binarySearchTree = new Tree();
            for (int i = 0; i < vhod.Length; i++)
            {
                root = binarySearchTree.Insert(root, vhod[i]);
            }
            Console.WriteLine($"Minimalnata stoinost v durvoto e {binarySearchTree.MinVal(root)}");
            Console.WriteLine($"Maksimalnata stoinost v durvoto e { binarySearchTree.MaxVal(root)}");
            Console.WriteLine(binarySearchTree.Search(root, 22));
        }
    }
}
