using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaneyönetimsistemi
{
    internal class hastane
    {
        public string hastanead;
        public string hastaneadres;

        public hastane()
        {
        }

        public hastane(string hastane_ad, string hastane_adres)
        {
            hastane_ad = hastanead;
            hastane_adres = hastaneadres;
        }
        string hastane_ad
        {
            set { hastane_ad = value; }
            get { return hastane_ad; }
        }
        string hastane_adres
        {
            set { hastane_adres = value; }
            get { return hastane_adres; }
        }
    }
}
