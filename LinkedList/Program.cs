using Helper;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many random strings would you like to generate?");
            string userinput = Console.ReadLine();
            int size;
            int.TryParse(userinput, out size);

            #region Create Linked List

            Console.WriteLine("\n \n---------Creating a random Linked List---------");

            // Maintain the last item in a LinkedList
            LinkedList_String previous = null;

            // Maintain the head position
            LinkedList_String head = null;

            // Generate random strings
            for (int i = 0; i < size; i++)
            {
                string randomString = RandomGenerator.RamdomString(size, false); // Using the size to be the length of the random string that will get generated
                Console.WriteLine("The random string at position " + i + " is " + randomString);
                // Add them into LinkedList
                LinkedList_String node = new LinkedList_String();
                node.Data = randomString;
                // If this is the last node, its next pointer should be null.
                // Also irrespective of where the node is in the order, when created it points to none unless then next node is created
                node.Next = null;

                // Create the head only once, at the beginning
                if (head == null)
                {
                    head = node;
                }

                // Adding this new node to the last known LinkedList item.
                // For the first node in LinkedList, when created, it will point to null
                if (previous == null)
                {
                    previous = node; // For the first time
                }
                else
                {
                    previous.Next = node; // Set this node's address to be the pointer of the previous node to link the nodes
                    // Reset previous to this node
                    previous = node;
                }
            }

            #endregion Create Linked List

            #region Read through the created Linked List and print it

            Console.WriteLine("\n \n---------Travesing through a Linked List---------");

            // Print the head as that allows all navigation from here onwards
            if (head != null)
            {
                Console.Write("The starting position for the linked list is a node with value " + head.Data);
            }

            Console.Write("\nTraversing through a Linked List with a traversal time of O(n)");
            LinkedList_String print = head;
            PrintLinkedList(print);

            #endregion Read through the created Linked List and print it

            #region Adding a new element at a random location within the Linked List

            Console.WriteLine("\n \n---------Add a random new node at a random position within the existing Linked List---------");

            // Getting a random number where the new element will be added
            int positionForNewNode = Helper.RandomGenerator.RandomNumber(0, size);
            Console.WriteLine("\nRandom position where the new node would be inserted is " + positionForNewNode);

            // Generate the random data string for the new position
            string dataForNewNode = Helper.RandomGenerator.RamdomString(size, true);
            Console.WriteLine("\nRandom new string which will be used to create the new randomly inserted node is " + dataForNewNode);

            Console.WriteLine("\nTraversing through all the nodes until we get to a position which is equal to the random new position where we want to add a random new node");
            LinkedList_String currentForAddingLogic = head;
            // Reusing the previous variable. Acts as the previous node in this logic as well
            previous = null;

            // Creating a running count
            int insertionCount = 0; // We start at first position

            while(currentForAddingLogic != null && insertionCount <= positionForNewNode)
            {
                // Checking if the position in existing Linked List matches our random position
                if (insertionCount == positionForNewNode)
                {
                    Console.WriteLine("\nAdding the new random node with value " + dataForNewNode + " here, at position " + positionForNewNode);
                    LinkedList_String newNode = new LinkedList_String();
                    newNode.Data = dataForNewNode;
                    newNode.Next = currentForAddingLogic; // Newly created node is now pointing to the rest of the chain via pointing to current node
                    // Now also point the previous node to the newly created node
                    // Edge Case: When the position for new node is 0
                    if (positionForNewNode == 0)
                    {
                        head = newNode;
                        previous = newNode;
                    }
                    else
                    {
                        previous.Next = newNode;
                    }

                    // Double incrementing in this case as the total count in the LinkedList will increase
                    insertionCount++;
                }

                // Setting the previous node to current & current node to Next
                previous = currentForAddingLogic;
                currentForAddingLogic = currentForAddingLogic.Next;

                // Increament the count
                insertionCount++;
            }

            // Printing the updated LinkedList
            Console.WriteLine("\nPrinting the updated LinkedList along with the new node that was added at " + positionForNewNode);
            PrintLinkedList(head);

            #endregion Adding a new element at a random location within the Linked List

            #region Removing an existing element from the Linked List

            Console.WriteLine("\n \n---------Remove a random node at a random position within the existing Linked List---------");

            // Getting a random number where the new element will be added
            int positionForRandomNodeRemoval = Helper.RandomGenerator.RandomNumber(0, size);
            Console.WriteLine("\nRandom position from where the a node would be removed is " + positionForRandomNodeRemoval);

            // Creating a starting position for removal logic traversal
            LinkedList_String currentForRemovalLogic = head;
            previous = null; // Reusing the existing variable

            // Removal counter
            int removalCounter = 0;

            while (currentForRemovalLogic != null && removalCounter <= positionForRandomNodeRemoval)
            {
                //If the node count for removal matches, then don't point previous to current and skip for once
                if (removalCounter == positionForRandomNodeRemoval)
                {
                    Console.WriteLine("Removing the node at position " + positionForRandomNodeRemoval);

                    // Change the pointer of the previous node from current node to the next node which is saved in current's next
                    // Edge Case: If the node to be removed is the very first node, then head needs to be pointed at current node's next
                    if (positionForRandomNodeRemoval == 0)
                    {
                        head = currentForRemovalLogic.Next;
                    }
                    else // For all other cases, remove the link to current
                    {
                        previous.Next = currentForRemovalLogic.Next;
                    }

                    currentForRemovalLogic = null; // Reset this to null to free up the space/ GC to collect it
                    break;
                }

                previous = currentForRemovalLogic;
                currentForRemovalLogic = currentForRemovalLogic.Next;

                // Incrementing Removal Counter
                removalCounter++;
            }

            // Printing the updated LinkedList
            Console.WriteLine("\nPrinting the updated LinkedList removing the node that was deleted");
            PrintLinkedList(head);

            #endregion Removing an existing element from the Linked List

            #region Reversing a Linked List using Iterative Method

            Console.WriteLine("\n\n----------Reversing a Linked List using Iterative Method----------");

            // Creating a starting position for the reversal operation
            LinkedList_String currentForReversalUsingIterationLogic = head;
            
            // Creating a temp variable for storing the pointer of each current node
            LinkedList_String tempPointer = null;

            previous = null; // Reseting the existing variable to head as we are reversing the linked list

            while (currentForReversalUsingIterationLogic != null)
            {
                // Assigning the value of Next pointer to Temp Pointer
                tempPointer = currentForReversalUsingIterationLogic.Next;

                // Resetting the Next pointer of the current node to previous
                currentForReversalUsingIterationLogic.Next = previous;

                // Setting previous to be current for the next to be able to access it
                previous = currentForReversalUsingIterationLogic;

                // Setting current back to the temp pointer for the loop to continue
                currentForReversalUsingIterationLogic = tempPointer;
            }

            // Lastly change the head to point to last known current node i.e. previous
            head = previous;

            // Printing the updated LinkedList
            Console.WriteLine("\nPrinting the updated LinkedList which has been reversed");
            PrintLinkedList(head);

            #endregion Reversing a Linked List using Iterative Method

            #region Reversing a Linked List using Recursion

            Console.WriteLine("\n\n----------Reversing a Linked List using Recursion----------");

            // Creating a starting position for the reversal operation
            LinkedList_String currentForReversalUsingRecursionLogic = head;
            previous = null;

            ReversalUsingRecursion(previous, head, head.Next);

            // Printing the updated LinkedList
            Console.WriteLine("\nPrinting the updated LinkedList which has been reversed");
            PrintLinkedList(previous);

            #endregion Reversing a Linked List using Recursion

            Console.WriteLine("\n\n\nPress any key to close this window");
            Console.Read();

            #region Functions

            static LinkedList_String ReversalUsingRecursion(LinkedList_String previous, LinkedList_String current, LinkedList_String next)
            {
                // Assigning the value of Next pointer to Temp Pointer
                LinkedList_String tempPointer = current.Next;

                // Resetting the Next pointer of the current node to previous
                current.Next = previous;

                // Setting previous to be current for the next to be able to access it
                previous = current;

                // Setting current back to the temp pointer for the loop to continue
                current = tempPointer;

                if (current != null)
                {
                    ReversalUsingRecursion(previous, current, current.Next);
                }


                return previous;
            }

            static void PrintLinkedList(LinkedList_String print)
            {
                int printCount = 0;

                while (print != null)
                {
                    Console.Write("\n" + printCount + " : " + print.Data);
                    // After printing it, moving to the next node
                    print = print.Next;
                    printCount++;
                }
            }

            #endregion Functions
        }
    }
}
