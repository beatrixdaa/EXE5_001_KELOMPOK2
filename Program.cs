﻿using System;
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
        }
            
    }
}
    