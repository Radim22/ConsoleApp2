using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Adresa
    {
        public string ulice;
        public int cislo_popisne;
        public string mesto;
        public string stat;

        public string adresanajedenradek()
        {
            return ulice + " " + cislo_popisne + ", " + mesto + ", " + stat;

        }
}


}