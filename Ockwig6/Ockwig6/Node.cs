using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableNS
{
    public class Node
    {
        public Node(string k = "", int h = -1, int p = 0, int m = 0)
        {
            Keyword = k;
            Hashed  = h;
            Probes  = p;
            Matched = m;
        }
        public Node(Node n)
        {
            Keyword = n.Keyword;
            Hashed  = n.Hashed;
            Probes  = n.Hashed;
            Matched = n.Matched;
        }
        public string Keyword { get; set; }
        public int Hashed     { get; set; }
        public int Probes     { get; set; }
        public int Matched    { get; set; }

    }
}
