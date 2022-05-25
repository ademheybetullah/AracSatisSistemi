using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public class Yonetici : Kisi, IIlanOnayla,IDonanimEkle,IKayit
    {

        public bool DonanimEkle(Donanim donanim)
        {
            try
            {
                if (Yonetim.YonetimOlustur().TumDonanimlar == null)
                    Yonetim.YonetimOlustur().TumDonanimlar = new List<Donanim>();
                Yonetim.YonetimOlustur().TumDonanimlar.Add(donanim);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IlanOnayla(Ilan ilan)
        {
            try
            {
                ilan.IlanYayinlandi = true;
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
                if (Yonetim.YonetimOlustur().Yoneticiler == null)
                    Yonetim.YonetimOlustur().Yoneticiler = new List<Yonetici>();
                Yonetim.YonetimOlustur().Yoneticiler.Add(this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
