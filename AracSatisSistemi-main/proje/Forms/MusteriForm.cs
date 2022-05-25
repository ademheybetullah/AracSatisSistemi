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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        Musteri musteri;
        Ilan ayrinti;
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            musteri = Form1.girisYapanMusteri;
            AraclariListele(musteri.IlanGoruntule());
            
        }
        public void AraclariListele(List<Ilan> _ilan)
        {
            IlanlarListView.Items.Clear();
            foreach (var item in _ilan)
            {
                if (item.IlanYayinlandi)
                {
                    string[] row = { item.IlanId.ToString(), item.IlandakiArac.Marka, item.IlandakiArac.Model, item.IlandakiArac.Fiyat.ToString(), item.IlandakiArac.Kilometre.ToString() };
                    var satir = new ListViewItem(row);
                    satir.Selected = true;
                    IlanlarListView.Items.Add(satir);
                }
            }
            
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            List<Ilan> ilanlar = musteri.IlanFiltrele(Convert.ToInt32(txtMinFiyat.Text));
            AraclariListele(ilanlar);
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            List<Ilan> karsilastiricak = new List<Ilan>();
            foreach (ListViewItem item in IlanlarListView.CheckedItems)
            {
                ids.Add(Convert.ToInt32(item.Text));
            }
            foreach (var item in ids)
            {
                karsilastiricak.Add(Yonetim.YonetimOlustur().Ilanlar.Find(x => x.IlanId == item));
            }
            AraclariListele(musteri.IlanKarsilastir(karsilastiricak));
        }

        private void btnIlanAyrintisi_Click(object sender, EventArgs e)
        {
            if (IlanlarListView.CheckedItems.Count == 1)
            {
                int id = Convert.ToInt32(IlanlarListView.CheckedItems[0].Text);
                ayrinti = Yonetim.YonetimOlustur().Ilanlar.Find(x => x.IlanId == id);
                txtAracFiyat.Text = ayrinti.IlandakiArac.Fiyat.ToString();
                txtAracKm.Text = ayrinti.IlandakiArac.Kilometre.ToString();
                txtAracMarka.Text = ayrinti.IlandakiArac.Marka.ToString();
                txtAracModel.Text = ayrinti.IlandakiArac.Model.ToString();
                txtAracMotor.Text = ayrinti.IlandakiArac.Motor.ToString();
                txtAracTuru.Text = ayrinti.IlandakiArac.AracTuru.ToString();
                txtAracUretimYili.Text = ayrinti.IlandakiArac.UretimYili.ToString();
                txtSanziman.Text = ayrinti.IlandakiArac.Sanziman.ToString();
                txtYakitTuru.Text = ayrinti.IlandakiArac.YakitTuru.ToString();
                lboxAyrintiDonanimlar.Items.Clear();
                foreach (var item in ayrinti.IlandakiArac.AracDonanimlari)
                {
                    lboxAyrintiDonanimlar.Items.Add(item.DonanimIsmi);
                }
                btnYorumYap.Visible = true;
            }
            else
            {
                btnYorumYap.Visible = true;
                MessageBox.Show("Ilan ayrıntısını görmek için yalnızca bir tane ilan seçiniz");
            }
            
        }

        private void btnYorumEkle_Click(object sender, EventArgs e)
        {
            Yorum yorum = new Yorum();
            yorum.YorumMetni = txtYorumMetni.Text;
            yorum.YorumYapan = musteri;
            musteri.YorumEkle((AracSahibi)ayrinti.IlanSahibi, yorum);
            araclarPage.Show();
            YorumPage.Hide();
        }

        private void btnYorumYap_Click(object sender, EventArgs e)
        {
            
            if (ayrinti != null)
            {
                txtAracSahibiAdi.Text = ayrinti.IlanSahibi.Isim;
                txtIlanId.Text = ayrinti.IlanId.ToString();
                araclarPage.Hide();
                YorumPage.Show();
            }
            else
            {
                MessageBox.Show("Yorum yapılacak ilanı seçiniz");
            }
            
                

        }
    }
}
