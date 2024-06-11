using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon = new Telefon(100, 5000, 10);
            Console.WriteLine(telefon.FiyatHesapla());

            Bilgisayar bilgisayar = new Bilgisayar(3000, 10);
            Console.WriteLine(bilgisayar.FiyatHesapla());

            Console.ReadLine();
        }
    }
}
