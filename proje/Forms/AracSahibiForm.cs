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
    public partial class AracSahibiForm : Form
    {
        public AracSahibiForm()
        {
            InitializeComponent();

        }
        AracSahibi aktifAracSahibi;

        private void AracSahibiForm_Load(object sender, EventArgs e)
        {
            aktifAracSahibi = Form1.girisYapanAracSahibi;
            DonanimlariListele();
            IlanlariListele(aktifAracSahibi.Ilanlar);
        }
        private void btnIlanEkle_Click(object sender, EventArgs e)
        {
            IlanEkle();
        }
        public void DonanimlariListele()
        {
            checkedDonanimlar.Items.Clear();
            foreach (var item in Yonetim.YonetimOlustur().TumDonanimlar)
            {
                checkedDonanimlar.Items.Add(item.DonanimIsmi);
            }
        }
        public void IlanEkle()
        {


            Arac ilanAraci = new Arac
            {
                Marka = txtAracMarka.Text,
                Model = txtAracModel.Text,
                UretimYili = dPickerUretimYili.Value,
                Motor = txtAracMotor.Text,
                Fiyat = Convert.ToInt32(txtAracFiyat.Text),
                Kilometre = Convert.ToInt32(txtAracKm.Text),
                Sanziman = txtSanziman.Text,
                AracTuru = cBoxAracTuru.SelectedItem.ToString(),
                YakitTuru = cBoxYakitTuru.SelectedItem.ToString()

            };
            foreach (var item in checkedDonanimlar.CheckedItems)
            {
                ilanAraci.AracDonanimlari.Add(Yonetim.YonetimOlustur().TumDonanimlar.Find(x => x.DonanimIsmi.Contains(item.ToString())));
            }

            Ilan yeniIlan = new Ilan
            {
                IlandakiArac = ilanAraci,
                IlanId = Yonetim.YonetimOlustur().Ilanlar.Count,
                IlanSahibi = aktifAracSahibi,
                IlanYayinlandi = false
            };
            yeniIlan.IlanSahibi = aktifAracSahibi;
            aktifAracSahibi.IlanEkle(yeniIlan);
        }


        public void IlanlariListele(List<Ilan> _ilan)
        {
            IlanDuzenleListView.Items.Clear();
            if (_ilan != null)
            {
                foreach (var item in _ilan)
                {
                    string[] row = { item.IlanId.ToString(), item.IlandakiArac.Marka, item.IlandakiArac.Model, item.IlandakiArac.Fiyat.ToString(), item.IlandakiArac.Kilometre.ToString() };
                    var satir = new ListViewItem(row);
                    IlanDuzenleListView.Items.Add(satir);
                }
            }
            
        }

        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            List<Ilan> karsilastiricak = new List<Ilan>();
            foreach (ListViewItem item in IlanDuzenleListView.CheckedItems)
            {
                ids.Add(Convert.ToInt32(item.Text));
            }
            foreach (var item in ids)
            {
                aktifAracSahibi.IlanSil(Yonetim.YonetimOlustur().Ilanlar.Find(x => x.IlanId == item));
            }
            IlanlariListele(aktifAracSahibi.Ilanlar);
        }

        private void btnIlanDuzenle_Click(object sender, EventArgs e)
        {
            if (IlanDuzenleListView.CheckedItems.Count == 1)
            {
                int id = Convert.ToInt32(IlanDuzenleListView.CheckedItems[0].Text);
                aktifAracSahibi.Duzenle(Convert.ToInt32(txtYeniFiyat.Text), Yonetim.YonetimOlustur().Ilanlar.Find(x => x.IlanId == id));
                aktifAracSahibi.Duzenle(Convert.ToInt32(txtYeniFiyat.Text), aktifAracSahibi.Ilanlar.Find(x => x.IlanId == id));
                IlanlariListele(aktifAracSahibi.Ilanlar);
            }
        }
    }
}
