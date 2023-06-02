using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern2
{
    public partial class Musteri//partial:sınıfları bölüp başka yerde kullanmayı sağlar
    {
        private string adi, soyadi;
        private int yas;
        private decimal maas;
        public Musteri(Builder builder)
        {
            this.adi = builder.adi;
            this.soyadi = builder.soyadi;
            this.yas = builder.yas;
            this.maas = builder.maas;
        }

        public override string ToString()
        {
            string str = "Adi: " + adi + "\t Soyadi: " + soyadi;

            if (yas != 0)
                str += "\t Yas: " + yas;

            if (maas != 0)
                str += "\t Maas: " + maas;

            return str;
        }
    }
}
