using System;
using System.Collections.Generic;
using System.Text;

namespace VerticalSumInBinaryTree
{
    class BinaryTreeNode
    {
        int data;
        BinaryTreeNode left;
        BinaryTreeNode right;

        public BinaryTreeNode() { }

        public BinaryTreeNode(int data) {
            this.data = data;
        }

        public BinaryTreeNode GetLeft() {
            return left;
        }

        public BinaryTreeNode GetRight() {
            return right;
        }

        public void SetLeft(BinaryTreeNode binaryTreeNode) {
            left = binaryTreeNode;
        }

        public void SetRight(BinaryTreeNode binaryTreeNode) {
            right = binaryTreeNode;
        }

        public void SetBinaryTreeNodeData(int data) {
            this.data = data;
        }

        public int GetBinaryTreeNodeData() {
            return data;
        }
    }
}
