using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public class Oracle : VeriTabani
    {
        public override void Ekle()
        {
            MessageBox.Show("Oracle veritabanına ekleniyor");
        }

        public override void Guncelle()
        {
            MessageBox.Show("Oracle veritabanında guncelleniyor");
        }

        public override void Sil()
        {
            MessageBox.Show("Oracle veritabanından siliniyor");
        }
    }
}
