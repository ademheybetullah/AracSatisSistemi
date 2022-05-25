
namespace proje
{
    partial class MusteriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMusteri = new System.Windows.Forms.TabControl();
            this.araclarPage = new System.Windows.Forms.TabPage();
            this.gBoxFiltreler = new System.Windows.Forms.GroupBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.lblMinFiyat = new System.Windows.Forms.Label();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.IlanlarListView = new System.Windows.Forms.ListView();
            this.colMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKilometre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIlanAyrintisi = new System.Windows.Forms.Button();
            this.gBoxAyrintilar = new System.Windows.Forms.GroupBox();
            this.txtAracFiyat = new System.Windows.Forms.TextBox();
            this.txtAracKm = new System.Windows.Forms.TextBox();
            this.txtSanziman = new System.Windows.Forms.TextBox();
            this.txtAracModel = new System.Windows.Forms.TextBox();
            this.txtAracMarka = new System.Windows.Forms.TextBox();
            this.txtAracMotor = new System.Windows.Forms.TextBox();
            this.lblDonanimlar = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblUretimYili = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblSanziman = new System.Windows.Forms.Label();
            this.lblYakit = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblAracTuru = new System.Windows.Forms.Label();
            this.txtAracTuru = new System.Windows.Forms.TextBox();
            this.txtYakitTuru = new System.Windows.Forms.TextBox();
            this.txtAracUretimYili = new System.Windows.Forms.TextBox();
            this.lboxAyrintiDonanimlar = new System.Windows.Forms.ListBox();
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.YorumPage = new System.Windows.Forms.TabPage();
            this.gBoxYorum = new System.Windows.Forms.GroupBox();
            this.lblAracSahibi = new System.Windows.Forms.Label();
            this.txtAracSahibiAdi = new System.Windows.Forms.TextBox();
            this.txtIlanId = new System.Windows.Forms.TextBox();
            this.lblIlanId = new System.Windows.Forms.Label();
            this.txtYorumMetni = new System.Windows.Forms.TextBox();
            this.lblYorum = new System.Windows.Forms.Label();
            this.btnYorumEkle = new System.Windows.Forms.Button();
            this.tabMusteri.SuspendLayout();
            this.araclarPage.SuspendLayout();
            this.gBoxFiltreler.SuspendLayout();
            this.gBoxAyrintilar.SuspendLayout();
            this.YorumPage.SuspendLayout();
            this.gBoxYorum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMusteri
            // 
            this.tabMusteri.Controls.Add(this.araclarPage);
            this.tabMusteri.Controls.Add(this.YorumPage);
            this.tabMusteri.Location = new System.Drawing.Point(4, 4);
            this.tabMusteri.Name = "tabMusteri";
            this.tabMusteri.SelectedIndex = 0;
            this.tabMusteri.Size = new System.Drawing.Size(1346, 668);
            this.tabMusteri.TabIndex = 1;
            // 
            // araclarPage
            // 
            this.araclarPage.Controls.Add(this.gBoxAyrintilar);
            this.araclarPage.Controls.Add(this.btnIlanAyrintisi);
            this.araclarPage.Controls.Add(this.gBoxFiltreler);
            this.araclarPage.Controls.Add(this.btnKarsilastir);
            this.araclarPage.Controls.Add(this.IlanlarListView);
            this.araclarPage.Location = new System.Drawing.Point(4, 25);
            this.araclarPage.Name = "araclarPage";
            this.araclarPage.Padding = new System.Windows.Forms.Padding(3);
            this.araclarPage.Size = new System.Drawing.Size(1338, 639);
            this.araclarPage.TabIndex = 0;
            this.araclarPage.Text = "Araçlar";
            this.araclarPage.UseVisualStyleBackColor = true;
            // 
            // gBoxFiltreler
            // 
            this.gBoxFiltreler.Controls.Add(this.btnFiltrele);
            this.gBoxFiltreler.Controls.Add(this.txtMinFiyat);
            this.gBoxFiltreler.Controls.Add(this.lblMinFiyat);
            this.gBoxFiltreler.Location = new System.Drawing.Point(3, 6);
            this.gBoxFiltreler.Name = "gBoxFiltreler";
            this.gBoxFiltreler.Size = new System.Drawing.Size(243, 155);
            this.gBoxFiltreler.TabIndex = 2;
            this.gBoxFiltreler.TabStop = false;
            this.gBoxFiltreler.Text = "Filtreleme";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(10, 74);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(85, 42);
            this.btnFiltrele.TabIndex = 2;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Location = new System.Drawing.Point(77, 32);
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(130, 22);
            this.txtMinFiyat.TabIndex = 1;
            // 
            // lblMinFiyat
            // 
            this.lblMinFiyat.AutoSize = true;
            this.lblMinFiyat.Location = new System.Drawing.Point(7, 36);
            this.lblMinFiyat.Name = "lblMinFiyat";
            this.lblMinFiyat.Size = new System.Drawing.Size(64, 17);
            this.lblMinFiyat.TabIndex = 0;
            this.lblMinFiyat.Text = "Min Fiyat";
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Location = new System.Drawing.Point(1052, 5);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(101, 54);
            this.btnKarsilastir.TabIndex = 1;
            this.btnKarsilastir.Text = "Seçilileri Karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // IlanlarListView
            // 
            this.IlanlarListView.CheckBoxes = true;
            this.IlanlarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colMarka,
            this.colModel,
            this.colFiyat,
            this.colKilometre});
            this.IlanlarListView.FullRowSelect = true;
            this.IlanlarListView.HideSelection = false;
            this.IlanlarListView.HoverSelection = true;
            this.IlanlarListView.Location = new System.Drawing.Point(252, 6);
            this.IlanlarListView.Name = "IlanlarListView";
            this.IlanlarListView.Size = new System.Drawing.Size(755, 607);
            this.IlanlarListView.TabIndex = 0;
            this.IlanlarListView.UseCompatibleStateImageBehavior = false;
            this.IlanlarListView.View = System.Windows.Forms.View.Details;
            // 
            // colMarka
            // 
            this.colMarka.Text = "Marka";
            this.colMarka.Width = 150;
            // 
            // colModel
            // 
            this.colModel.Text = "Model";
            this.colModel.Width = 150;
            // 
            // colFiyat
            // 
            this.colFiyat.Text = "Fiyat";
            this.colFiyat.Width = 150;
            // 
            // colKilometre
            // 
            this.colKilometre.Text = "Kilometre";
            this.colKilometre.Width = 150;
            // 
            // colId
            // 
            this.colId.Text = "Ilan Id";
            this.colId.Width = 150;
            // 
            // btnIlanAyrintisi
            // 
            this.btnIlanAyrintisi.Location = new System.Drawing.Point(1183, 6);
            this.btnIlanAyrintisi.Name = "btnIlanAyrintisi";
            this.btnIlanAyrintisi.Size = new System.Drawing.Size(101, 54);
            this.btnIlanAyrintisi.TabIndex = 3;
            this.btnIlanAyrintisi.Text = "Ayrıntıları Göster";
            this.btnIlanAyrintisi.UseVisualStyleBackColor = true;
            this.btnIlanAyrintisi.Click += new System.EventHandler(this.btnIlanAyrintisi_Click);
            // 
            // gBoxAyrintilar
            // 
            this.gBoxAyrintilar.Controls.Add(this.btnYorumYap);
            this.gBoxAyrintilar.Controls.Add(this.lboxAyrintiDonanimlar);
            this.gBoxAyrintilar.Controls.Add(this.txtAracUretimYili);
            this.gBoxAyrintilar.Controls.Add(this.txtYakitTuru);
            this.gBoxAyrintilar.Controls.Add(this.txtAracTuru);
            this.gBoxAyrintilar.Controls.Add(this.lblAracTuru);
            this.gBoxAyrintilar.Controls.Add(this.lblMarka);
            this.gBoxAyrintilar.Controls.Add(this.txtAracFiyat);
            this.gBoxAyrintilar.Controls.Add(this.lblModel);
            this.gBoxAyrintilar.Controls.Add(this.txtAracKm);
            this.gBoxAyrintilar.Controls.Add(this.lblYakit);
            this.gBoxAyrintilar.Controls.Add(this.txtSanziman);
            this.gBoxAyrintilar.Controls.Add(this.lblSanziman);
            this.gBoxAyrintilar.Controls.Add(this.txtAracModel);
            this.gBoxAyrintilar.Controls.Add(this.lblMotor);
            this.gBoxAyrintilar.Controls.Add(this.txtAracMarka);
            this.gBoxAyrintilar.Controls.Add(this.lblKm);
            this.gBoxAyrintilar.Controls.Add(this.txtAracMotor);
            this.gBoxAyrintilar.Controls.Add(this.lblUretimYili);
            this.gBoxAyrintilar.Controls.Add(this.lblDonanimlar);
            this.gBoxAyrintilar.Controls.Add(this.lblFiyat);
            this.gBoxAyrintilar.Location = new System.Drawing.Point(1014, 80);
            this.gBoxAyrintilar.Name = "gBoxAyrintilar";
            this.gBoxAyrintilar.Size = new System.Drawing.Size(318, 556);
            this.gBoxAyrintilar.TabIndex = 4;
            this.gBoxAyrintilar.TabStop = false;
            this.gBoxAyrintilar.Text = "Ayrıntılar";
            // 
            // txtAracFiyat
            // 
            this.txtAracFiyat.Location = new System.Drawing.Point(140, 306);
            this.txtAracFiyat.Name = "txtAracFiyat";
            this.txtAracFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtAracFiyat.TabIndex = 35;
            // 
            // txtAracKm
            // 
            this.txtAracKm.Location = new System.Drawing.Point(140, 239);
            this.txtAracKm.Name = "txtAracKm";
            this.txtAracKm.Size = new System.Drawing.Size(100, 22);
            this.txtAracKm.TabIndex = 34;
            // 
            // txtSanziman
            // 
            this.txtSanziman.Location = new System.Drawing.Point(140, 166);
            this.txtSanziman.Name = "txtSanziman";
            this.txtSanziman.Size = new System.Drawing.Size(100, 22);
            this.txtSanziman.TabIndex = 33;
            // 
            // txtAracModel
            // 
            this.txtAracModel.Location = new System.Drawing.Point(140, 96);
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.Size = new System.Drawing.Size(100, 22);
            this.txtAracModel.TabIndex = 32;
            // 
            // txtAracMarka
            // 
            this.txtAracMarka.Location = new System.Drawing.Point(140, 62);
            this.txtAracMarka.Name = "txtAracMarka";
            this.txtAracMarka.Size = new System.Drawing.Size(100, 22);
            this.txtAracMarka.TabIndex = 31;
            // 
            // txtAracMotor
            // 
            this.txtAracMotor.Location = new System.Drawing.Point(140, 203);
            this.txtAracMotor.Name = "txtAracMotor";
            this.txtAracMotor.Size = new System.Drawing.Size(100, 22);
            this.txtAracMotor.TabIndex = 30;
            // 
            // lblDonanimlar
            // 
            this.lblDonanimlar.AutoSize = true;
            this.lblDonanimlar.Location = new System.Drawing.Point(13, 345);
            this.lblDonanimlar.Name = "lblDonanimlar";
            this.lblDonanimlar.Size = new System.Drawing.Size(80, 17);
            this.lblDonanimlar.TabIndex = 29;
            this.lblDonanimlar.Text = "Donanımlar";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(13, 309);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 28;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblUretimYili
            // 
            this.lblUretimYili.AutoSize = true;
            this.lblUretimYili.Location = new System.Drawing.Point(13, 277);
            this.lblUretimYili.Name = "lblUretimYili";
            this.lblUretimYili.Size = new System.Drawing.Size(71, 17);
            this.lblUretimYili.TabIndex = 27;
            this.lblUretimYili.Text = "Üretim Yılı";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(13, 242);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(67, 17);
            this.lblKm.TabIndex = 26;
            this.lblKm.Text = "Kilometre";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(13, 206);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(44, 17);
            this.lblMotor.TabIndex = 25;
            this.lblMotor.Text = "Motor";
            // 
            // lblSanziman
            // 
            this.lblSanziman.AutoSize = true;
            this.lblSanziman.Location = new System.Drawing.Point(13, 169);
            this.lblSanziman.Name = "lblSanziman";
            this.lblSanziman.Size = new System.Drawing.Size(70, 17);
            this.lblSanziman.TabIndex = 24;
            this.lblSanziman.Text = "Şanzıman";
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Location = new System.Drawing.Point(13, 135);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(73, 17);
            this.lblYakit.TabIndex = 23;
            this.lblYakit.Text = "Yakıt Türü";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 99);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 22;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(13, 65);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 21;
            this.lblMarka.Text = "Marka";
            // 
            // lblAracTuru
            // 
            this.lblAracTuru.AutoSize = true;
            this.lblAracTuru.Location = new System.Drawing.Point(13, 33);
            this.lblAracTuru.Name = "lblAracTuru";
            this.lblAracTuru.Size = new System.Drawing.Size(71, 17);
            this.lblAracTuru.TabIndex = 20;
            this.lblAracTuru.Text = "Araç Türü";
            // 
            // txtAracTuru
            // 
            this.txtAracTuru.Location = new System.Drawing.Point(140, 30);
            this.txtAracTuru.Name = "txtAracTuru";
            this.txtAracTuru.Size = new System.Drawing.Size(100, 22);
            this.txtAracTuru.TabIndex = 40;
            // 
            // txtYakitTuru
            // 
            this.txtYakitTuru.Location = new System.Drawing.Point(140, 132);
            this.txtYakitTuru.Name = "txtYakitTuru";
            this.txtYakitTuru.Size = new System.Drawing.Size(100, 22);
            this.txtYakitTuru.TabIndex = 41;
            // 
            // txtAracUretimYili
            // 
            this.txtAracUretimYili.Location = new System.Drawing.Point(140, 274);
            this.txtAracUretimYili.Name = "txtAracUretimYili";
            this.txtAracUretimYili.Size = new System.Drawing.Size(100, 22);
            this.txtAracUretimYili.TabIndex = 42;
            // 
            // lboxAyrintiDonanimlar
            // 
            this.lboxAyrintiDonanimlar.FormattingEnabled = true;
            this.lboxAyrintiDonanimlar.ItemHeight = 16;
            this.lboxAyrintiDonanimlar.Location = new System.Drawing.Point(140, 345);
            this.lboxAyrintiDonanimlar.Name = "lboxAyrintiDonanimlar";
            this.lboxAyrintiDonanimlar.Size = new System.Drawing.Size(156, 116);
            this.lboxAyrintiDonanimlar.TabIndex = 43;
            // 
            // btnYorumYap
            // 
            this.btnYorumYap.Location = new System.Drawing.Point(117, 479);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(101, 54);
            this.btnYorumYap.TabIndex = 5;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = true;
            this.btnYorumYap.Click += new System.EventHandler(this.btnYorumYap_Click);
            // 
            // YorumPage
            // 
            this.YorumPage.Controls.Add(this.gBoxYorum);
            this.YorumPage.Location = new System.Drawing.Point(4, 25);
            this.YorumPage.Name = "YorumPage";
            this.YorumPage.Size = new System.Drawing.Size(1338, 639);
            this.YorumPage.TabIndex = 1;
            this.YorumPage.Text = "Yorum Yap";
            this.YorumPage.UseVisualStyleBackColor = true;
            // 
            // gBoxYorum
            // 
            this.gBoxYorum.Controls.Add(this.btnYorumEkle);
            this.gBoxYorum.Controls.Add(this.txtYorumMetni);
            this.gBoxYorum.Controls.Add(this.lblYorum);
            this.gBoxYorum.Controls.Add(this.txtIlanId);
            this.gBoxYorum.Controls.Add(this.lblIlanId);
            this.gBoxYorum.Controls.Add(this.txtAracSahibiAdi);
            this.gBoxYorum.Controls.Add(this.lblAracSahibi);
            this.gBoxYorum.Location = new System.Drawing.Point(16, 19);
            this.gBoxYorum.Name = "gBoxYorum";
            this.gBoxYorum.Size = new System.Drawing.Size(305, 354);
            this.gBoxYorum.TabIndex = 0;
            this.gBoxYorum.TabStop = false;
            this.gBoxYorum.Text = "Yorum Ekle";
            // 
            // lblAracSahibi
            // 
            this.lblAracSahibi.AutoSize = true;
            this.lblAracSahibi.Location = new System.Drawing.Point(16, 39);
            this.lblAracSahibi.Name = "lblAracSahibi";
            this.lblAracSahibi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAracSahibi.Size = new System.Drawing.Size(80, 17);
            this.lblAracSahibi.TabIndex = 0;
            this.lblAracSahibi.Text = "Arac Sahibi";
            // 
            // txtAracSahibiAdi
            // 
            this.txtAracSahibiAdi.Location = new System.Drawing.Point(125, 36);
            this.txtAracSahibiAdi.Name = "txtAracSahibiAdi";
            this.txtAracSahibiAdi.Size = new System.Drawing.Size(159, 22);
            this.txtAracSahibiAdi.TabIndex = 1;
            // 
            // txtIlanId
            // 
            this.txtIlanId.Location = new System.Drawing.Point(125, 80);
            this.txtIlanId.Name = "txtIlanId";
            this.txtIlanId.Size = new System.Drawing.Size(159, 22);
            this.txtIlanId.TabIndex = 3;
            // 
            // lblIlanId
            // 
            this.lblIlanId.AutoSize = true;
            this.lblIlanId.Location = new System.Drawing.Point(16, 83);
            this.lblIlanId.Name = "lblIlanId";
            this.lblIlanId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIlanId.Size = new System.Drawing.Size(45, 17);
            this.lblIlanId.TabIndex = 2;
            this.lblIlanId.Text = "İlan Id";
            // 
            // txtYorumMetni
            // 
            this.txtYorumMetni.Location = new System.Drawing.Point(125, 129);
            this.txtYorumMetni.Multiline = true;
            this.txtYorumMetni.Name = "txtYorumMetni";
            this.txtYorumMetni.Size = new System.Drawing.Size(159, 136);
            this.txtYorumMetni.TabIndex = 3;
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Location = new System.Drawing.Point(16, 132);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYorum.Size = new System.Drawing.Size(49, 17);
            this.lblYorum.TabIndex = 2;
            this.lblYorum.Text = "Yorum";
            // 
            // btnYorumEkle
            // 
            this.btnYorumEkle.Location = new System.Drawing.Point(87, 280);
            this.btnYorumEkle.Name = "btnYorumEkle";
            this.btnYorumEkle.Size = new System.Drawing.Size(90, 44);
            this.btnYorumEkle.TabIndex = 4;
            this.btnYorumEkle.Text = "Yorum Yap";
            this.btnYorumEkle.UseVisualStyleBackColor = true;
            this.btnYorumEkle.Click += new System.EventHandler(this.btnYorumEkle_Click);
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 710);
            this.Controls.Add(this.tabMusteri);
            this.Name = "MusteriForm";
            this.Text = "MusteriForm";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            this.tabMusteri.ResumeLayout(false);
            this.araclarPage.ResumeLayout(false);
            this.gBoxFiltreler.ResumeLayout(false);
            this.gBoxFiltreler.PerformLayout();
            this.gBoxAyrintilar.ResumeLayout(false);
            this.gBoxAyrintilar.PerformLayout();
            this.YorumPage.ResumeLayout(false);
            this.gBoxYorum.ResumeLayout(false);
            this.gBoxYorum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMusteri;
        private System.Windows.Forms.TabPage araclarPage;
        private System.Windows.Forms.ListView IlanlarListView;
        private System.Windows.Forms.ColumnHeader colMarka;
        private System.Windows.Forms.ColumnHeader colModel;
        private System.Windows.Forms.ColumnHeader colFiyat;
        private System.Windows.Forms.ColumnHeader colKilometre;
        private System.Windows.Forms.GroupBox gBoxFiltreler;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.Label lblMinFiyat;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.Button btnIlanAyrintisi;
        private System.Windows.Forms.GroupBox gBoxAyrintilar;
        private System.Windows.Forms.Button btnYorumYap;
        private System.Windows.Forms.ListBox lboxAyrintiDonanimlar;
        private System.Windows.Forms.TextBox txtAracUretimYili;
        private System.Windows.Forms.TextBox txtYakitTuru;
        private System.Windows.Forms.TextBox txtAracTuru;
        private System.Windows.Forms.Label lblAracTuru;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtAracFiyat;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtAracKm;
        private System.Windows.Forms.Label lblYakit;
        private System.Windows.Forms.TextBox txtSanziman;
        private System.Windows.Forms.Label lblSanziman;
        private System.Windows.Forms.TextBox txtAracModel;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.TextBox txtAracMarka;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtAracMotor;
        private System.Windows.Forms.Label lblUretimYili;
        private System.Windows.Forms.Label lblDonanimlar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TabPage YorumPage;
        private System.Windows.Forms.GroupBox gBoxYorum;
        private System.Windows.Forms.Button btnYorumEkle;
        private System.Windows.Forms.TextBox txtYorumMetni;
        private System.Windows.Forms.Label lblYorum;
        private System.Windows.Forms.TextBox txtIlanId;
        private System.Windows.Forms.Label lblIlanId;
        private System.Windows.Forms.TextBox txtAracSahibiAdi;
        private System.Windows.Forms.Label lblAracSahibi;
    }
}