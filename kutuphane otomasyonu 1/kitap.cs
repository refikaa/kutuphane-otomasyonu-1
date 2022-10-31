using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyonu_1
{
    public class kitap
    {
        public string Ad;
        public string Yazar;
        public kitap(string ad, string yazar)
        {
            Ad = ad;
            Yazar = yazar;
        }
        public override string ToString()
        {
            return Ad +"("+Yazar+")";
        }
    }
}
