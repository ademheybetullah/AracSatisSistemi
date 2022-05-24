using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public class Musteri : Kisi, IKayit,IIlanGoruntule,IIlanKarsilastir,IIlanFiltrele,IYorumEkle
    {
        


        public List<Ilan> IlanGoruntule()
        {
            return Yonetim.YonetimOlustur().Ilanlar;
        }

        public List<Ilan> IlanKarsilastir(List<Ilan> ilanlar)
        {
            List<Ilan> KarsilastirilanIlanlar = new List<Ilan>();
            KarsilastirilanIlanlar.AddRange(ilanlar);
            return KarsilastirilanIlanlar;
        }

        public bool KayitOl()
        {
            try
            {
                if (Yonetim.YonetimOlustur().Musteriler == null)
                    Yonetim.YonetimOlustur().Musteriler = new List<Musteri>();
                Yonetim.YonetimOlustur().Musteriler.Add(this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool YorumEkle(AracSahibi aracSahibi, Yorum yorum)
        {
            try
            {
                if (aracSahibi.Yorumlar == null)
                    aracSahibi.Yorumlar = new List<Yorum>();
                aracSahibi.Yorumlar.Add(yorum);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Ilan> IlanFiltrele(int minFiyat)
        {
            List<Ilan> istenenIlanlar = new List<Ilan>();
            foreach (var item in Yonetim.YonetimOlustur().Ilanlar)
            {
                if (item.IlandakiArac.Fiyat <= minFiyat)
                    istenenIlanlar.Add(item);
            }
            return istenenIlanlar;
        }

        
    }
}
