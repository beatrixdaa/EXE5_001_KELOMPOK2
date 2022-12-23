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

        }
            
    }
}
    