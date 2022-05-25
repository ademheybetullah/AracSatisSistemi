using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class YoneticiForm : Form
    {
        public YoneticiForm()
        {
            InitializeComponent();
        }
        Yonetici aktifYonetici;
        private void btnDonanimEkle_Click(object sender, EventArgs e)
        {
            Donanim yeniDoananim = new Donanim
            {
                DonanimIsmi = txtEklenecekDonanim.Text
            };
            aktifYonetici.DonanimEkle(yeniDoananim);
            txtEklenecekDonanim.Text = "";
            DonanimListele();
        }
        public void DonanimListele()
        {
            lBoxTumDonanimlar.Items.Clear();
            foreach (var item in Yonetim.YonetimOlustur().TumDonanimlar)
            {
                lBoxTumDonanimlar.Items.Add(item.DonanimIsmi);
            }
        }
      
        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            aktifYonetici = Form1.girisYapanYonetici;
            DonanimListele();
            OnayBekleyenleriListele(Yonetim.YonetimOlustur().Ilanlar);
        }
        public void OnayBekleyenleriListele(List<Ilan> _ilan)
        {
            OnayBekleyenIlanlarListView.Items.Clear();
            foreach (var item in _ilan)
            {
                if (!item.IlanYayinlandi)
                {
                    string[] row = { item.IlanId.ToString(), item.IlandakiArac.Marka, item.IlandakiArac.Model, item.IlandakiArac.Fiyat.ToString(), item.IlandakiArac.Kilometre.ToString() };
                    var satir = new ListViewItem(row);
                    satir.Selected = true;
                    OnayBekleyenIlanlarListView.Items.Add(satir);
                }
            }
        }

        private void btnIlanOnayla_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            List<Ilan> karsilastiricak = new List<Ilan>();
            foreach (ListViewItem item in OnayBekleyenIlanlarListView.CheckedItems)
            {
                ids.Add(Convert.ToInt32(item.Text));
            }
            foreach (var item in ids)
            {
                aktifYonetici.IlanOnayla(Yonetim.YonetimOlustur().Ilanlar.Find(x => x.IlanId == item));
            }
            OnayBekleyenleriListele(Yonetim.YonetimOlustur().Ilanlar);
        }
    }
}
