
namespace Apartman_Kayıt_Uygulaması
{
    partial class KayıtIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtIslemleri));
            this.btnVerileriGoster = new DevExpress.XtraEditors.SimpleButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAd = new DevExpress.XtraEditors.TextEdit();
            this.textEditSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditDaire = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditBorc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnasayfa = new DevExpress.XtraEditors.SimpleButton();
            this.textEditAra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDaire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBorc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerileriGoster
            // 
            this.btnVerileriGoster.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnVerileriGoster.Appearance.Options.UseFont = true;
            this.btnVerileriGoster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVerileriGoster.ImageOptions.Image")));
            this.btnVerileriGoster.Location = new System.Drawing.Point(12, 12);
            this.btnVerileriGoster.Name = "btnVerileriGoster";
            this.btnVerileriGoster.Size = new System.Drawing.Size(194, 54);
            this.btnVerileriGoster.TabIndex = 2;
            this.btnVerileriGoster.Text = "Verileri Göster";
            this.btnVerileriGoster.Click += new System.EventHandler(this.btnVerileriGoster_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 288);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(811, 212);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Daire";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Borç";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(212, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(194, 54);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 22);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Ad:";
            // 
            // textEditAd
            // 
            this.textEditAd.Location = new System.Drawing.Point(90, 84);
            this.textEditAd.Name = "textEditAd";
            this.textEditAd.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.textEditAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditAd.Properties.Appearance.Options.UseBackColor = true;
            this.textEditAd.Properties.Appearance.Options.UseFont = true;
            this.textEditAd.Size = new System.Drawing.Size(184, 28);
            this.textEditAd.TabIndex = 6;
            // 
            // textEditSoyad
            // 
            this.textEditSoyad.Location = new System.Drawing.Point(90, 118);
            this.textEditSoyad.Name = "textEditSoyad";
            this.textEditSoyad.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.textEditSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditSoyad.Properties.Appearance.Options.UseBackColor = true;
            this.textEditSoyad.Properties.Appearance.Options.UseFont = true;
            this.textEditSoyad.Size = new System.Drawing.Size(184, 28);
            this.textEditSoyad.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 22);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Soyad:";
            // 
            // textEditDaire
            // 
            this.textEditDaire.Location = new System.Drawing.Point(90, 152);
            this.textEditDaire.Name = "textEditDaire";
            this.textEditDaire.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.textEditDaire.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditDaire.Properties.Appearance.Options.UseBackColor = true;
            this.textEditDaire.Properties.Appearance.Options.UseFont = true;
            this.textEditDaire.Size = new System.Drawing.Size(184, 28);
            this.textEditDaire.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 155);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 22);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Daire:";
            // 
            // textEditTelefon
            // 
            this.textEditTelefon.Location = new System.Drawing.Point(90, 186);
            this.textEditTelefon.Name = "textEditTelefon";
            this.textEditTelefon.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.textEditTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditTelefon.Properties.Appearance.Options.UseBackColor = true;
            this.textEditTelefon.Properties.Appearance.Options.UseFont = true;
            this.textEditTelefon.Size = new System.Drawing.Size(184, 28);
            this.textEditTelefon.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 189);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 22);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Telefon:";
            // 
            // textEditMail
            // 
            this.textEditMail.Location = new System.Drawing.Point(90, 220);
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.textEditMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditMail.Properties.Appearance.Options.UseBackColor = true;
            this.textEditMail.Properties.Appearance.Options.UseFont = true;
            this.textEditMail.Size = new System.Drawing.Size(184, 28);
            this.textEditMail.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(47, 223);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 22);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Mail:";
            // 
            // textEditBorc
            // 
            this.textEditBorc.Location = new System.Drawing.Point(90, 254);
            this.textEditBorc.Name = "textEditBorc";
            this.textEditBorc.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.textEditBorc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditBorc.Properties.Appearance.Options.UseBackColor = true;
            this.textEditBorc.Properties.Appearance.Options.UseFont = true;
            this.textEditBorc.Size = new System.Drawing.Size(184, 28);
            this.textEditBorc.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(47, 257);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 22);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Borç:";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(412, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(194, 54);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(612, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(194, 54);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnAra.Location = new System.Drawing.Point(519, 171);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(194, 54);
            this.btnAra.TabIndex = 19;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAnasayfa.Appearance.Options.UseFont = true;
            this.btnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image2")));
            this.btnAnasayfa.Location = new System.Drawing.Point(-1, 506);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(132, 39);
            this.btnAnasayfa.TabIndex = 20;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // textEditAra
            // 
            this.textEditAra.Location = new System.Drawing.Point(551, 103);
            this.textEditAra.Name = "textEditAra";
            this.textEditAra.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textEditAra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditAra.Properties.Appearance.Options.UseBackColor = true;
            this.textEditAra.Properties.Appearance.Options.UseFont = true;
            this.textEditAra.Size = new System.Drawing.Size(184, 28);
            this.textEditAra.TabIndex = 22;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(441, 106);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(104, 22);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Aranacak Ad:";
            // 
            // KayıtIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(835, 544);
            this.Controls.Add(this.textEditAra);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.textEditBorc);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEditMail);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textEditTelefon);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditDaire);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditSoyad);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditAd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnVerileriGoster);
            this.Name = "KayıtIslemleri";
            this.Text = "KayıtIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDaire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBorc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnVerileriGoster;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditAd;
        private DevExpress.XtraEditors.TextEdit textEditSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditDaire;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditMail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditBorc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnAnasayfa;
        private DevExpress.XtraEditors.TextEdit textEditAra;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}