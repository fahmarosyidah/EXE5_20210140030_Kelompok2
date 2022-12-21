using System;

namespace Exercise5
{
    class Node
    {
        public int info;
        public Node next;

        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Queues
    {
        Node fahma, rosyidah;

        public Queues()
        {
            fahma = null;
            rosyidah = null;
        }


        public void insert(int element)
        {
            Node nb;
            nb = new Node(element, null);
            nb.next = null;

            if (fahma == null)
            {
                fahma = nb;
                rosyidah = nb;
                return;
            }

            rosyidah.next = nb;
            rosyidah = nb;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
