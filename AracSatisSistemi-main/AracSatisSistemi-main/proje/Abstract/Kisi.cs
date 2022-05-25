using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public abstract class Kisi
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public int Id { get; set; }
        public virtual Kisi GirisYap<T>(List<T> list, string eposta, string sifre) where T : Kisi
        {
            foreach (var item in list)
            {
                if (eposta == item.Eposta && sifre == item.Sifre)
                {
                    return item;
                }
                    
            }
            
            return null;
        }
    }
}
