using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedLIst
{
    class LinkedList
    {
        //declare head of a node
         Node head;
        //create a class which is the Node
        public class Node
        {
            public int data;
            public Node next;
            //create this constructor
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        //create this function to print out the linked list
        public void printLinkedList()
        {
            Node n = head;
            while(n!=null) //while the node is not equal to null, then keep printing out values
            {
                Console.WriteLine(n.data + " ");
                n = n.next;
            }
        }

        public static void Main(string[] args)
        {
           
            LinkedList linkedList = new LinkedList(); //create an empty list object node
            linkedList.head = new Node(1); //add this as a new value of the node
            Node second = new Node(8);
            Node third = new Node(3);

            linkedList.head.next = second;
            second.next = third;

            linkedList.printLinkedList();
            Console.ReadKey();
            
            /* linkedlist.head      second      third
             *      |                  |          |
             *      |                  |          |
             *    | 1 |     -->      | 8 | -->  | 3 |
             */
         
        }


    }
}
