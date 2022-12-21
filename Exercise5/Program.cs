using System;

namespace Exercise5
{
    class Queue
    {
        class Node
        {
            public string info;
            public Node next;
            public string nama;
            public Node(string i, Node n)
            {
                nama = i;
                next = n;
            }
        }

        Node fahma;
        Node rosyidah;
        public Queue()
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

        public void input(string elemnts)
        {
            Node baru;
            baru = new Node(elemnts, null);
            if (fahma == null)
            {
                fahma = baru;
                rosyidah = baru;
            }
            else
            {
                rosyidah.next = baru;
                rosyidah = rosyidah.next;
            }

            Console.WriteLine("\n" + elemnts + " ditambahkan.");
        }

        public void deleting()
        {
            Console.WriteLine("\nThe popped emenet is: " + fahma.nama);
            fahma = fahma.next;
        }

        public void display()
        {
            Node tmp;
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
            Queue s = new Queue();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Implement insert operation");
                Console.WriteLine("2. Implement delete operation");
                Console.WriteLine("3. Display values");
                Console.WriteLine("4. Exit");
                Console.Write("\npilihan: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nTulis sebuah Nama: ");
                        string num = Console.ReadLine();
                        s.input(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nIsi kosong");
                            break;
                        }
                        s.deleting();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nSalah Pilih");
                        break;
                }
            }
        }
    }
}
