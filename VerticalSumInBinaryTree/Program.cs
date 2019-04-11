using System;

namespace VerticalSumInBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vertical Sum in a Binary Tree!");
            Console.WriteLine();

            BinaryTree binaryTree = GetBinaryTreeFromInput();

            Console.WriteLine("-----------The Result--------");
            PrintVerticalSumInBinaryTree(binaryTree);

            Console.ReadLine();
        }

        private static BinaryTree GetBinaryTreeFromInput() {

            BinaryTree binaryTree = new BinaryTree();

            Console.WriteLine("Enter the number of nodes in the binary tree");
            try
            {
                int numberNodes = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the values of the nodes separated " +
                    "by space");
                String[] elements = Console.ReadLine().Split(' ');
                for (int index = 0; index < numberNodes; index++) {
                    binaryTree.SetBinaryTreeRoot(
                        binaryTree.Insert(binaryTree.GetBinaryTreeRoot(), int.Parse(elements[index]))
                        );
                }
                
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return binaryTree;
        }

        private static void PrintVerticalSumInBinaryTree(BinaryTree binaryTree) {
            if (binaryTree == null)
            {
                Console.WriteLine("Binary tree is null! Cannot have any sum!");
            }
            else {
                DoublyLinkedListNode doublyLinkedListNode = new DoublyLinkedListNode(0);
                PrintVerticalSumInBinaryTree(binaryTree.GetBinaryTreeRoot(), doublyLinkedListNode);
                PrintVerticalSumInBinaryTree(doublyLinkedListNode);
            }
        }

        private static void PrintVerticalSumInBinaryTree(DoublyLinkedListNode doublyLinkedListNode)
        {
            while (doublyLinkedListNode != null
                && doublyLinkedListNode.GetPreviousNode() != null) {
                doublyLinkedListNode = doublyLinkedListNode.GetPreviousNode();
            }

            while (doublyLinkedListNode != null) {
                Console.Write(doublyLinkedListNode.GetDoublyLinkedListNodeData() 
                    + " ");
                doublyLinkedListNode = doublyLinkedListNode.GetNextNode();
            }
        }

        private static void PrintVerticalSumInBinaryTree(BinaryTreeNode binaryTreeNode, DoublyLinkedListNode doublyLinkedListNode)
        {
            if (binaryTreeNode == null)
            {
                return;
            }
            else
            {
                doublyLinkedListNode.SetDoublyLinkedListNodeData(
                    binaryTreeNode.GetBinaryTreeNodeData() + doublyLinkedListNode.GetDoublyLinkedListNodeData());

                if (binaryTreeNode.GetLeft() != null)
                {
                    if (doublyLinkedListNode.GetPreviousNode() == null)
                    {

                        doublyLinkedListNode.SetPreviousNode(
                            new DoublyLinkedListNode(0)
                            );
                        doublyLinkedListNode.GetPreviousNode().
                            SetNextNode(doublyLinkedListNode);
                    }
                    PrintVerticalSumInBinaryTree(binaryTreeNode.GetLeft(),
                        doublyLinkedListNode.GetPreviousNode());
                }
                if (binaryTreeNode.GetRight() != null)
                {
                    if (doublyLinkedListNode.GetNextNode() == null)
                    {
                        doublyLinkedListNode.SetNextNode(
                            new DoublyLinkedListNode(0)
                            );
                        doublyLinkedListNode.GetNextNode()
                            .SetPreviousNode(doublyLinkedListNode);
                    }
                    PrintVerticalSumInBinaryTree(binaryTreeNode.GetRight(),
                        doublyLinkedListNode.GetNextNode());
                }
            }
        }
    }
}
