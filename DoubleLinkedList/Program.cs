using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main()
        {
            Customer Yag = new Customer()
            {
                firstName = "Yag",
                lastName = "Parekh",
                dob = new DateTime(1988, 4, 7),
                Previous = null //not necessary since it will be null 
            };
           
            Customer Yan = new Customer() { 
                firstName = "Yan",
                lastName = "Parekh",
                dob = new DateTime(1994, 07, 20),
            };
            Yag.Next = Yan;
            Yan.Previous = Yag;
           
            Customer Niya = new Customer()
            {
                firstName = "Niya",
                lastName = "Limbachiya",
                dob = new DateTime(1995, 07, 20),
            };
            Yan.Next = Niya;
            Niya.Previous = Yan;
            Niya.Next = null;

            Customer start = new Customer();
            start = Yag;
            //Print customers
            while (start!= null)
            {
               Console.WriteLine($"{start.firstName} {start.lastName} {start.Age()}");
                start = start.Next;
            }

            //Print reverse
            Customer tail = new Customer();
            tail = Niya;
            while (tail != null)
            {
                Console.WriteLine($"{tail.firstName} {tail.lastName} {tail.Age()}");
                tail = tail.Previous;
            }
        }
    }
}
