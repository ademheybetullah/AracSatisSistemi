using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public class Arac
    {
        public string AracTuru { get; set; }
        public string Marka { get; set; }
        public DateTime UretimYili { get; set; }
        public string Model { get; set; }
        public string YakitTuru { get; set; }
        public string Motor { get; set; }
        public string Sanziman { get; set; }
        public int Kilometre { get; set; }
        public int Fiyat { get; set; }
        public List<Donanim> AracDonanimlari { get; set; }
        public Arac()
        {
            AracDonanimlari = new List<Donanim>();
        }
    }
}
