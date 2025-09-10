using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructurebasics
{
    public class Tree <T>
    {
        class Node
        {
            public T item;
            public Node right;
            public Node left;
        }
        private Node root;
        public Tree()
        {
            root = null;
        }
        public void Add(T item)
        {
            Node newNode = new Node();
            newNode.item = item;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (Comparer<T>.Default.Compare(item, current.item) < 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        // Traversals
        // PreOrder : Root -> Left -> Right
        private void preOrder(Node current)
        {
            if (current != null)
            {
                Console.Write(current.item + " ");
                InOrder(current.left);
                InOrder(current.right);
            }
        }
        // InOrder : Left -> Root -> Right
        private void InOrder(Node current)
        {
            if (current != null)
            {
                InOrder(current.left);
                Console.Write(current.item +" ");
                InOrder(current.right);
            }
        }
        // PostOrder : Left -> Right -> Root
        private void postOrder(Node current)
        {
            if (current != null)
            {
                InOrder(current.left);
                InOrder(current.right);
                Console.Write(current.item + " ");
            }
        }
        //Display the tree in Inorder traversal
        public void Display()
        {
            Node current = root;
            InOrder(current);
        }
       
    }
}
