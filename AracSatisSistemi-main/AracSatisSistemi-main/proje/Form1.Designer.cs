
namespace proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabGirisKayit = new System.Windows.Forms.TabControl();
            this.girisPage = new System.Windows.Forms.TabPage();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.kayitPage = new System.Windows.Forms.TabPage();
            this.lblKayitTuru = new System.Windows.Forms.Label();
            this.cBoxKayitTuru = new System.Windows.Forms.ComboBox();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.lblSifre_ = new System.Windows.Forms.Label();
            this.txtKayitEposta = new System.Windows.Forms.TextBox();
            this.lblEposta_ = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.tabGirisKayit.SuspendLayout();
            this.girisPage.SuspendLayout();
            this.kayitPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGirisKayit
            // 
            this.tabGirisKayit.Controls.Add(this.girisPage);
            this.tabGirisKayit.Controls.Add(this.kayitPage);
            this.tabGirisKayit.Location = new System.Drawing.Point(2, 0);
            this.tabGirisKayit.Name = "tabGirisKayit";
            this.tabGirisKayit.SelectedIndex = 0;
            this.tabGirisKayit.Size = new System.Drawing.Size(331, 433);
            this.tabGirisKayit.TabIndex = 0;
            // 
            // girisPage
            // 
            this.girisPage.Controls.Add(this.btnGiris);
            this.girisPage.Controls.Add(this.txtSifre);
            this.girisPage.Controls.Add(this.lblSifre);
            this.girisPage.Controls.Add(this.txtEposta);
            this.girisPage.Controls.Add(this.lblEposta);
            this.girisPage.Location = new System.Drawing.Point(4, 25);
            this.girisPage.Name = "girisPage";
            this.girisPage.Padding = new System.Windows.Forms.Padding(3);
            this.girisPage.Size = new System.Drawing.Size(323, 404);
            this.girisPage.TabIndex = 0;
            this.girisPage.Text = "Giriş";
            this.girisPage.UseVisualStyleBackColor = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(72, 122);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(91, 34);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(125, 76);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 3;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(39, 79);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 17);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(125, 30);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 22);
            this.txtEposta.TabIndex = 1;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(39, 33);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(57, 17);
            this.lblEposta.TabIndex = 0;
            this.lblEposta.Text = "E-posta";
            // 
            // kayitPage
            // 
            this.kayitPage.Controls.Add(this.lblKayitTuru);
            this.kayitPage.Controls.Add(this.cBoxKayitTuru);
            this.kayitPage.Controls.Add(this.txtKayitSifre);
            this.kayitPage.Controls.Add(this.lblSifre_);
            this.kayitPage.Controls.Add(this.txtKayitEposta);
            this.kayitPage.Controls.Add(this.lblEposta_);
            this.kayitPage.Controls.Add(this.btnKayit);
            this.kayitPage.Controls.Add(this.txtSoyisim);
            this.kayitPage.Controls.Add(this.lblSoyisim);
            this.kayitPage.Controls.Add(this.txtIsim);
            this.kayitPage.Controls.Add(this.lblIsim);
            this.kayitPage.Location = new System.Drawing.Point(4, 25);
            this.kayitPage.Name = "kayitPage";
            this.kayitPage.Padding = new System.Windows.Forms.Padding(3);
            this.kayitPage.Size = new System.Drawing.Size(323, 404);
            this.kayitPage.TabIndex = 1;
            this.kayitPage.Text = "Kayıt";
            this.kayitPage.UseVisualStyleBackColor = true;
            // 
            // lblKayitTuru
            // 
            this.lblKayitTuru.AutoSize = true;
            this.lblKayitTuru.Location = new System.Drawing.Point(41, 223);
            this.lblKayitTuru.Name = "lblKayitTuru";
            this.lblKayitTuru.Size = new System.Drawing.Size(73, 17);
            this.lblKayitTuru.TabIndex = 15;
            this.lblKayitTuru.Text = "Kayit Türü";
            // 
            // cBoxKayitTuru
            // 
            this.cBoxKayitTuru.FormattingEnabled = true;
            this.cBoxKayitTuru.Items.AddRange(new object[] {
            "Arac Sahibi",
            "Müşteri"});
            this.cBoxKayitTuru.Location = new System.Drawing.Point(127, 220);
            this.cBoxKayitTuru.Name = "cBoxKayitTuru";
            this.cBoxKayitTuru.Size = new System.Drawing.Size(126, 24);
            this.cBoxKayitTuru.TabIndex = 14;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(127, 171);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(126, 22);
            this.txtKayitSifre.TabIndex = 13;
            // 
            // lblSifre_
            // 
            this.lblSifre_.AutoSize = true;
            this.lblSifre_.Location = new System.Drawing.Point(41, 174);
            this.lblSifre_.Name = "lblSifre_";
            this.lblSifre_.Size = new System.Drawing.Size(37, 17);
            this.lblSifre_.TabIndex = 12;
            this.lblSifre_.Text = "Şifre";
            // 
            // txtKayitEposta
            // 
            this.txtKayitEposta.Location = new System.Drawing.Point(127, 125);
            this.txtKayitEposta.Name = "txtKayitEposta";
            this.txtKayitEposta.Size = new System.Drawing.Size(126, 22);
            this.txtKayitEposta.TabIndex = 11;
            // 
            // lblEposta_
            // 
            this.lblEposta_.AutoSize = true;
            this.lblEposta_.Location = new System.Drawing.Point(41, 128);
            this.lblEposta_.Name = "lblEposta_";
            this.lblEposta_.Size = new System.Drawing.Size(57, 17);
            this.lblEposta_.TabIndex = 10;
            this.lblEposta_.Text = "E-posta";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(77, 267);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(91, 34);
            this.btnKayit.TabIndex = 9;
            this.btnKayit.Text = "Kaydol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(127, 78);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(126, 22);
            this.txtSoyisim.TabIndex = 8;
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(41, 81);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(56, 17);
            this.lblSoyisim.TabIndex = 7;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(127, 32);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(126, 22);
            this.txtIsim.TabIndex = 6;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(41, 35);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(32, 17);
            this.lblIsim.TabIndex = 5;
            this.lblIsim.Text = "İsim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 624);
            this.Controls.Add(this.tabGirisKayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabGirisKayit.ResumeLayout(false);
            this.girisPage.ResumeLayout(false);
            this.girisPage.PerformLayout();
            this.kayitPage.ResumeLayout(false);
            this.kayitPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGirisKayit;
        private System.Windows.Forms.TabPage girisPage;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TabPage kayitPage;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.Label lblSifre_;
        private System.Windows.Forms.TextBox txtKayitEposta;
        private System.Windows.Forms.Label lblEposta_;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblKayitTuru;
        private System.Windows.Forms.ComboBox cBoxKayitTuru;
    }
}

