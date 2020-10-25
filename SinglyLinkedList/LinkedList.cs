using System;

namespace DataStructures
{
    public class LinkedList
    {
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                data = nodeData;
                next = null;
            }
        }

        public class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                head = null;
                tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (head == null)
                    head = node;
                else
                    tail.next = node;

                tail = node;
            }
        }

        // Given a pointer to the head node of a linked list, print each node's  element, one per line. 
        // If the head pointer is null (indicating the list is empty), there is nothing to print.

        public static void PrintLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        // Create a new node with the given integer. Insert this node at the tail of the linked list
        // and return the head node of the linked list formed after inserting this new node. 
        // The given head pointer may be null, meaning that the initial list is empty.
        public static SinglyLinkedListNode InsertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            if (head == null)
                head = newNode;
            else
            {
                var currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                //reached the tail
                currentNode.next = newNode;
            }
            return head;
        }
        
        // Given a pointer to the head of a linked list, insert a new node before the head.
        // The  value in the new node should point to  and the  value should be replaced with a given value.Return a reference to the new head of the list.
        // The head pointer given may be null meaning that the initial list is empty.
        public static SinglyLinkedListNode InsertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            if (llist != null)
                newNode.next = llist;
            return newNode;
        }

        // Given the pointer to the head node of a linked list and an integer to insert at a certain position
        // , create a new node with the given integer as its attribute, 
        // insert this node at the desired position and return the head node.

        public static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            if (head == null)
            {
                // create a new node                
                newNode.next = null;
                head = newNode;
                return head;
            }
            else
            {
                if (position == 0)
                {
                    newNode.next = head;
                    head = newNode;
                    return head;
                }

                SinglyLinkedListNode currentNode = head;
                for (int i = 0; i < position - 1; i++)
                {
                    if (currentNode.next != null)
                        currentNode = currentNode.next;
                    else
                        break;
                }
                newNode.next = currentNode.next;
                currentNode.next = newNode;
            }

            return head;
        }

        // Delete the node at a given position in a linked list and return a reference to the head node. 
        // The head is at position 0. The list may be empty after you delete the node. In that case, return a null value.
        public static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int position)
        {
            if (head != null)
            {
                if (position == 0)
                {
                    head = head.next;
                    return head;
                }

                SinglyLinkedListNode currentNode = head;
                for (int i = 0; i < position - 1; i++)
                {
                    if (currentNode.next != null)
                        currentNode = currentNode.next;
                    else
                        break;
                }

                currentNode.next = currentNode.next.next;
            }

            return head;
        }

        // Given a pointer to the head of a singly-linked list, print each  value from the reversed list. 
        // If the given list is empty, do not print anything.
        public static void ReversePrint(SinglyLinkedListNode head)
        {
            if (head != null)
            {
                ReversePrint(head.next);
                Console.WriteLine(head.data);
            }
        }

        // Given the pointer to the head node of a linked list, change the next pointers of the nodes so that their order is reversed. 
        // The head pointer given may be null meaning that the initial list is empty.
        public static SinglyLinkedListNode ReverseOption1(SinglyLinkedListNode head)
        {
            // no node or only one node
            if (head == null || head.next == null)
                return head;

            SinglyLinkedListNode current = head;
            SinglyLinkedListNode prev = null;
            SinglyLinkedListNode next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        public static SinglyLinkedListNode ReverseOption2(SinglyLinkedListNode head)
        {
            // no node or only one node
            if (head == null || head.next == null)
                return head;

            SinglyLinkedListNode remaining = ReverseOption2(head.next);
            head.next.next = head;
            head.next = null;

            return remaining;
        }

        // Given pointers to the heads of two sorted linked lists, merge them into a single, sorted linked list.
        // Either head pointer may be null meaning that the corresponding list is empty.
        public static SinglyLinkedListNode MergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            if (head1 == null && head2 == null) return null;
            if (head2 == null) return head1;
            if (head1 == null) return head2;

            SinglyLinkedListNode mergedNode;
            if (head1.data < head2.data)
            {
                head1.next = MergeLists(head1.next, head2);
                mergedNode = head1;
            }
            else
            {
                head1.next = MergeLists(head1, head2.next);
                mergedNode = head2;
            }
            return mergedNode;
        }
    }
}