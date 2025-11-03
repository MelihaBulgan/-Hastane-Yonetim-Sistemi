using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaneyönetimsistemi
{
    internal class Hasta
    {
        public string hastaad;
        public string hastasoyad;

        public Hasta()
        {
        }

        public Hasta(string hasta_ad, string hasta_soyad)
        {
            hasta_ad = hastaad;
            hasta_soyad = hastasoyad;
        }
        string hasta_ad
        {
            set { hasta_ad = value; }
            get { return hasta_ad; } 
        }
        string hasta_soyad
        {
            set { hasta_soyad = value; }
            get { return hasta_soyad; }
        }
    }
}
