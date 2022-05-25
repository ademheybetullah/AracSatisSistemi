using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public class MySQL : VeriTabani
    {
        public override void Ekle()
        {
            MessageBox.Show("MySQL veritabanına ekleniyor");
        }

        public override void Guncelle()
        {
            MessageBox.Show("MySQL veritabanında güncelleniyor");
        }

        public override void Sil()
        {
            MessageBox.Show("MySQL veritabanından siliniyor");
        }
    }
}
