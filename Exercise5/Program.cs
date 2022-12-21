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

        bool empty()
        {
            if (fahma == null)
                return (true);
            else
                return (false);
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
                Console.WriteLine("\nantrian kosong");
            else
            {
                for (tmp = fahma; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.nama);
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display value");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("Enter a number: ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;
                        case '2':
                            {
                                q.delete();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered");
                }
            }
        }
    }
}
