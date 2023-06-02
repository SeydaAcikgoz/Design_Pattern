using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern2
{
    public partial class Musteri//partial:sınıfları bölüp başka yerde kullanmayı sağlar
    {
        public class Builder//inner class
        {
            public string adi, soyadi;
            public int yas;
            public decimal maas;

            //  public Builder() { }

            public Builder(String adi, String soyadi)
            {
                AdEkle(adi);
                SoyadEkle(soyadi);
            }

            public Builder AdEkle(String adi)
            {
                this.adi = adi;
                return this;//gönderilen nesneye yükleme yapıp geri döndürdü
            }

            public Builder SoyadEkle(String soyadi)
            {
                this.soyadi = soyadi;
                return this;
            }

            public Builder YasEkle(int yas)
            {
                this.yas = yas;
                return this;
            }

            public Builder MaasEkle(decimal maas)
            {
                this.maas = maas;
                return this;
            }

            public Musteri Build()
            {
                return new Musteri(this);//builder ı musteriye çevir
            }

        }
    }
}
