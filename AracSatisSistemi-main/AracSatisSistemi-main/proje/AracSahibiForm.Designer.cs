
namespace proje
{
    partial class AracSahibiForm
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
            this.lblAracTuru = new System.Windows.Forms.Label();
            this.AracSahibiTab = new System.Windows.Forms.TabControl();
            this.IlanEklePage = new System.Windows.Forms.TabPage();
            this.btnIlanEkle = new System.Windows.Forms.Button();
            this.checkedDonanimlar = new System.Windows.Forms.CheckedListBox();
            this.dPickerUretimYili = new System.Windows.Forms.DateTimePicker();
            this.cBoxYakitTuru = new System.Windows.Forms.ComboBox();
            this.cBoxAracTuru = new System.Windows.Forms.ComboBox();
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
            this.IlanSilPage = new System.Windows.Forms.TabPage();
            this.btnIlanSil = new System.Windows.Forms.Button();
            this.IlanDuzenleListView = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKilometre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIlanDuzenle = new System.Windows.Forms.Button();
            this.lblYeniFiyat = new System.Windows.Forms.Label();
            this.txtYeniFiyat = new System.Windows.Forms.TextBox();
            this.AracSahibiTab.SuspendLayout();
            this.IlanEklePage.SuspendLayout();
            this.IlanSilPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAracTuru
            // 
            this.lblAracTuru.AutoSize = true;
            this.lblAracTuru.Location = new System.Drawing.Point(19, 22);
            this.lblAracTuru.Name = "lblAracTuru";
            this.lblAracTuru.Size = new System.Drawing.Size(71, 17);
            this.lblAracTuru.TabIndex = 0;
            this.lblAracTuru.Text = "Araç Türü";
            // 
            // AracSahibiTab
            // 
            this.AracSahibiTab.Controls.Add(this.IlanEklePage);
            this.AracSahibiTab.Controls.Add(this.IlanSilPage);
            this.AracSahibiTab.Location = new System.Drawing.Point(13, 13);
            this.AracSahibiTab.Name = "AracSahibiTab";
            this.AracSahibiTab.SelectedIndex = 0;
            this.AracSahibiTab.Size = new System.Drawing.Size(1099, 569);
            this.AracSahibiTab.TabIndex = 1;
            // 
            // IlanEklePage
            // 
            this.IlanEklePage.Controls.Add(this.btnIlanEkle);
            this.IlanEklePage.Controls.Add(this.checkedDonanimlar);
            this.IlanEklePage.Controls.Add(this.dPickerUretimYili);
            this.IlanEklePage.Controls.Add(this.cBoxYakitTuru);
            this.IlanEklePage.Controls.Add(this.cBoxAracTuru);
            this.IlanEklePage.Controls.Add(this.txtAracFiyat);
            this.IlanEklePage.Controls.Add(this.txtAracKm);
            this.IlanEklePage.Controls.Add(this.txtSanziman);
            this.IlanEklePage.Controls.Add(this.txtAracModel);
            this.IlanEklePage.Controls.Add(this.txtAracMarka);
            this.IlanEklePage.Controls.Add(this.txtAracMotor);
            this.IlanEklePage.Controls.Add(this.lblDonanimlar);
            this.IlanEklePage.Controls.Add(this.lblFiyat);
            this.IlanEklePage.Controls.Add(this.lblUretimYili);
            this.IlanEklePage.Controls.Add(this.lblKm);
            this.IlanEklePage.Controls.Add(this.lblMotor);
            this.IlanEklePage.Controls.Add(this.lblSanziman);
            this.IlanEklePage.Controls.Add(this.lblYakit);
            this.IlanEklePage.Controls.Add(this.lblModel);
            this.IlanEklePage.Controls.Add(this.lblMarka);
            this.IlanEklePage.Controls.Add(this.lblAracTuru);
            this.IlanEklePage.Location = new System.Drawing.Point(4, 25);
            this.IlanEklePage.Name = "IlanEklePage";
            this.IlanEklePage.Padding = new System.Windows.Forms.Padding(3);
            this.IlanEklePage.Size = new System.Drawing.Size(1011, 540);
            this.IlanEklePage.TabIndex = 0;
            this.IlanEklePage.Text = "İlan Ekle";
            this.IlanEklePage.UseVisualStyleBackColor = true;
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.Location = new System.Drawing.Point(106, 478);
            this.btnIlanEkle.Name = "btnIlanEkle";
            this.btnIlanEkle.Size = new System.Drawing.Size(75, 40);
            this.btnIlanEkle.TabIndex = 20;
            this.btnIlanEkle.Text = "Ekle";
            this.btnIlanEkle.UseVisualStyleBackColor = true;
            this.btnIlanEkle.Click += new System.EventHandler(this.btnIlanEkle_Click);
            // 
            // checkedDonanimlar
            // 
            this.checkedDonanimlar.FormattingEnabled = true;
            this.checkedDonanimlar.Location = new System.Drawing.Point(146, 334);
            this.checkedDonanimlar.Name = "checkedDonanimlar";
            this.checkedDonanimlar.Size = new System.Drawing.Size(146, 123);
            this.checkedDonanimlar.TabIndex = 19;
            // 
            // dPickerUretimYili
            // 
            this.dPickerUretimYili.Location = new System.Drawing.Point(146, 261);
            this.dPickerUretimYili.Name = "dPickerUretimYili";
            this.dPickerUretimYili.Size = new System.Drawing.Size(182, 22);
            this.dPickerUretimYili.TabIndex = 18;
            // 
            // cBoxYakitTuru
            // 
            this.cBoxYakitTuru.FormattingEnabled = true;
            this.cBoxYakitTuru.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.cBoxYakitTuru.Location = new System.Drawing.Point(146, 121);
            this.cBoxYakitTuru.Name = "cBoxYakitTuru";
            this.cBoxYakitTuru.Size = new System.Drawing.Size(100, 24);
            this.cBoxYakitTuru.TabIndex = 17;
            // 
            // cBoxAracTuru
            // 
            this.cBoxAracTuru.FormattingEnabled = true;
            this.cBoxAracTuru.Items.AddRange(new object[] {
            "Otomobil",
            "Suv"});
            this.cBoxAracTuru.Location = new System.Drawing.Point(146, 19);
            this.cBoxAracTuru.Name = "cBoxAracTuru";
            this.cBoxAracTuru.Size = new System.Drawing.Size(100, 24);
            this.cBoxAracTuru.TabIndex = 16;
            // 
            // txtAracFiyat
            // 
            this.txtAracFiyat.Location = new System.Drawing.Point(146, 295);
            this.txtAracFiyat.Name = "txtAracFiyat";
            this.txtAracFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtAracFiyat.TabIndex = 15;
            // 
            // txtAracKm
            // 
            this.txtAracKm.Location = new System.Drawing.Point(146, 228);
            this.txtAracKm.Name = "txtAracKm";
            this.txtAracKm.Size = new System.Drawing.Size(100, 22);
            this.txtAracKm.TabIndex = 14;
            // 
            // txtSanziman
            // 
            this.txtSanziman.Location = new System.Drawing.Point(146, 155);
            this.txtSanziman.Name = "txtSanziman";
            this.txtSanziman.Size = new System.Drawing.Size(100, 22);
            this.txtSanziman.TabIndex = 13;
            // 
            // txtAracModel
            // 
            this.txtAracModel.Location = new System.Drawing.Point(146, 85);
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.Size = new System.Drawing.Size(100, 22);
            this.txtAracModel.TabIndex = 12;
            // 
            // txtAracMarka
            // 
            this.txtAracMarka.Location = new System.Drawing.Point(146, 51);
            this.txtAracMarka.Name = "txtAracMarka";
            this.txtAracMarka.Size = new System.Drawing.Size(100, 22);
            this.txtAracMarka.TabIndex = 11;
            // 
            // txtAracMotor
            // 
            this.txtAracMotor.Location = new System.Drawing.Point(146, 192);
            this.txtAracMotor.Name = "txtAracMotor";
            this.txtAracMotor.Size = new System.Drawing.Size(100, 22);
            this.txtAracMotor.TabIndex = 10;
            // 
            // lblDonanimlar
            // 
            this.lblDonanimlar.AutoSize = true;
            this.lblDonanimlar.Location = new System.Drawing.Point(19, 334);
            this.lblDonanimlar.Name = "lblDonanimlar";
            this.lblDonanimlar.Size = new System.Drawing.Size(80, 17);
            this.lblDonanimlar.TabIndex = 9;
            this.lblDonanimlar.Text = "Donanımlar";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(19, 298);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblUretimYili
            // 
            this.lblUretimYili.AutoSize = true;
            this.lblUretimYili.Location = new System.Drawing.Point(19, 266);
            this.lblUretimYili.Name = "lblUretimYili";
            this.lblUretimYili.Size = new System.Drawing.Size(71, 17);
            this.lblUretimYili.TabIndex = 7;
            this.lblUretimYili.Text = "Üretim Yılı";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(19, 231);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(67, 17);
            this.lblKm.TabIndex = 6;
            this.lblKm.Text = "Kilometre";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(19, 195);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(44, 17);
            this.lblMotor.TabIndex = 5;
            this.lblMotor.Text = "Motor";
            // 
            // lblSanziman
            // 
            this.lblSanziman.AutoSize = true;
            this.lblSanziman.Location = new System.Drawing.Point(19, 158);
            this.lblSanziman.Name = "lblSanziman";
            this.lblSanziman.Size = new System.Drawing.Size(70, 17);
            this.lblSanziman.TabIndex = 4;
            this.lblSanziman.Text = "Şanzıman";
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Location = new System.Drawing.Point(19, 124);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(73, 17);
            this.lblYakit.TabIndex = 3;
            this.lblYakit.Text = "Yakıt Türü";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(19, 88);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(19, 54);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "Marka";
            // 
            // IlanSilPage
            // 
            this.IlanSilPage.Controls.Add(this.txtYeniFiyat);
            this.IlanSilPage.Controls.Add(this.lblYeniFiyat);
            this.IlanSilPage.Controls.Add(this.btnIlanDuzenle);
            this.IlanSilPage.Controls.Add(this.btnIlanSil);
            this.IlanSilPage.Controls.Add(this.IlanDuzenleListView);
            this.IlanSilPage.Location = new System.Drawing.Point(4, 25);
            this.IlanSilPage.Name = "IlanSilPage";
            this.IlanSilPage.Padding = new System.Windows.Forms.Padding(3);
            this.IlanSilPage.Size = new System.Drawing.Size(1091, 540);
            this.IlanSilPage.TabIndex = 1;
            this.IlanSilPage.Text = "İlan Sil/Duzenle";
            this.IlanSilPage.UseVisualStyleBackColor = true;
            // 
            // btnIlanSil
            // 
            this.btnIlanSil.Location = new System.Drawing.Point(772, 6);
            this.btnIlanSil.Name = "btnIlanSil";
            this.btnIlanSil.Size = new System.Drawing.Size(112, 61);
            this.btnIlanSil.TabIndex = 3;
            this.btnIlanSil.Text = "Seçili İlanları Sil";
            this.btnIlanSil.UseVisualStyleBackColor = true;
            this.btnIlanSil.Click += new System.EventHandler(this.btnIlanSil_Click);
            // 
            // IlanDuzenleListView
            // 
            this.IlanDuzenleListView.CheckBoxes = true;
            this.IlanDuzenleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colMarka,
            this.colModel,
            this.colFiyat,
            this.colKilometre});
            this.IlanDuzenleListView.FullRowSelect = true;
            this.IlanDuzenleListView.HideSelection = false;
            this.IlanDuzenleListView.HoverSelection = true;
            this.IlanDuzenleListView.Location = new System.Drawing.Point(6, 6);
            this.IlanDuzenleListView.Name = "IlanDuzenleListView";
            this.IlanDuzenleListView.Size = new System.Drawing.Size(760, 400);
            this.IlanDuzenleListView.TabIndex = 2;
            this.IlanDuzenleListView.UseCompatibleStateImageBehavior = false;
            this.IlanDuzenleListView.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Ilan Id";
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
            // btnIlanDuzenle
            // 
            this.btnIlanDuzenle.Location = new System.Drawing.Point(890, 6);
            this.btnIlanDuzenle.Name = "btnIlanDuzenle";
            this.btnIlanDuzenle.Size = new System.Drawing.Size(112, 61);
            this.btnIlanDuzenle.TabIndex = 4;
            this.btnIlanDuzenle.Text = "Seçili İlanı Düzenle";
            this.btnIlanDuzenle.UseVisualStyleBackColor = true;
            this.btnIlanDuzenle.Click += new System.EventHandler(this.btnIlanDuzenle_Click);
            // 
            // lblYeniFiyat
            // 
            this.lblYeniFiyat.AutoSize = true;
            this.lblYeniFiyat.Location = new System.Drawing.Point(773, 97);
            this.lblYeniFiyat.Name = "lblYeniFiyat";
            this.lblYeniFiyat.Size = new System.Drawing.Size(70, 17);
            this.lblYeniFiyat.TabIndex = 5;
            this.lblYeniFiyat.Text = "Yeni Fiyat";
            // 
            // txtYeniFiyat
            // 
            this.txtYeniFiyat.Location = new System.Drawing.Point(864, 94);
            this.txtYeniFiyat.Name = "txtYeniFiyat";
            this.txtYeniFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtYeniFiyat.TabIndex = 6;
            // 
            // AracSahibiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 613);
            this.Controls.Add(this.AracSahibiTab);
            this.Name = "AracSahibiForm";
            this.Text = "AracSahibiForm";
            this.Load += new System.EventHandler(this.AracSahibiForm_Load);
            this.AracSahibiTab.ResumeLayout(false);
            this.IlanEklePage.ResumeLayout(false);
            this.IlanEklePage.PerformLayout();
            this.IlanSilPage.ResumeLayout(false);
            this.IlanSilPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAracTuru;
        private System.Windows.Forms.TabControl AracSahibiTab;
        private System.Windows.Forms.TabPage IlanEklePage;
        private System.Windows.Forms.TabPage IlanSilPage;
        private System.Windows.Forms.Label lblUretimYili;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblSanziman;
        private System.Windows.Forms.Label lblYakit;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblDonanimlar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnIlanEkle;
        private System.Windows.Forms.CheckedListBox checkedDonanimlar;
        private System.Windows.Forms.DateTimePicker dPickerUretimYili;
        private System.Windows.Forms.ComboBox cBoxYakitTuru;
        private System.Windows.Forms.ComboBox cBoxAracTuru;
        private System.Windows.Forms.TextBox txtAracFiyat;
        private System.Windows.Forms.TextBox txtAracKm;
        private System.Windows.Forms.TextBox txtSanziman;
        private System.Windows.Forms.TextBox txtAracModel;
        private System.Windows.Forms.TextBox txtAracMarka;
        private System.Windows.Forms.TextBox txtAracMotor;
        private System.Windows.Forms.ListView IlanDuzenleListView;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colMarka;
        private System.Windows.Forms.ColumnHeader colModel;
        private System.Windows.Forms.ColumnHeader colFiyat;
        private System.Windows.Forms.ColumnHeader colKilometre;
        private System.Windows.Forms.Button btnIlanSil;
        private System.Windows.Forms.Button btnIlanDuzenle;
        private System.Windows.Forms.TextBox txtYeniFiyat;
        private System.Windows.Forms.Label lblYeniFiyat;
    }
}