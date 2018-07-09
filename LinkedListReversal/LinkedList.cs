using System;
using System.Text;

namespace LinkedListReversal
{
    public class LinkedList
    {
        private Node head, tail;

        public LinkedList()
        {
            head = tail = null;
        }

        public LinkedList(int[] array)
        {
            foreach(int item in array)
            {
                Add(new Node(item));
            }
        }

        public void Add(Node newNode)
        {
            if (head == null)
            {
                // begin the linkedlist
                head = tail = newNode;
            }
            else
            {
                // set the next pointer on the tail to the new node and set the tail to the new node
                tail.next = newNode;
                tail = newNode;
            } 
        }

        public string DisplayLinkedList()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (head == null)
                return "This LinkedList is empty";

            Node currentVal = head;
            stringBuilder.Append(currentVal.val);
            while(currentVal.next != null)
            {
                if (stringBuilder.Length > 0)
                    stringBuilder.Append(",");
                currentVal = currentVal.next;
                stringBuilder.Append(currentVal.val);
            }

            return stringBuilder.ToString();
        }

        public LinkedList Reverse()
        {
            // Wrapped in this method to allow to encapsulate RecursiveReverse in the LinkedList Class
            return RecursiveReverse(head);
        }

        private LinkedList RecursiveReverse(Node node)
        {
            if (node.next != null)
            {
                LinkedList temp = RecursiveReverse(node.next);
                temp.Add(new Node(node.val));
                return temp;
            }
            else 
                return new LinkedList(new int[] {node.val});
            
        }
    }
}
