using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Kalitim
    {
     
    }

    public class Yazdir
    {
        public string Yaz(string str, int num)
        {
            return "String: " + str + " Sayı: " + Convert.ToString(num);
        }
    }

    public interface IYazdir
    {
        public string Yaz(string str, int num)
        {
            return "String: " + str + " Sayı: " + Convert.ToString(num);
        }
    }
    public class Cokgen
    {
        protected int genislik;
        protected int yukseklik;

        public void DegerVer(int a,  int b)
        {
            genislik = a;
            yukseklik = b;
        }
    }

    public class Dortgen : Cokgen , IYazdir
    {
        public int Alan()
        {
            return genislik*yukseklik;
        }

        public string Sekil()
        {
            return "Dörtgen";
        }
    }

    public class Ucgen : Cokgen ,IYazdir
    {
        public int Alan()
        {
            return genislik * yukseklik / 2;
        }

        public string Sekil()
        {
            return "Üçgen";
        }
    }
}
