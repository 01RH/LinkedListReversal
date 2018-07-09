using System;

namespace LinkedListReversal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test One");
            Console.WriteLine("Create LinkedList of 1, 2, 3");
            LinkedList linkedList = new LinkedList(new int[] { 1, 2, 3 });
            Console.WriteLine("The values are : {0}", linkedList.DisplayLinkedList());
            LinkedList reversedLinkedList = linkedList.Reverse();
            Console.WriteLine("Reversed Result is : {0}", reversedLinkedList.DisplayLinkedList());

            Console.WriteLine(System.Environment.NewLine);

            Console.WriteLine("Test Test");
            Console.WriteLine("Create LinkedList of 44, 47, 84, 89, 104");
            linkedList = new LinkedList(new int[] { 44, 47, 84, 89, 104 });
            Console.WriteLine("The values are : {0}", linkedList.DisplayLinkedList());
            reversedLinkedList = linkedList.Reverse();
            Console.WriteLine("Reversed Result is : {0}", reversedLinkedList.DisplayLinkedList());
        }
    }
}
