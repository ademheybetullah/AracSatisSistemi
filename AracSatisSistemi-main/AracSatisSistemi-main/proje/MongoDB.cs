using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public class MongoDB : VeriTabani
    {
        public override void Ekle()
        {
            MessageBox.Show("MongoDB veritabanına ekleniyor");
        }

        public override void Guncelle()
        {
            MessageBox.Show("MongoDB veritabanında güncelleniyor");
        }

        public override void Oku()
        {
            MessageBox.Show("MongoDB veritabanından okuuyor");
        }

        public override void Sil()
        {
            MessageBox.Show("MongoDB veritabanından siliniyor");
        }
    }
}
