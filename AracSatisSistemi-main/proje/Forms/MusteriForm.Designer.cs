
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriForm));
            this.tabMusteri = new System.Windows.Forms.TabControl();
            this.araclarPage = new System.Windows.Forms.TabPage();
            this.gBoxAyrintilar = new System.Windows.Forms.GroupBox();
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.lboxAyrintiDonanimlar = new System.Windows.Forms.ListBox();
            this.txtAracUretimYili = new System.Windows.Forms.TextBox();
            this.txtYakitTuru = new System.Windows.Forms.TextBox();
            this.txtAracTuru = new System.Windows.Forms.TextBox();
            this.lblAracTuru = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtAracFiyat = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtAracKm = new System.Windows.Forms.TextBox();
            this.lblYakit = new System.Windows.Forms.Label();
            this.txtSanziman = new System.Windows.Forms.TextBox();
            this.lblSanziman = new System.Windows.Forms.Label();
            this.txtAracModel = new System.Windows.Forms.TextBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.txtAracMarka = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtAracMotor = new System.Windows.Forms.TextBox();
            this.lblUretimYili = new System.Windows.Forms.Label();
            this.lblDonanimlar = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnIlanAyrintisi = new System.Windows.Forms.Button();
            this.gBoxFiltreler = new System.Windows.Forms.GroupBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.lblMinFiyat = new System.Windows.Forms.Label();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.IlanlarListView = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKilometre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YorumPage = new System.Windows.Forms.TabPage();
            this.gBoxYorum = new System.Windows.Forms.GroupBox();
            this.btnYorumEkle = new System.Windows.Forms.Button();
            this.txtYorumMetni = new System.Windows.Forms.TextBox();
            this.lblYorum = new System.Windows.Forms.Label();
            this.txtIlanId = new System.Windows.Forms.TextBox();
            this.lblIlanId = new System.Windows.Forms.Label();
            this.txtAracSahibiAdi = new System.Windows.Forms.TextBox();
            this.lblAracSahibi = new System.Windows.Forms.Label();
            this.tabMusteri.SuspendLayout();
            this.araclarPage.SuspendLayout();
            this.gBoxAyrintilar.SuspendLayout();
            this.gBoxFiltreler.SuspendLayout();
            this.YorumPage.SuspendLayout();
            this.gBoxYorum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMusteri
            // 
            this.tabMusteri.Controls.Add(this.araclarPage);
            this.tabMusteri.Controls.Add(this.YorumPage);
            this.tabMusteri.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabMusteri.Location = new System.Drawing.Point(11, 11);
            this.tabMusteri.Margin = new System.Windows.Forms.Padding(2);
            this.tabMusteri.Name = "tabMusteri";
            this.tabMusteri.SelectedIndex = 0;
            this.tabMusteri.Size = new System.Drawing.Size(1242, 555);
            this.tabMusteri.TabIndex = 1;
            // 
            // araclarPage
            // 
            this.araclarPage.Controls.Add(this.gBoxAyrintilar);
            this.araclarPage.Controls.Add(this.btnIlanAyrintisi);
            this.araclarPage.Controls.Add(this.gBoxFiltreler);
            this.araclarPage.Controls.Add(this.btnKarsilastir);
            this.araclarPage.Controls.Add(this.IlanlarListView);
            this.araclarPage.Location = new System.Drawing.Point(4, 22);
            this.araclarPage.Margin = new System.Windows.Forms.Padding(2);
            this.araclarPage.Name = "araclarPage";
            this.araclarPage.Padding = new System.Windows.Forms.Padding(2);
            this.araclarPage.Size = new System.Drawing.Size(1234, 529);
            this.araclarPage.TabIndex = 0;
            this.araclarPage.Text = "Araçlar";
            this.araclarPage.UseVisualStyleBackColor = true;
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
            this.gBoxAyrintilar.Location = new System.Drawing.Point(980, 91);
            this.gBoxAyrintilar.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxAyrintilar.Name = "gBoxAyrintilar";
            this.gBoxAyrintilar.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxAyrintilar.Size = new System.Drawing.Size(238, 426);
            this.gBoxAyrintilar.TabIndex = 4;
            this.gBoxAyrintilar.TabStop = false;
            this.gBoxAyrintilar.Text = "Ayrıntılar";
            // 
            // btnYorumYap
            // 
            this.btnYorumYap.BackColor = System.Drawing.Color.Gold;
            this.btnYorumYap.Location = new System.Drawing.Point(34, 389);
            this.btnYorumYap.Margin = new System.Windows.Forms.Padding(2);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(176, 28);
            this.btnYorumYap.TabIndex = 5;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = false;
            this.btnYorumYap.Click += new System.EventHandler(this.btnYorumYap_Click);
            // 
            // lboxAyrintiDonanimlar
            // 
            this.lboxAyrintiDonanimlar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxAyrintiDonanimlar.FormattingEnabled = true;
            this.lboxAyrintiDonanimlar.Location = new System.Drawing.Point(105, 280);
            this.lboxAyrintiDonanimlar.Margin = new System.Windows.Forms.Padding(2);
            this.lboxAyrintiDonanimlar.Name = "lboxAyrintiDonanimlar";
            this.lboxAyrintiDonanimlar.Size = new System.Drawing.Size(118, 95);
            this.lboxAyrintiDonanimlar.TabIndex = 43;
            // 
            // txtAracUretimYili
            // 
            this.txtAracUretimYili.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracUretimYili.Location = new System.Drawing.Point(105, 223);
            this.txtAracUretimYili.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracUretimYili.Name = "txtAracUretimYili";
            this.txtAracUretimYili.Size = new System.Drawing.Size(96, 22);
            this.txtAracUretimYili.TabIndex = 42;
            // 
            // txtYakitTuru
            // 
            this.txtYakitTuru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYakitTuru.Location = new System.Drawing.Point(105, 107);
            this.txtYakitTuru.Margin = new System.Windows.Forms.Padding(2);
            this.txtYakitTuru.Name = "txtYakitTuru";
            this.txtYakitTuru.Size = new System.Drawing.Size(96, 22);
            this.txtYakitTuru.TabIndex = 41;
            // 
            // txtAracTuru
            // 
            this.txtAracTuru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracTuru.Location = new System.Drawing.Point(105, 24);
            this.txtAracTuru.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracTuru.Name = "txtAracTuru";
            this.txtAracTuru.Size = new System.Drawing.Size(96, 22);
            this.txtAracTuru.TabIndex = 40;
            // 
            // lblAracTuru
            // 
            this.lblAracTuru.AutoSize = true;
            this.lblAracTuru.Location = new System.Drawing.Point(10, 27);
            this.lblAracTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAracTuru.Name = "lblAracTuru";
            this.lblAracTuru.Size = new System.Drawing.Size(56, 13);
            this.lblAracTuru.TabIndex = 20;
            this.lblAracTuru.Text = "Araç Türü";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(10, 53);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(40, 13);
            this.lblMarka.TabIndex = 21;
            this.lblMarka.Text = "Marka";
            // 
            // txtAracFiyat
            // 
            this.txtAracFiyat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracFiyat.Location = new System.Drawing.Point(105, 249);
            this.txtAracFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracFiyat.Name = "txtAracFiyat";
            this.txtAracFiyat.Size = new System.Drawing.Size(96, 22);
            this.txtAracFiyat.TabIndex = 35;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(10, 80);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 13);
            this.lblModel.TabIndex = 22;
            this.lblModel.Text = "Model";
            // 
            // txtAracKm
            // 
            this.txtAracKm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracKm.Location = new System.Drawing.Point(105, 194);
            this.txtAracKm.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracKm.Name = "txtAracKm";
            this.txtAracKm.Size = new System.Drawing.Size(96, 22);
            this.txtAracKm.TabIndex = 34;
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Location = new System.Drawing.Point(10, 110);
            this.lblYakit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(58, 13);
            this.lblYakit.TabIndex = 23;
            this.lblYakit.Text = "Yakıt Türü";
            // 
            // txtSanziman
            // 
            this.txtSanziman.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSanziman.Location = new System.Drawing.Point(105, 135);
            this.txtSanziman.Margin = new System.Windows.Forms.Padding(2);
            this.txtSanziman.Name = "txtSanziman";
            this.txtSanziman.Size = new System.Drawing.Size(96, 22);
            this.txtSanziman.TabIndex = 33;
            // 
            // lblSanziman
            // 
            this.lblSanziman.AutoSize = true;
            this.lblSanziman.Location = new System.Drawing.Point(10, 137);
            this.lblSanziman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSanziman.Name = "lblSanziman";
            this.lblSanziman.Size = new System.Drawing.Size(57, 13);
            this.lblSanziman.TabIndex = 24;
            this.lblSanziman.Text = "Şanzıman";
            // 
            // txtAracModel
            // 
            this.txtAracModel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracModel.Location = new System.Drawing.Point(105, 78);
            this.txtAracModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.Size = new System.Drawing.Size(96, 22);
            this.txtAracModel.TabIndex = 32;
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(10, 167);
            this.lblMotor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(40, 13);
            this.lblMotor.TabIndex = 25;
            this.lblMotor.Text = "Motor";
            // 
            // txtAracMarka
            // 
            this.txtAracMarka.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracMarka.Location = new System.Drawing.Point(105, 50);
            this.txtAracMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracMarka.Name = "txtAracMarka";
            this.txtAracMarka.Size = new System.Drawing.Size(96, 22);
            this.txtAracMarka.TabIndex = 31;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(10, 197);
            this.lblKm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(57, 13);
            this.lblKm.TabIndex = 26;
            this.lblKm.Text = "Kilometre";
            // 
            // txtAracMotor
            // 
            this.txtAracMotor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracMotor.Location = new System.Drawing.Point(105, 165);
            this.txtAracMotor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracMotor.Name = "txtAracMotor";
            this.txtAracMotor.Size = new System.Drawing.Size(96, 22);
            this.txtAracMotor.TabIndex = 30;
            // 
            // lblUretimYili
            // 
            this.lblUretimYili.AutoSize = true;
            this.lblUretimYili.Location = new System.Drawing.Point(10, 225);
            this.lblUretimYili.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUretimYili.Name = "lblUretimYili";
            this.lblUretimYili.Size = new System.Drawing.Size(61, 13);
            this.lblUretimYili.TabIndex = 27;
            this.lblUretimYili.Text = "Üretim Yılı";
            // 
            // lblDonanimlar
            // 
            this.lblDonanimlar.AutoSize = true;
            this.lblDonanimlar.Location = new System.Drawing.Point(10, 280);
            this.lblDonanimlar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonanimlar.Name = "lblDonanimlar";
            this.lblDonanimlar.Size = new System.Drawing.Size(68, 13);
            this.lblDonanimlar.TabIndex = 29;
            this.lblDonanimlar.Text = "Donanımlar";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(10, 251);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(32, 13);
            this.lblFiyat.TabIndex = 28;
            this.lblFiyat.Text = "Fiyat";
            // 
            // btnIlanAyrintisi
            // 
            this.btnIlanAyrintisi.BackColor = System.Drawing.Color.Gold;
            this.btnIlanAyrintisi.Location = new System.Drawing.Point(1014, 51);
            this.btnIlanAyrintisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIlanAyrintisi.Name = "btnIlanAyrintisi";
            this.btnIlanAyrintisi.Size = new System.Drawing.Size(176, 28);
            this.btnIlanAyrintisi.TabIndex = 3;
            this.btnIlanAyrintisi.Text = "Ayrıntıları Göster";
            this.btnIlanAyrintisi.UseVisualStyleBackColor = false;
            this.btnIlanAyrintisi.Click += new System.EventHandler(this.btnIlanAyrintisi_Click);
            // 
            // gBoxFiltreler
            // 
            this.gBoxFiltreler.Controls.Add(this.btnFiltrele);
            this.gBoxFiltreler.Controls.Add(this.txtMinFiyat);
            this.gBoxFiltreler.Controls.Add(this.lblMinFiyat);
            this.gBoxFiltreler.Location = new System.Drawing.Point(16, 15);
            this.gBoxFiltreler.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxFiltreler.Name = "gBoxFiltreler";
            this.gBoxFiltreler.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxFiltreler.Size = new System.Drawing.Size(189, 140);
            this.gBoxFiltreler.TabIndex = 2;
            this.gBoxFiltreler.TabStop = false;
            this.gBoxFiltreler.Text = "Filtreleme";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.Gold;
            this.btnFiltrele.Location = new System.Drawing.Point(7, 101);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(176, 28);
            this.btnFiltrele.TabIndex = 2;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinFiyat.Location = new System.Drawing.Point(74, 26);
            this.txtMinFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(96, 22);
            this.txtMinFiyat.TabIndex = 1;
            // 
            // lblMinFiyat
            // 
            this.lblMinFiyat.AutoSize = true;
            this.lblMinFiyat.Location = new System.Drawing.Point(5, 29);
            this.lblMinFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinFiyat.Name = "lblMinFiyat";
            this.lblMinFiyat.Size = new System.Drawing.Size(59, 13);
            this.lblMinFiyat.TabIndex = 0;
            this.lblMinFiyat.Text = "Min. Fiyat";
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.BackColor = System.Drawing.Color.Gold;
            this.btnKarsilastir.Location = new System.Drawing.Point(1014, 16);
            this.btnKarsilastir.Margin = new System.Windows.Forms.Padding(2);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(176, 28);
            this.btnKarsilastir.TabIndex = 1;
            this.btnKarsilastir.Text = "Seçilileri Karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = false;
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
            this.IlanlarListView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlanlarListView.FullRowSelect = true;
            this.IlanlarListView.HideSelection = false;
            this.IlanlarListView.HoverSelection = true;
            this.IlanlarListView.Location = new System.Drawing.Point(215, 16);
            this.IlanlarListView.Margin = new System.Windows.Forms.Padding(2);
            this.IlanlarListView.Name = "IlanlarListView";
            this.IlanlarListView.Size = new System.Drawing.Size(755, 500);
            this.IlanlarListView.TabIndex = 0;
            this.IlanlarListView.UseCompatibleStateImageBehavior = false;
            this.IlanlarListView.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "İlan Id";
            this.colId.Width = 150;
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
            // YorumPage
            // 
            this.YorumPage.Controls.Add(this.gBoxYorum);
            this.YorumPage.Location = new System.Drawing.Point(4, 22);
            this.YorumPage.Margin = new System.Windows.Forms.Padding(2);
            this.YorumPage.Name = "YorumPage";
            this.YorumPage.Size = new System.Drawing.Size(1234, 529);
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
            this.gBoxYorum.Location = new System.Drawing.Point(504, 108);
            this.gBoxYorum.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxYorum.Name = "gBoxYorum";
            this.gBoxYorum.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxYorum.Size = new System.Drawing.Size(229, 288);
            this.gBoxYorum.TabIndex = 0;
            this.gBoxYorum.TabStop = false;
            this.gBoxYorum.Text = "Yorum Ekle";
            // 
            // btnYorumEkle
            // 
            this.btnYorumEkle.BackColor = System.Drawing.Color.Gold;
            this.btnYorumEkle.Location = new System.Drawing.Point(27, 247);
            this.btnYorumEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnYorumEkle.Name = "btnYorumEkle";
            this.btnYorumEkle.Size = new System.Drawing.Size(176, 28);
            this.btnYorumEkle.TabIndex = 4;
            this.btnYorumEkle.Text = "Yorum Yap";
            this.btnYorumEkle.UseVisualStyleBackColor = false;
            this.btnYorumEkle.Click += new System.EventHandler(this.btnYorumEkle_Click);
            // 
            // txtYorumMetni
            // 
            this.txtYorumMetni.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYorumMetni.Location = new System.Drawing.Point(94, 105);
            this.txtYorumMetni.Margin = new System.Windows.Forms.Padding(2);
            this.txtYorumMetni.Multiline = true;
            this.txtYorumMetni.Name = "txtYorumMetni";
            this.txtYorumMetni.Size = new System.Drawing.Size(120, 111);
            this.txtYorumMetni.TabIndex = 3;
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Location = new System.Drawing.Point(12, 107);
            this.lblYorum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYorum.Size = new System.Drawing.Size(41, 13);
            this.lblYorum.TabIndex = 2;
            this.lblYorum.Text = "Yorum";
            // 
            // txtIlanId
            // 
            this.txtIlanId.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlanId.Location = new System.Drawing.Point(94, 65);
            this.txtIlanId.Margin = new System.Windows.Forms.Padding(2);
            this.txtIlanId.Name = "txtIlanId";
            this.txtIlanId.Size = new System.Drawing.Size(120, 22);
            this.txtIlanId.TabIndex = 3;
            // 
            // lblIlanId
            // 
            this.lblIlanId.AutoSize = true;
            this.lblIlanId.Location = new System.Drawing.Point(12, 67);
            this.lblIlanId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIlanId.Name = "lblIlanId";
            this.lblIlanId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIlanId.Size = new System.Drawing.Size(39, 13);
            this.lblIlanId.TabIndex = 2;
            this.lblIlanId.Text = "İlan Id";
            // 
            // txtAracSahibiAdi
            // 
            this.txtAracSahibiAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracSahibiAdi.Location = new System.Drawing.Point(94, 29);
            this.txtAracSahibiAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracSahibiAdi.Name = "txtAracSahibiAdi";
            this.txtAracSahibiAdi.Size = new System.Drawing.Size(120, 22);
            this.txtAracSahibiAdi.TabIndex = 1;
            // 
            // lblAracSahibi
            // 
            this.lblAracSahibi.AutoSize = true;
            this.lblAracSahibi.Location = new System.Drawing.Point(12, 32);
            this.lblAracSahibi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAracSahibi.Name = "lblAracSahibi";
            this.lblAracSahibi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAracSahibi.Size = new System.Drawing.Size(65, 13);
            this.lblAracSahibi.TabIndex = 0;
            this.lblAracSahibi.Text = "Araç Sahibi";
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1264, 577);
            this.Controls.Add(this.tabMusteri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            this.tabMusteri.ResumeLayout(false);
            this.araclarPage.ResumeLayout(false);
            this.gBoxAyrintilar.ResumeLayout(false);
            this.gBoxAyrintilar.PerformLayout();
            this.gBoxFiltreler.ResumeLayout(false);
            this.gBoxFiltreler.PerformLayout();
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