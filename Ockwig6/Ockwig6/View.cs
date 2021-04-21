using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableNS
{
    public static class View
    {
        public static void ViewHT(HashTable HT)
        {
            Console.WriteLine("Stored        Hashed        Keyword        Probes        Matched");
            for(int i = 0; i<HT.Table.Length;i++)
            {

                Console.WriteLine(i + "            " + HT.Table[i].Hashed +"              "+HT.Table[i].Keyword + "     " + HT.Table[i].Probes);
            }

            return;

        }
    }
}
