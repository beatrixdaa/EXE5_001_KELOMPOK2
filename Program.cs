using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_001
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node BEATRIX, AGSI;
        public queue()
        {
            BEATRIX = null;
            AGSI = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukkan Element :");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (BEATRIX ==null)
            {
                BEATRIX = newnode;
                AGSI = newnode;
            }
        }
        public void delete()
        {
            if( BEATRIX ==null)
            {
                Console.WriteLine("Queue kosong!");
                return;
            }
            BEATRIX = BEATRIX.next;
            if (BEATRIX == null)
                AGSI = null;
        }
        public void display()
        {
            if (BEATRIX ==null)
            {
                Console.WriteLine("Queue tidak ada!");
                return;
            }
            Node display;
            for (display = BEATRIX; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
        class Program
        {
            static void Main(string[] args)
            {
                queue q = new queue();
                char ch;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. insert data");
                        Console.WriteLine("2. delete data");
                        Console.WriteLine("3. display");
                        Console.WriteLine("4. exit");
                        Console.Write("\nMasukkan Pilihan. : ");
                        ch = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        switch (ch)
                        {
                            case '1':
                                q.insert();
                                break;
                            case '2':
                                q.delete();
                                break;
                            case '3':
                                q.display();
                                break;
                            case '4':
                                return;
                            default:
                                Console.WriteLine("Pilihan Salah");
                                break;
                        }
                    }
                    catch (Exception e)
                    { 

                        Console.WriteLine("Check the values");
                    }
                }
            }
        }
    }
}
    