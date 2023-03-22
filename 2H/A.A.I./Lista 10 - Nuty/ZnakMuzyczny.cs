using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10___Nuty
{
    internal class ZnakMuzyczny
    {
        public TypZnaku typZnaku;
        public DlugoscZnaku dlugoscZnaku;
        public KodNuty kodNuty;

        public ZnakMuzyczny(TypZnaku typZnaku, DlugoscZnaku dlugoscZnaku, KodNuty kodNuty)
        {
            this.typZnaku = typZnaku;
            this.dlugoscZnaku = dlugoscZnaku;
            this.kodNuty = kodNuty;
        }
    }
}
