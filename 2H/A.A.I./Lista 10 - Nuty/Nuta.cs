using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10___Nuty
{
    internal class Nuta
    {
        public int Id;
        public KodNuty KodNuty;
        public int Czestotliwosc;
        public string Font;

        public Nuta(int id, KodNuty kodNuty, int czestotliwosc, string font)
        {
            Id = id;
            KodNuty = kodNuty;
            Czestotliwosc = czestotliwosc;
            Font = font;
        }
    }
}
