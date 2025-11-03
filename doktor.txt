using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaneyönetimsistemi
{
    internal class doktor
    {
        public string doktorad;
        public string doktorsoyad;

        public doktor()
        {
        }

        public doktor(string doktor_ad, string doktor_soyad)
        {
            doktor_ad = doktorad;
            doktor_soyad = doktorsoyad;
        }
        string doktor_ad
        {
            set { doktor_ad = value; }
            get { return doktor_ad; }
        }
        string doktor_soyad
        {
            set { doktor_soyad = value; }
            get { return doktor_soyad; }
        }
    }
}
