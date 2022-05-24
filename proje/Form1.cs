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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrnekVerileriOlutur();

        }
        MusteriForm musteriForm = new MusteriForm();
        YoneticiForm yoneticiForm = new YoneticiForm();
        AracSahibiForm aracSahibiForm = new AracSahibiForm();
        Yonetim _yonetim = Yonetim.YonetimOlustur();
        public static Musteri girisYapanMusteri = new Musteri();
        public static Yonetici girisYapanYonetici = new Yonetici();
        public static AracSahibi girisYapanAracSahibi = new AracSahibi();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            MongoDB mongoDB = new MongoDB();
            Ekle(mongoDB);
            Kaydol();
        }
        public void Kaydol()
        {
            if (KayitTuruSecimi() == 1)
            {
                AracSahibi aracSahibi = new AracSahibi
                {
                    Isim = txtIsim.Text,
                    Soyisim = txtSoyisim.Text,
                    Eposta = txtKayitEposta.Text,
                    Sifre = txtKayitSifre.Text
                };
                aracSahibi.Id = Yonetim.YonetimOlustur().AracSahipleri.Count;
                aracSahibi.KayitOl();
                this.Hide();
                aracSahibiForm.ShowDialog();
            }
            else if (KayitTuruSecimi() == 2)
            {
                Musteri musteri = new Musteri
                {
                    Isim = txtIsim.Text,
                    Soyisim = txtSoyisim.Text,
                    Eposta = txtKayitEposta.Text,
                    Sifre = txtKayitSifre.Text
                };
                musteri.Id = Yonetim.YonetimOlustur().Musteriler.Count;
                musteri.KayitOl();
                this.Hide();
                musteriForm.ShowDialog();
            }
        }
        public int KayitTuruSecimi()
        {
            if (cBoxKayitTuru.SelectedIndex == 0)
                return 1;
            else if (cBoxKayitTuru.SelectedIndex == 1)
                return 2;
            else
                MessageBox.Show("Lütfen müşteri türünü seçiniz");
            return 0;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            GirisYap();
        }
        public void Ekle(VeriTabani veriTabani)
        {
            veriTabani.Ekle();
        }
        public void GirisYap()
        {

            if (girisYapanMusteri.GirisYap(_yonetim.Musteriler, txtEposta.Text, txtSifre.Text) != null)
            {
                girisYapanMusteri = (Musteri)girisYapanMusteri.GirisYap(_yonetim.Musteriler, txtEposta.Text, txtSifre.Text);
                musteriForm.Show();
            }
            else if (girisYapanYonetici.GirisYap(_yonetim.Yoneticiler, txtEposta.Text, txtSifre.Text) != null)
            {
                girisYapanYonetici = (Yonetici)girisYapanYonetici.GirisYap(_yonetim.Yoneticiler, txtEposta.Text, txtSifre.Text);
                yoneticiForm.Show();
            }
            else if (girisYapanAracSahibi.GirisYap(_yonetim.AracSahipleri, txtEposta.Text, txtSifre.Text) != null)
            {
                girisYapanAracSahibi = (AracSahibi)girisYapanAracSahibi.GirisYap(_yonetim.AracSahipleri, txtEposta.Text, txtSifre.Text);
                aracSahibiForm.Show();
            }
            else
                MessageBox.Show("Kullanıcı Bulunamadı");

        }
        public void OrnekVerileriOlutur()
        {
            
            Yonetici yonetici = new Yonetici { Isim = "Ahmet", Soyisim = "Demir", Eposta = "Ahmet1234@gmail.com", Sifre = "sifre123", Id = 1 };
            yonetici.KayitOl();
            Musteri musteri1 = new Musteri { Isim = "Ali", Soyisim = "Çelik", Eposta = "Ali1234@gmail.com", Sifre = "sifre123", Id = 0 };
            musteri1.KayitOl();
            Musteri musteri2 = new Musteri { Isim = "Ayşe", Soyisim = "Su", Eposta = "Ayse1234@gmail.com", Sifre = "sifre123", Id = 1 };
            musteri2.KayitOl();
            Musteri musteri3 = new Musteri { Isim = "Mehmet", Soyisim = "Koç", Eposta = "Mehmet1234@gmail.com", Sifre = "sifre123", Id = 2 };
            musteri3.KayitOl();
            AracSahibi aracSahibi1 = new AracSahibi { Isim = "Fatma", Soyisim = "Beyaz", Eposta = "Fatma1234@gmail.com", Sifre = "sifre123", Id = 0 };
            aracSahibi1.KayitOl();
            AracSahibi aracSahibi2 = new AracSahibi { Isim = "Osman", Soyisim = "Siyah", Eposta = "Osman1234@gmail.com", Sifre = "sifre123", Id = 1 };
            aracSahibi2.KayitOl();
            Arac arac = new Arac{AracTuru = "Otomobil",Marka = "Toyota",Model = "Corolla",YakitTuru = "Benzin",Motor = "1.5S",Sanziman = "A250",Kilometre = 25000,Fiyat = 450000,UretimYili = DateTime.Today,AracDonanimlari = new List<Donanim>()};
            Donanim donanim = new Donanim{DonanimIsmi = "Sis Farı"};
            yonetici.DonanimEkle(donanim);
            arac.AracDonanimlari.Add(donanim);
            Ilan yeniIlan = new Ilan{IlandakiArac = arac,IlanSahibi = aracSahibi1,IlanYayinlandi = false,IlanId = 0};
            aracSahibi1.IlanEkle(yeniIlan);
            Arac arac1 = new Arac{AracTuru = "Otomobil",Marka = "BMW",Model = "M4",YakitTuru = "Benzin",Motor = "2.5S",Sanziman = "B15S",Fiyat = 800000,Kilometre = 25000,UretimYili = DateTime.Today,AracDonanimlari = new List<Donanim>()};
            Donanim donanim1 = new Donanim{DonanimIsmi = "Cam Tavan"};
            yonetici.DonanimEkle(donanim1);
            arac1.AracDonanimlari.Add(donanim1);
            Ilan yeniIlan1 = new Ilan{IlandakiArac = arac1,IlanSahibi = aracSahibi1,IlanYayinlandi = false,IlanId = 1};
            aracSahibi1.IlanEkle(yeniIlan1);

        }
    }
}
