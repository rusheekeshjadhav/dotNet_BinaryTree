using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    public class Tree
    {
        public Node root;

        public Tree()
        {
            this.root = null;

            Form1.treeEvent.insert += addNode;
            Form1.treeEvent.traverse += traverseTree;
        }

        public void addNode(int value)
        {
            if (isEmpty())
                this.root = new Node(value);
            else
            {
                Node trav = root;
                Node newNode = new Node(value);
                insertion(newNode, trav);
            }
        }

        public void insertion(Node newNode, Node trav)
        {
            if(newNode.data < trav.data)
            {
                if(trav.left != null) { insertion(newNode, trav.left); }
                else { trav.left = newNode; return; }
            }
            else
            {
                if(trav.right != null) { insertion(newNode, trav.right); }
                else { trav.right = newNode; return; }
            }
        }

        public void traverseTree()
        {
            if (isEmpty())
                Console.WriteLine("Tree is empty");
            else
            {
                inOrder(root);
            }
        }

        public void inOrder(Node node)  // LVR
        {
            if(node == null)
                return;

            inOrder(node.left);     // traverse the left subtree first

            Console.WriteLine(node.data + " ");

            inOrder(node.right);    // traverse the right subtree later
        }

        public bool isEmpty()
        {
            return root == null;
        }
    }
}
