using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9D1
{
    internal class Telefon : Elektronik
    {
        public decimal EkMasraf { get; set; }

        public Telefon(decimal ekMasraf, decimal alisfiyatı, decimal karyuzdesi)
        {

            EkMasraf = ekMasraf;
            AlisFiyatı = alisfiyatı;
            KarYuzdesi = karyuzdesi;

        }

        public override decimal FiyatHesapla()
        {
            return 2 * (AlisFiyatı / KarYuzdesi) + EkMasraf;
        }
    }
}
