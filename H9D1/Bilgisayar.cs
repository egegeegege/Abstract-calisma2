using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9D1
{
    internal class Bilgisayar : Elektronik
    {

        public Bilgisayar(decimal alisfiyatı, decimal karyuzdesi)
        {
            AlisFiyatı = alisfiyatı;
            KarYuzdesi = karyuzdesi;
        }

        public override decimal FiyatHesapla()
        {
            return 2 * (AlisFiyatı / KarYuzdesi);
        }
    }
}
