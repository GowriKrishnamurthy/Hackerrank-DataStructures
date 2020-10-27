using System;
using static DataStructures.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            /* *** *** *** LINKED LIST  *** *** *** */
            Console.WriteLine("Select action");
            Console.WriteLine(@"
            1. Printing Linked List
            2. Insert a node at tail 
            3. Insert a node at the head 
            4. Insert a node at a specific position
            5. Delete a node from a specific position
            6. Print linked list in reverse
            7. Merge Sorted lists
            8. Get node at specified poistion from tail
            9. Delete duplicate-value nodes from a sorted linked list
    ");
            int action = Convert.ToInt32(Console.ReadLine());
            int position;
            switch (action)
            {
                case 1:
                    // Printing Linked List
                    var llist9 = new SinglyLinkedList();
                    Console.WriteLine("How many elements ?");
                    int llistCount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llistCount; i++)
                    {
                        int llistItem = Convert.ToInt32(Console.ReadLine());
                        llist9.InsertNode(llistItem);
                    }
                    Console.WriteLine("Printing Linked List");
                    PrintLinkedList(llist9.head);
                    break;
                case 2:
                    // Insert a node at tail 
                    var llist2 = new SinglyLinkedList();
                    Console.WriteLine("How many elements ?");
                    var llistCount2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llistCount2; i++)
                    {
                        int llistItem = Convert.ToInt32(Console.ReadLine());
                        SinglyLinkedListNode llist_head = InsertNodeAtTail(llist2.head, llistItem);
                        llist2.head = llist_head;
                    }
                    Console.WriteLine("Printing Linked List");
                    PrintLinkedList(llist2.head);
                    break;
                case 3:
                    //  Insert a node at head
                    SinglyLinkedList llist3 = new SinglyLinkedList();
                    Console.WriteLine("How many elements ?");
                    var llistCount3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llistCount3; i++)
                    {
                        int llistItem = Convert.ToInt32(Console.ReadLine());
                        SinglyLinkedListNode llist_head = InsertNodeAtHead(llist3.head, llistItem);
                        llist3.head = llist_head;
                    }

                    Console.WriteLine("Printing Linked List");
                    PrintLinkedList(llist3.head);
                    break;
                case 4:
                    // Insert a node at a specific position
                    SinglyLinkedList llist4 = new SinglyLinkedList();

                    Console.WriteLine("How many elements ?");
                    var llistCount4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llistCount4; i++)
                    {
                        int llistItem4 = Convert.ToInt32(Console.ReadLine());
                        llist4.InsertNode(llistItem4);
                    }

                    Console.WriteLine("Enter new data");
                    int data = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter position to add this data at");
                    position = Convert.ToInt32(Console.ReadLine());

                    SinglyLinkedListNode llist_newHead = InsertNodeAtPosition(llist4.head, data, position);

                    Console.WriteLine("Printing Linked List");
                    PrintLinkedList(llist_newHead);
                    break;
                case 5:
                    // Delete a node from a specific position
                    SinglyLinkedList llist5 = new SinglyLinkedList();

                    Console.WriteLine("How many elements ?");
                    int llistCount5 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llistCount5; i++)
                    {
                        int llistItem5 = Convert.ToInt32(Console.ReadLine());
                        llist5.InsertNode(llistItem5);
                    }

                    Console.WriteLine("Enter position to delete data from.");
                    position = Convert.ToInt32(Console.ReadLine());
                    SinglyLinkedListNode llist1 = DeleteNode(llist5.head, position);
                    Console.WriteLine("Printing Linked List");
                    PrintLinkedList(llist1);
                    break;
                case 6:
                    // Print linked list in reverse //
                    SinglyLinkedList llist6 = new SinglyLinkedList();

                    Console.WriteLine("How many elements ?");
                    int llistCount6 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llistCount6; i++)
                    {
                        int llistItem = Convert.ToInt32(Console.ReadLine());
                        llist6.InsertNode(llistItem);
                    }
                    Console.WriteLine("Linked list printed in Reverse");
                    ReversePrint(llist6.head);
                    break;

                /*
                // Print linked list in reverse - Option 1//
                SinglyLinkedList llist7 = new SinglyLinkedList();

                Console.WriteLine("How many elements ?");
                int llistCount7 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the elements");
                for (int i = 0; i < llistCount7; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist7.InsertNode(llistItem);
                }

                Console.WriteLine("Reversed linked list . Option1..");
                PrintLinkedList(ReverseOption1(llist7.head));

                  // Print linked list in reverse - Option 2 //
                    llist9 = new SinglyLinkedList();

                    Console.WriteLine("How many elements ?");
                    llistCount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llistCount; i++)
                    {
                        int llistItem = Convert.ToInt32(Console.ReadLine());
                        llist9.InsertNode(llistItem);
                    }

                    Console.WriteLine("Reversed linked list . Option2..");
                    PrintLinkedList(ReverseOption2(llist9.head));
                */
                case 7:
                    //Merge Sorted lists
                    // int tests = Convert.ToInt32(Console.ReadLine());
                    SinglyLinkedList mergeList1 = new SinglyLinkedList();

                    Console.WriteLine("How many elements in list1 ?");
                    int llist1Count = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llist1Count; i++)
                    {
                        int llist1Item = Convert.ToInt32(Console.ReadLine());
                        mergeList1.InsertNode(llist1Item);
                    }

                    SinglyLinkedList mergeList2 = new SinglyLinkedList();
                    Console.WriteLine("How many elements in list2 ?");
                    int llist2Count = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llist2Count; i++)
                    {
                        int llist2Item = Convert.ToInt32(Console.ReadLine());
                        mergeList2.InsertNode(llist2Item);
                    }

                    SinglyLinkedListNode combinedList = MergeLists(mergeList1.head, mergeList2.head);

                    Console.WriteLine("Combined list elements");
                    PrintLinkedList(combinedList);
                    break;
                case 8:
                    //Get node at specified poistion from tail

                    SinglyLinkedList llist10 = new SinglyLinkedList();
                    Console.WriteLine("How many elements in list?");
                    int llistCount9 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < llistCount9; i++)
                    {
                        int llistItem = Convert.ToInt32(Console.ReadLine());
                        llist10.InsertNode(llistItem);
                    }

                    Console.WriteLine("Enter position of the element to find:");
                    position = Convert.ToInt32(Console.ReadLine());
                    int result = GetNode(llist10.head, position);

                    Console.WriteLine($"Element at position {position} is: {result}");
                    break;
                case 9:
                    // Delete duplicate-value nodes from a sorted linked list
                    SinglyLinkedList listDupl = new SinglyLinkedList();
                    Console.WriteLine("How many elements in list?");
                    int listDuplCount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the elements");
                    for (int i = 0; i < listDuplCount; i++)
                    {
                        int llistItem = Convert.ToInt32(Console.ReadLine());
                        listDupl.InsertNode(llistItem);
                    }
                    SinglyLinkedListNode listDuplicateRemoved = RemoveDuplicates(listDupl.head);

                    Console.WriteLine("Removed duplicates from the list");
                    PrintLinkedList(listDuplicateRemoved);

                    break;
                default:
                    break;
            }

            /* *** *** *** LINKED LIST  *** *** *** */
        }
    }
}