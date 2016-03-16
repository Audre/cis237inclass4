using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new linked list
            MyLinkedList myLinkedList = new MyLinkedList();

            // Add a few things to the linked list.
            myLinkedList.Add("first");
            myLinkedList.Add("second");
            myLinkedList.Add("third");
            myLinkedList.Add("fourth");

            // Loop through with this differently looking for loop to output.
            // In here, the first part is initialization: Setting x to the Head
            // The second part is the test: If x != null, keep going.
            // The last part is: Set the current x to x's next pointer. (The next in the list).
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            // Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            // Use the retrieve method to start at the Head of the linked list,
            // walk through it, and return the value that is at the passed in index.
            Console.WriteLine(myLinkedList.Retrieve(2));
            Console.WriteLine(myLinkedList.Retrieve(1));

            // Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            // Do some deletes of the linked lists.
            // This will delete the first one in the list.
            myLinkedList.Delete(0);
            // Now there are 3, and this will delete the middle one.
            myLinkedList.Delete(1);
            // Now ther eare 2, and this will delete the last one.
            myLinkedList.Delete(1);

            // Now there is only 1, and this loop will print it out. 
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }


            // Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            // Make a linked list that keeps track of strings just like the other one we did.
            GenericLinkedList<string> myGenericLinkedList = new GenericLinkedList<string>();

            // Make a linked list that keeps track of ints.
            GenericLinkedList<int> myGenericIntegerLinkedList = new GenericLinkedList<int>();

            // Make a linked list that keeps track of objects. This is probably not a good idea. 
            GenericLinkedList<object> myGenericObjectLinkedList = new GenericLinkedList<object>();


            // Add a few things to the linked list.
            myGenericLinkedList.Add("first");
            myGenericLinkedList.Add("second");
            myGenericLinkedList.Add("third");
            myGenericLinkedList.Add("fourth");

            // Loop through with this differently looking for loop to output.
            // In here, the first part is initialization: Setting x to the Head
            // The second part is the test: If x != null, keep going.
            // The last part is: Set the current x to x's next pointer. (The next in the list).
            for (GenericNode<string> x = myGenericLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            // Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            // Use the retrieve method to start at the Head of the linked list,
            // walk through it, and return the value that is at the passed in index.
            Console.WriteLine(myGenericLinkedList.Retrieve(2));
            Console.WriteLine(myGenericLinkedList.Retrieve(1));

            // Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            // Do some deletes of the linked lists.
            // This will delete the first one in the list.
            myGenericLinkedList.Delete(0);
            // Now there are 3, and this will delete the middle one.
            myGenericLinkedList.Delete(1);
            // Now ther eare 2, and this will delete the last one.
            myGenericLinkedList.Delete(1);

            // Now there is only 1, and this loop will print it out. 
            for (GenericNode<string> x = myGenericLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

        }
    }
}
