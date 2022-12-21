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

        public void delete()
        {
            Node current;

            if(fahma == null)
            {
                Console.WriteLine("Queue empty\n");
                return;
            }
            else
            {
                current = fahma;
                fahma = nb.next;
            }
        }

        public void display()
        {
            int tmp;
            if (empty())
                Console.WriteLine("\nQueue empty");
            else
            {
                for (tmp = fahma; tmp != null)
            }
        }
        
        static void Main(string[] args)
        {
            
        }
    }
}
