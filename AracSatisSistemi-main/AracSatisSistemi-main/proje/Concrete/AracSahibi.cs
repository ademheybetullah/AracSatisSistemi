using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public class AracSahibi : Kisi, IIlanDuzenle,IIlanEkle,IIlanSil,IKayit
    {
        public void Duzenle(int fiyat, Ilan ilan)
        {
            ilan.IlandakiArac.Fiyat = fiyat;
        }


        public bool IlanEkle(Ilan ilan)
        {
            try
            {
                ilan.IlanSahibi = this;
                if (this.Ilanlar == null)
                    Ilanlar = new List<Ilan>();
                if (Yonetim.YonetimOlustur().Ilanlar == null)
                    Yonetim.YonetimOlustur().Ilanlar = new List<Ilan>();
                Yonetim.YonetimOlustur().Ilanlar.Add(ilan);
                this.Ilanlar.Add(ilan);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool IlanSil(Ilan ilan)
        {
            try
            {
                Yonetim.YonetimOlustur().Ilanlar.Remove(ilan);
                this.Ilanlar.Remove(ilan);
                return true;
            }
            catch (Exception)
            {
                return false;
            }   
        }

        public bool KayitOl()
        {
            try
            {
                if (Yonetim.YonetimOlustur().AracSahipleri == null)
                    Yonetim.YonetimOlustur().AracSahipleri = new List<AracSahibi>();
                Yonetim.YonetimOlustur().AracSahipleri.Add(this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public List<Ilan> Ilanlar { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public List<Arac> Araclar { get; set; }
        
    }
}
