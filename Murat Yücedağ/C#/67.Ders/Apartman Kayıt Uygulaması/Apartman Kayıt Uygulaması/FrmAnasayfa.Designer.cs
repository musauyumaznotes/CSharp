
namespace Apartman_Kayıt_Uygulaması
{
    partial class FrmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.textEditSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(182, 248);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(207, 66);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Giriş Yap";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(92, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // txtEditKullaniciAdi
            // 
            this.txtEditKullaniciAdi.Location = new System.Drawing.Point(228, 120);
            this.txtEditKullaniciAdi.Name = "txtEditKullaniciAdi";
            this.txtEditKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEditKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtEditKullaniciAdi.Size = new System.Drawing.Size(184, 28);
            this.txtEditKullaniciAdi.TabIndex = 2;
            // 
            // textEditSifre
            // 
            this.textEditSifre.Location = new System.Drawing.Point(228, 170);
            this.textEditSifre.Name = "textEditSifre";
            this.textEditSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditSifre.Properties.Appearance.Options.UseFont = true;
            this.textEditSifre.Size = new System.Drawing.Size(184, 28);
            this.textEditSifre.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(152, 173);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Şifre:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(32, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(471, 40);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "DevExpress Apartman Kayıt Uygulaması";
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(547, 396);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtEditKullaniciAdi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "FrmAnasayfa";
            this.Text = "Ana Form";
            ((System.ComponentModel.ISupportInitialize)(this.txtEditKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEditKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit textEditSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}