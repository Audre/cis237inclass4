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
        }
    }
}
