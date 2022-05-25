
namespace proje
{
    partial class YoneticiForm
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
            this.YoneticiTab = new System.Windows.Forms.TabControl();
            this.DonanimPage = new System.Windows.Forms.TabPage();
            this.btnDonanimEkle = new System.Windows.Forms.Button();
            this.lblEklenecekDonanim = new System.Windows.Forms.Label();
            this.txtEklenecekDonanim = new System.Windows.Forms.TextBox();
            this.lblTumDonanimlar = new System.Windows.Forms.Label();
            this.lBoxTumDonanimlar = new System.Windows.Forms.ListBox();
            this.IlanOnayPage = new System.Windows.Forms.TabPage();
            this.OnayBekleyenIlanlarListView = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKilometre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIlanOnayla = new System.Windows.Forms.Button();
            this.YoneticiTab.SuspendLayout();
            this.DonanimPage.SuspendLayout();
            this.IlanOnayPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // YoneticiTab
            // 
            this.YoneticiTab.Controls.Add(this.DonanimPage);
            this.YoneticiTab.Controls.Add(this.IlanOnayPage);
            this.YoneticiTab.Location = new System.Drawing.Point(3, 4);
            this.YoneticiTab.Name = "YoneticiTab";
            this.YoneticiTab.SelectedIndex = 0;
            this.YoneticiTab.Size = new System.Drawing.Size(1082, 559);
            this.YoneticiTab.TabIndex = 0;
            // 
            // DonanimPage
            // 
            this.DonanimPage.Controls.Add(this.btnDonanimEkle);
            this.DonanimPage.Controls.Add(this.lblEklenecekDonanim);
            this.DonanimPage.Controls.Add(this.txtEklenecekDonanim);
            this.DonanimPage.Controls.Add(this.lblTumDonanimlar);
            this.DonanimPage.Controls.Add(this.lBoxTumDonanimlar);
            this.DonanimPage.Location = new System.Drawing.Point(4, 25);
            this.DonanimPage.Name = "DonanimPage";
            this.DonanimPage.Padding = new System.Windows.Forms.Padding(3);
            this.DonanimPage.Size = new System.Drawing.Size(1074, 530);
            this.DonanimPage.TabIndex = 1;
            this.DonanimPage.Text = "Donanım Ekle";
            this.DonanimPage.UseVisualStyleBackColor = true;
            this.DonanimPage.Click += new System.EventHandler(this.DonanimPage_Click);
            // 
            // btnDonanimEkle
            // 
            this.btnDonanimEkle.Location = new System.Drawing.Point(160, 296);
            this.btnDonanimEkle.Name = "btnDonanimEkle";
            this.btnDonanimEkle.Size = new System.Drawing.Size(158, 23);
            this.btnDonanimEkle.TabIndex = 4;
            this.btnDonanimEkle.Text = "Ekle";
            this.btnDonanimEkle.UseVisualStyleBackColor = true;
            this.btnDonanimEkle.Click += new System.EventHandler(this.btnDonanimEkle_Click);
            // 
            // lblEklenecekDonanim
            // 
            this.lblEklenecekDonanim.AutoSize = true;
            this.lblEklenecekDonanim.Location = new System.Drawing.Point(24, 245);
            this.lblEklenecekDonanim.Name = "lblEklenecekDonanim";
            this.lblEklenecekDonanim.Size = new System.Drawing.Size(133, 17);
            this.lblEklenecekDonanim.TabIndex = 3;
            this.lblEklenecekDonanim.Text = "Eklenecek Donanım";
            // 
            // txtEklenecekDonanim
            // 
            this.txtEklenecekDonanim.Location = new System.Drawing.Point(160, 242);
            this.txtEklenecekDonanim.Name = "txtEklenecekDonanim";
            this.txtEklenecekDonanim.Size = new System.Drawing.Size(158, 22);
            this.txtEklenecekDonanim.TabIndex = 2;
            // 
            // lblTumDonanimlar
            // 
            this.lblTumDonanimlar.AutoSize = true;
            this.lblTumDonanimlar.Location = new System.Drawing.Point(24, 22);
            this.lblTumDonanimlar.Name = "lblTumDonanimlar";
            this.lblTumDonanimlar.Size = new System.Drawing.Size(130, 17);
            this.lblTumDonanimlar.TabIndex = 1;
            this.lblTumDonanimlar.Text = " Mevcut Donanmlar";
            // 
            // lBoxTumDonanimlar
            // 
            this.lBoxTumDonanimlar.FormattingEnabled = true;
            this.lBoxTumDonanimlar.ItemHeight = 16;
            this.lBoxTumDonanimlar.Location = new System.Drawing.Point(160, 22);
            this.lBoxTumDonanimlar.Name = "lBoxTumDonanimlar";
            this.lBoxTumDonanimlar.Size = new System.Drawing.Size(158, 180);
            this.lBoxTumDonanimlar.TabIndex = 0;
            // 
            // IlanOnayPage
            // 
            this.IlanOnayPage.Controls.Add(this.btnIlanOnayla);
            this.IlanOnayPage.Controls.Add(this.OnayBekleyenIlanlarListView);
            this.IlanOnayPage.Location = new System.Drawing.Point(4, 25);
            this.IlanOnayPage.Name = "IlanOnayPage";
            this.IlanOnayPage.Padding = new System.Windows.Forms.Padding(3);
            this.IlanOnayPage.Size = new System.Drawing.Size(1074, 530);
            this.IlanOnayPage.TabIndex = 2;
            this.IlanOnayPage.Text = "Ilan Onay";
            this.IlanOnayPage.UseVisualStyleBackColor = true;
            // 
            // OnayBekleyenIlanlarListView
            // 
            this.OnayBekleyenIlanlarListView.CheckBoxes = true;
            this.OnayBekleyenIlanlarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colMarka,
            this.colModel,
            this.colFiyat,
            this.colKilometre});
            this.OnayBekleyenIlanlarListView.FullRowSelect = true;
            this.OnayBekleyenIlanlarListView.HideSelection = false;
            this.OnayBekleyenIlanlarListView.HoverSelection = true;
            this.OnayBekleyenIlanlarListView.Location = new System.Drawing.Point(6, 6);
            this.OnayBekleyenIlanlarListView.Name = "OnayBekleyenIlanlarListView";
            this.OnayBekleyenIlanlarListView.Size = new System.Drawing.Size(760, 400);
            this.OnayBekleyenIlanlarListView.TabIndex = 1;
            this.OnayBekleyenIlanlarListView.UseCompatibleStateImageBehavior = false;
            this.OnayBekleyenIlanlarListView.View = System.Windows.Forms.View.Details;
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
            // btnIlanOnayla
            // 
            this.btnIlanOnayla.Location = new System.Drawing.Point(772, 6);
            this.btnIlanOnayla.Name = "btnIlanOnayla";
            this.btnIlanOnayla.Size = new System.Drawing.Size(113, 58);
            this.btnIlanOnayla.TabIndex = 2;
            this.btnIlanOnayla.Text = "Seçili İlanları Onayla";
            this.btnIlanOnayla.UseVisualStyleBackColor = true;
            this.btnIlanOnayla.Click += new System.EventHandler(this.btnIlanOnayla_Click);
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 575);
            this.Controls.Add(this.YoneticiTab);
            this.Name = "YoneticiForm";
            this.Text = "YoneticiForm";
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.YoneticiTab.ResumeLayout(false);
            this.DonanimPage.ResumeLayout(false);
            this.DonanimPage.PerformLayout();
            this.IlanOnayPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl YoneticiTab;
        private System.Windows.Forms.TabPage DonanimPage;
        private System.Windows.Forms.Button btnDonanimEkle;
        private System.Windows.Forms.Label lblEklenecekDonanim;
        private System.Windows.Forms.TextBox txtEklenecekDonanim;
        private System.Windows.Forms.Label lblTumDonanimlar;
        private System.Windows.Forms.ListBox lBoxTumDonanimlar;
        private System.Windows.Forms.TabPage IlanOnayPage;
        private System.Windows.Forms.ListView OnayBekleyenIlanlarListView;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colMarka;
        private System.Windows.Forms.ColumnHeader colModel;
        private System.Windows.Forms.ColumnHeader colFiyat;
        private System.Windows.Forms.ColumnHeader colKilometre;
        private System.Windows.Forms.Button btnIlanOnayla;
    }
}