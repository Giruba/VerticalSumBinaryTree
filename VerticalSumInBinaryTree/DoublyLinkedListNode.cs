using System;
using System.Collections.Generic;
using System.Text;

namespace VerticalSumInBinaryTree
{
    class DoublyLinkedListNode
    {
        int data;
        DoublyLinkedListNode previous;
        DoublyLinkedListNode next;

        public DoublyLinkedListNode() { }

        public DoublyLinkedListNode(int data) {
            this.data = data;
        }

        public DoublyLinkedListNode GetPreviousNode() {
            return previous;
        }

        public DoublyLinkedListNode GetNextNode() {
            return next;
        }

        public void SetDoublyLinkedListNodeData(int data) {
            this.data = data;
        }

        public int GetDoublyLinkedListNodeData() {
            return this.data;
        }

        public void SetPreviousNode(DoublyLinkedListNode doublyLinkedListNode) {
            previous = doublyLinkedListNode;
        }

        public void SetNextNode(DoublyLinkedListNode doublyLinkedListNode) {
            next = doublyLinkedListNode;
        }
    }
}
