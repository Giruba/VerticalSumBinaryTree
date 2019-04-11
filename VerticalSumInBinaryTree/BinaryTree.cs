using System;
using System.Collections.Generic;
using System.Text;

namespace VerticalSumInBinaryTree
{
    class BinaryTree
    {
        BinaryTreeNode root;

        public BinaryTree() { }

        public BinaryTree(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public void SetBinaryTreeRoot(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode GetBinaryTreeRoot() {
            return root;
        }

        public BinaryTreeNode Insert(BinaryTreeNode binaryTreeNode, int data) {
            if (binaryTreeNode == null) {
                binaryTreeNode = new BinaryTreeNode(data);
                return binaryTreeNode;
            }
            if (data < binaryTreeNode.GetBinaryTreeNodeData())
            {
                binaryTreeNode.SetLeft(Insert(binaryTreeNode.GetLeft(), data));
            }
            else {
                binaryTreeNode.SetRight(Insert(binaryTreeNode.GetRight(), data));
            }
            return binaryTreeNode;
        }
    }
}
