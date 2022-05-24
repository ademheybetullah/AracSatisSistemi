using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public class Yonetim
    {
        private static Yonetim _yonetim;
        
        public List<Donanim> TumDonanimlar { get; set; }
        public List<Yonetici> Yoneticiler { get; set; }
        public List<Musteri> Musteriler { get; set; }
        public List<Ilan> Ilanlar { get; set; }
        public List<AracSahibi> AracSahipleri { get; set; }
        private Yonetim()
        {

        }
        public static Yonetim YonetimOlustur()
        {
            if (_yonetim == null)
                _yonetim = new Yonetim();
            return _yonetim;
        }
    }
}
