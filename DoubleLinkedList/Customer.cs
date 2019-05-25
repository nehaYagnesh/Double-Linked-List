using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    class Customer
    {
        public string firstName;
        public string lastName;
        public DateTime dob;
        public Customer Previous;
        public Customer Next;

        public int Age()
        {
            return (DateTime.Now - dob).Days/365;
        }

    }
}
