using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cokbicimlilik
{
    internal class Cokbicimlilik
    {
    }
        public class Yazdir
        {
            public static string Yaz(Cokgen obj)
            {
                return "Nesnenin Alanı: " + obj.Alan() + "\r\n" + "Nesnenin Şekli: " + obj.Sekil() + "\r\n" + "\r\n";
            }
        }
        public class Cokgen
        {
            protected int genislik;
            protected int yukseklik;

            public void DegerVer(int a, int b)
            {
                genislik = a;
                yukseklik = b;
            }

            public virtual int Alan()
            {
                return 0;
            }

            public virtual string Sekil()
            {
                return null;
            }
        }

        public class Dortgen : Cokgen
        {
            public override int Alan()
            {
                return genislik * yukseklik;
            }

            public override string Sekil()
            {
                return "Dörtgen";
            }
        }

        public class Ucgen : Cokgen
        {
            public override int Alan()
            {
                return genislik * yukseklik / 2;
            }

            public override string Sekil()
            {
                return "Üçgen";
            }
        }
}
