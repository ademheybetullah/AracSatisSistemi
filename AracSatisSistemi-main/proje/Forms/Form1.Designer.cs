
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.lblIkinciElAracSatisSistemi = new System.Windows.Forms.Label();
            this.tabGirisKayit.SuspendLayout();
            this.girisPage.SuspendLayout();
            this.kayitPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGirisKayit
            // 
            this.tabGirisKayit.Controls.Add(this.girisPage);
            this.tabGirisKayit.Controls.Add(this.kayitPage);
            this.tabGirisKayit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGirisKayit.Location = new System.Drawing.Point(180, 135);
            this.tabGirisKayit.Margin = new System.Windows.Forms.Padding(2);
            this.tabGirisKayit.Name = "tabGirisKayit";
            this.tabGirisKayit.SelectedIndex = 0;
            this.tabGirisKayit.Size = new System.Drawing.Size(248, 305);
            this.tabGirisKayit.TabIndex = 0;
            // 
            // girisPage
            // 
            this.girisPage.Controls.Add(this.btnGiris);
            this.girisPage.Controls.Add(this.txtSifre);
            this.girisPage.Controls.Add(this.lblSifre);
            this.girisPage.Controls.Add(this.txtEposta);
            this.girisPage.Controls.Add(this.lblEposta);
            this.girisPage.Location = new System.Drawing.Point(4, 22);
            this.girisPage.Margin = new System.Windows.Forms.Padding(2);
            this.girisPage.Name = "girisPage";
            this.girisPage.Padding = new System.Windows.Forms.Padding(2);
            this.girisPage.Size = new System.Drawing.Size(240, 279);
            this.girisPage.TabIndex = 0;
            this.girisPage.Text = "Giriş";
            this.girisPage.UseVisualStyleBackColor = true;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Gold;
            this.btnGiris.Location = new System.Drawing.Point(32, 232);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(176, 28);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(94, 62);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(96, 22);
            this.txtSifre.TabIndex = 3;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(29, 64);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(30, 13);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre";
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(94, 24);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(96, 22);
            this.txtEposta.TabIndex = 1;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(29, 27);
            this.lblEposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(46, 13);
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
            this.kayitPage.Location = new System.Drawing.Point(4, 22);
            this.kayitPage.Margin = new System.Windows.Forms.Padding(2);
            this.kayitPage.Name = "kayitPage";
            this.kayitPage.Padding = new System.Windows.Forms.Padding(2);
            this.kayitPage.Size = new System.Drawing.Size(240, 279);
            this.kayitPage.TabIndex = 1;
            this.kayitPage.Text = "Kayıt";
            this.kayitPage.UseVisualStyleBackColor = true;
            // 
            // lblKayitTuru
            // 
            this.lblKayitTuru.AutoSize = true;
            this.lblKayitTuru.Location = new System.Drawing.Point(31, 181);
            this.lblKayitTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKayitTuru.Name = "lblKayitTuru";
            this.lblKayitTuru.Size = new System.Drawing.Size(59, 13);
            this.lblKayitTuru.TabIndex = 15;
            this.lblKayitTuru.Text = "Kayıt Türü";
            // 
            // cBoxKayitTuru
            // 
            this.cBoxKayitTuru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxKayitTuru.FormattingEnabled = true;
            this.cBoxKayitTuru.Items.AddRange(new object[] {
            "Arac Sahibi",
            "Müşteri"});
            this.cBoxKayitTuru.Location = new System.Drawing.Point(95, 179);
            this.cBoxKayitTuru.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxKayitTuru.Name = "cBoxKayitTuru";
            this.cBoxKayitTuru.Size = new System.Drawing.Size(96, 21);
            this.cBoxKayitTuru.TabIndex = 14;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitSifre.Location = new System.Drawing.Point(95, 139);
            this.txtKayitSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(96, 22);
            this.txtKayitSifre.TabIndex = 13;
            // 
            // lblSifre_
            // 
            this.lblSifre_.AutoSize = true;
            this.lblSifre_.Location = new System.Drawing.Point(31, 141);
            this.lblSifre_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre_.Name = "lblSifre_";
            this.lblSifre_.Size = new System.Drawing.Size(30, 13);
            this.lblSifre_.TabIndex = 12;
            this.lblSifre_.Text = "Şifre";
            // 
            // txtKayitEposta
            // 
            this.txtKayitEposta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitEposta.Location = new System.Drawing.Point(95, 102);
            this.txtKayitEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtKayitEposta.Name = "txtKayitEposta";
            this.txtKayitEposta.Size = new System.Drawing.Size(96, 22);
            this.txtKayitEposta.TabIndex = 11;
            // 
            // lblEposta_
            // 
            this.lblEposta_.AutoSize = true;
            this.lblEposta_.Location = new System.Drawing.Point(31, 104);
            this.lblEposta_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEposta_.Name = "lblEposta_";
            this.lblEposta_.Size = new System.Drawing.Size(46, 13);
            this.lblEposta_.TabIndex = 10;
            this.lblEposta_.Text = "E-posta";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Gold;
            this.btnKayit.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.Location = new System.Drawing.Point(32, 232);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(176, 28);
            this.btnKayit.TabIndex = 9;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(95, 63);
            this.txtSoyisim.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(96, 22);
            this.txtSoyisim.TabIndex = 8;
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(31, 66);
            this.lblSoyisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(47, 13);
            this.lblSoyisim.TabIndex = 7;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(95, 26);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(96, 22);
            this.txtIsim.TabIndex = 6;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(31, 28);
            this.lblIsim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(28, 13);
            this.lblIsim.TabIndex = 5;
            this.lblIsim.Text = "İsim";
            // 
            // lblIkinciElAracSatisSistemi
            // 
            this.lblIkinciElAracSatisSistemi.AutoSize = true;
            this.lblIkinciElAracSatisSistemi.BackColor = System.Drawing.Color.Gold;
            this.lblIkinciElAracSatisSistemi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkinciElAracSatisSistemi.Location = new System.Drawing.Point(156, 29);
            this.lblIkinciElAracSatisSistemi.Name = "lblIkinciElAracSatisSistemi";
            this.lblIkinciElAracSatisSistemi.Size = new System.Drawing.Size(312, 32);
            this.lblIkinciElAracSatisSistemi.TabIndex = 1;
            this.lblIkinciElAracSatisSistemi.Text = "İkinci El Araç Satış Sistemi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(597, 507);
            this.Controls.Add(this.lblIkinciElAracSatisSistemi);
            this.Controls.Add(this.tabGirisKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İkinci El Araç Satış Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabGirisKayit.ResumeLayout(false);
            this.girisPage.ResumeLayout(false);
            this.girisPage.PerformLayout();
            this.kayitPage.ResumeLayout(false);
            this.kayitPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblIkinciElAracSatisSistemi;
    }
}

