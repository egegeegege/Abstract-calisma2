using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9D1
{
    internal abstract class Elektronik
    {
        public decimal AlisFiyatı { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();

    }
}
