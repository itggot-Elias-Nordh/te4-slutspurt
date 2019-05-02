using System;

namespace BinarySearchTree
{
    class Node
    {
        public int Value { get; private set; }
        public Node Left { get; private set; }
        public Node Right { get; private set; }

        public void insert(int value)
        {
            if (this.Value == 0)
            {
                this.Value = value;
            }
            else if (value < this.Value)
            {
                if (this.Left == null)
                {
                    this.Left = new Node();
                }
                this.Left.insert(value);
            }
            else if (value > this.Value)
            {
                if (this.Right == null)
                {
                    this.Right = new Node();
                }
                this.Right.insert(value);
            }
        }    
    }

    class BinarySearchTree
    {
        static Node tree = new Node();

        static void Main(string[] args)
        {
            create();
            try
            {
                Console.WriteLine(search(tree, 12));
            }
            catch
            {
                Console.WriteLine("No such number in tree");
            }
        }
        static void create()
        {
            int[] numbers = { 4, 2, 7, 1, 9, 12 };
            foreach (int i in numbers)
            {
                tree.insert(i);
            }          
        }

        static int search(Node tree, int value)
        {
            if (value == tree.Value)
            {
                return value;
            }
            else if (value < tree.Value)
            {
                return search(tree.Left, value);
            }
            else
            {
                return search(tree.Right, value);
            }
        }
    }
}