using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HashTableNS
{
    public class HashTable
    {

        public Node[] Table;
        public HashTable(int size = 101)
        {
            Table = new Node[101];
            Initialize();
            PopulateHT();

        }

        private HashTable(Node[] T)
        {
            Table = T;
        }

        public void Search(string s)
        {
            

            return;
        }  
        public int Hash(string s)
        {
            int hash = 0;
            byte[] bytes = Encoding.ASCII.GetBytes(s);

            foreach(byte b in bytes)
            {
                hash += b;
            }
            hash = (hash << 8) % 101;
            return hash;
        }
        public void Initialize()
        {
            for (int i = 0; i < Table.Length; i++)
            {
                Table[i] = new Node();
            }
            Console.WriteLine(Table.Length);
            return;
        }
        public void PopulateHT()
        {
            int hash_location=0;
            int count;


            using (StreamReader sr = File.OpenText("kwcsharp.txt"))
            {
                string input = null;
                bool b = false;
                while ((input = sr.ReadLine()) != null)
                {
                    count = 0;
                    Console.WriteLine(input);
                    
                    do
                    {
                        hash_location = Hash(input) + count;
                        if(Table[hash_location].Hashed != -1)
                        {
                            count++;
                        }
                        else
                        {
                            b = true;
                        }

                    } while (!b);
                  
                        Table[hash_location].Keyword = input;
                        Table[hash_location].Hashed = hash_location;

                }
                return;
            }
        }
    }

}
