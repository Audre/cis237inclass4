using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class MyLinkedList
    {
        // Node that will 'point' to the current node we are looking at.
        public Node Current
        {
            get;
            set;
        }

        // Node that will 'point' to the the beginning of the linked list.
        public Node Head
        {
            get;
            set;
        }

        // Node that will 'point' to the last node in the linked list. 
        public Node Tail
        {
            get;
            set;
        }

        // Constructor. Just initialize the properties to null.
        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Current = null;
        }

        // This will be the add method to add a new ndoe to the linked list. 
        public void Add(string content)
        {
            // Make a new node.
            Node node = new Node();

            // Set the data for the node to the content that was passed in. 
            node.Data = content;

            // If Head is null, that means that there are no nodes in the linked list.
            // We are about to add the first node.
            if (Head == null)
            {
                Head = node;
                // This next line got moved below the if/else so it is no longer needed.
                // Tail = node;
            }

            // This is the case where there is already at least 1 node in the linked list. Maybe many. 
            else
            {
                // Take the Tail node, which is the last one in the list, and set its Next property
                // which was null, to the new node we just created. 
                Tail.Next = node;

                // This is a valid replacement for Tail = node; but might be harder to understand. 
                // Tail = Tail.Next;
                // This next line got moved below the if/else
                // Tail = node;
            }
            // This was duplicated in both the if and the else, so we moved it down here since it must be
            // done for both of them. 
            Tail = node;
        }
    }
}
