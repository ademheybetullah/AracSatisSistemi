
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracSahibiForm));
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
            this.txtYeniFiyat = new System.Windows.Forms.TextBox();
            this.lblYeniFiyat = new System.Windows.Forms.Label();
            this.btnIlanDuzenle = new System.Windows.Forms.Button();
            this.btnIlanSil = new System.Windows.Forms.Button();
            this.IlanDuzenleListView = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKilometre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AracSahibiTab.SuspendLayout();
            this.IlanEklePage.SuspendLayout();
            this.IlanSilPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAracTuru
            // 
            this.lblAracTuru.AutoSize = true;
            this.lblAracTuru.Location = new System.Drawing.Point(270, 20);
            this.lblAracTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAracTuru.Name = "lblAracTuru";
            this.lblAracTuru.Size = new System.Drawing.Size(56, 13);
            this.lblAracTuru.TabIndex = 0;
            this.lblAracTuru.Text = "Araç Türü";
            // 
            // AracSahibiTab
            // 
            this.AracSahibiTab.Controls.Add(this.IlanEklePage);
            this.AracSahibiTab.Controls.Add(this.IlanSilPage);
            this.AracSahibiTab.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracSahibiTab.Location = new System.Drawing.Point(10, 11);
            this.AracSahibiTab.Margin = new System.Windows.Forms.Padding(2);
            this.AracSahibiTab.Name = "AracSahibiTab";
            this.AracSahibiTab.SelectedIndex = 0;
            this.AracSahibiTab.Size = new System.Drawing.Size(798, 454);
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
            this.IlanEklePage.Location = new System.Drawing.Point(4, 22);
            this.IlanEklePage.Margin = new System.Windows.Forms.Padding(2);
            this.IlanEklePage.Name = "IlanEklePage";
            this.IlanEklePage.Padding = new System.Windows.Forms.Padding(2);
            this.IlanEklePage.Size = new System.Drawing.Size(790, 428);
            this.IlanEklePage.TabIndex = 0;
            this.IlanEklePage.Text = "İlan Ekle";
            this.IlanEklePage.UseVisualStyleBackColor = true;
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.BackColor = System.Drawing.Color.Gold;
            this.btnIlanEkle.Location = new System.Drawing.Point(300, 385);
            this.btnIlanEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnIlanEkle.Name = "btnIlanEkle";
            this.btnIlanEkle.Size = new System.Drawing.Size(176, 28);
            this.btnIlanEkle.TabIndex = 20;
            this.btnIlanEkle.Text = "Ekle";
            this.btnIlanEkle.UseVisualStyleBackColor = false;
            this.btnIlanEkle.Click += new System.EventHandler(this.btnIlanEkle_Click);
            // 
            // checkedDonanimlar
            // 
            this.checkedDonanimlar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedDonanimlar.FormattingEnabled = true;
            this.checkedDonanimlar.Location = new System.Drawing.Point(366, 273);
            this.checkedDonanimlar.Margin = new System.Windows.Forms.Padding(2);
            this.checkedDonanimlar.Name = "checkedDonanimlar";
            this.checkedDonanimlar.Size = new System.Drawing.Size(146, 89);
            this.checkedDonanimlar.TabIndex = 19;
            // 
            // dPickerUretimYili
            // 
            this.dPickerUretimYili.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dPickerUretimYili.Location = new System.Drawing.Point(366, 214);
            this.dPickerUretimYili.Margin = new System.Windows.Forms.Padding(2);
            this.dPickerUretimYili.Name = "dPickerUretimYili";
            this.dPickerUretimYili.Size = new System.Drawing.Size(146, 22);
            this.dPickerUretimYili.TabIndex = 18;
            // 
            // cBoxYakitTuru
            // 
            this.cBoxYakitTuru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxYakitTuru.FormattingEnabled = true;
            this.cBoxYakitTuru.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.cBoxYakitTuru.Location = new System.Drawing.Point(366, 100);
            this.cBoxYakitTuru.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxYakitTuru.Name = "cBoxYakitTuru";
            this.cBoxYakitTuru.Size = new System.Drawing.Size(96, 21);
            this.cBoxYakitTuru.TabIndex = 17;
            // 
            // cBoxAracTuru
            // 
            this.cBoxAracTuru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxAracTuru.FormattingEnabled = true;
            this.cBoxAracTuru.Items.AddRange(new object[] {
            "Otomobil",
            "Suv"});
            this.cBoxAracTuru.Location = new System.Drawing.Point(366, 17);
            this.cBoxAracTuru.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxAracTuru.Name = "cBoxAracTuru";
            this.cBoxAracTuru.Size = new System.Drawing.Size(96, 21);
            this.cBoxAracTuru.TabIndex = 16;
            // 
            // txtAracFiyat
            // 
            this.txtAracFiyat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracFiyat.Location = new System.Drawing.Point(366, 242);
            this.txtAracFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracFiyat.Name = "txtAracFiyat";
            this.txtAracFiyat.Size = new System.Drawing.Size(96, 22);
            this.txtAracFiyat.TabIndex = 15;
            // 
            // txtAracKm
            // 
            this.txtAracKm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracKm.Location = new System.Drawing.Point(366, 187);
            this.txtAracKm.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracKm.Name = "txtAracKm";
            this.txtAracKm.Size = new System.Drawing.Size(96, 22);
            this.txtAracKm.TabIndex = 14;
            // 
            // txtSanziman
            // 
            this.txtSanziman.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSanziman.Location = new System.Drawing.Point(366, 128);
            this.txtSanziman.Margin = new System.Windows.Forms.Padding(2);
            this.txtSanziman.Name = "txtSanziman";
            this.txtSanziman.Size = new System.Drawing.Size(96, 22);
            this.txtSanziman.TabIndex = 13;
            // 
            // txtAracModel
            // 
            this.txtAracModel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracModel.Location = new System.Drawing.Point(366, 71);
            this.txtAracModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.Size = new System.Drawing.Size(96, 22);
            this.txtAracModel.TabIndex = 12;
            // 
            // txtAracMarka
            // 
            this.txtAracMarka.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracMarka.Location = new System.Drawing.Point(366, 43);
            this.txtAracMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracMarka.Name = "txtAracMarka";
            this.txtAracMarka.Size = new System.Drawing.Size(96, 22);
            this.txtAracMarka.TabIndex = 11;
            // 
            // txtAracMotor
            // 
            this.txtAracMotor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracMotor.Location = new System.Drawing.Point(366, 158);
            this.txtAracMotor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracMotor.Name = "txtAracMotor";
            this.txtAracMotor.Size = new System.Drawing.Size(96, 22);
            this.txtAracMotor.TabIndex = 10;
            // 
            // lblDonanimlar
            // 
            this.lblDonanimlar.AutoSize = true;
            this.lblDonanimlar.Location = new System.Drawing.Point(270, 273);
            this.lblDonanimlar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonanimlar.Name = "lblDonanimlar";
            this.lblDonanimlar.Size = new System.Drawing.Size(68, 13);
            this.lblDonanimlar.TabIndex = 9;
            this.lblDonanimlar.Text = "Donanımlar";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(270, 244);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(32, 13);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblUretimYili
            // 
            this.lblUretimYili.AutoSize = true;
            this.lblUretimYili.Location = new System.Drawing.Point(270, 218);
            this.lblUretimYili.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUretimYili.Name = "lblUretimYili";
            this.lblUretimYili.Size = new System.Drawing.Size(61, 13);
            this.lblUretimYili.TabIndex = 7;
            this.lblUretimYili.Text = "Üretim Yılı";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(270, 190);
            this.lblKm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(57, 13);
            this.lblKm.TabIndex = 6;
            this.lblKm.Text = "Kilometre";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(270, 160);
            this.lblMotor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(40, 13);
            this.lblMotor.TabIndex = 5;
            this.lblMotor.Text = "Motor";
            // 
            // lblSanziman
            // 
            this.lblSanziman.AutoSize = true;
            this.lblSanziman.Location = new System.Drawing.Point(270, 130);
            this.lblSanziman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSanziman.Name = "lblSanziman";
            this.lblSanziman.Size = new System.Drawing.Size(57, 13);
            this.lblSanziman.TabIndex = 4;
            this.lblSanziman.Text = "Şanzıman";
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Location = new System.Drawing.Point(270, 103);
            this.lblYakit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(58, 13);
            this.lblYakit.TabIndex = 3;
            this.lblYakit.Text = "Yakıt Türü";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(270, 74);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(270, 46);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(40, 13);
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
            this.IlanSilPage.Location = new System.Drawing.Point(4, 22);
            this.IlanSilPage.Margin = new System.Windows.Forms.Padding(2);
            this.IlanSilPage.Name = "IlanSilPage";
            this.IlanSilPage.Padding = new System.Windows.Forms.Padding(2);
            this.IlanSilPage.Size = new System.Drawing.Size(790, 428);
            this.IlanSilPage.TabIndex = 1;
            this.IlanSilPage.Text = "İlan Sil/Duzenle";
            this.IlanSilPage.UseVisualStyleBackColor = true;
            // 
            // txtYeniFiyat
            // 
            this.txtYeniFiyat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniFiyat.Location = new System.Drawing.Point(683, 357);
            this.txtYeniFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniFiyat.Name = "txtYeniFiyat";
            this.txtYeniFiyat.Size = new System.Drawing.Size(76, 22);
            this.txtYeniFiyat.TabIndex = 6;
            // 
            // lblYeniFiyat
            // 
            this.lblYeniFiyat.AutoSize = true;
            this.lblYeniFiyat.Location = new System.Drawing.Point(615, 360);
            this.lblYeniFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYeniFiyat.Name = "lblYeniFiyat";
            this.lblYeniFiyat.Size = new System.Drawing.Size(57, 13);
            this.lblYeniFiyat.TabIndex = 5;
            this.lblYeniFiyat.Text = "Yeni Fiyat";
            // 
            // btnIlanDuzenle
            // 
            this.btnIlanDuzenle.BackColor = System.Drawing.Color.Gold;
            this.btnIlanDuzenle.Location = new System.Drawing.Point(600, 393);
            this.btnIlanDuzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btnIlanDuzenle.Name = "btnIlanDuzenle";
            this.btnIlanDuzenle.Size = new System.Drawing.Size(176, 28);
            this.btnIlanDuzenle.TabIndex = 4;
            this.btnIlanDuzenle.Text = "Seçili İlanı Düzenle";
            this.btnIlanDuzenle.UseVisualStyleBackColor = false;
            this.btnIlanDuzenle.Click += new System.EventHandler(this.btnIlanDuzenle_Click);
            // 
            // btnIlanSil
            // 
            this.btnIlanSil.BackColor = System.Drawing.Color.Gold;
            this.btnIlanSil.Location = new System.Drawing.Point(14, 393);
            this.btnIlanSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnIlanSil.Name = "btnIlanSil";
            this.btnIlanSil.Size = new System.Drawing.Size(176, 28);
            this.btnIlanSil.TabIndex = 3;
            this.btnIlanSil.Text = "Seçili İlanları Sil";
            this.btnIlanSil.UseVisualStyleBackColor = false;
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
            this.IlanDuzenleListView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlanDuzenleListView.FullRowSelect = true;
            this.IlanDuzenleListView.HideSelection = false;
            this.IlanDuzenleListView.HoverSelection = true;
            this.IlanDuzenleListView.Location = new System.Drawing.Point(14, 15);
            this.IlanDuzenleListView.Margin = new System.Windows.Forms.Padding(2);
            this.IlanDuzenleListView.Name = "IlanDuzenleListView";
            this.IlanDuzenleListView.Size = new System.Drawing.Size(762, 326);
            this.IlanDuzenleListView.TabIndex = 2;
            this.IlanDuzenleListView.UseCompatibleStateImageBehavior = false;
            this.IlanDuzenleListView.View = System.Windows.Forms.View.Details;
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
            // AracSahibiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(821, 475);
            this.Controls.Add(this.AracSahibiTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AracSahibiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Sahibi Paneli";
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