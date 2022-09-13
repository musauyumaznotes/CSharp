
namespace Apartman_Kayıt_Uygulaması
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnDaireler = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorclar = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayitlar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFotograf = new DevExpress.XtraEditors.SimpleButton();
            this.btnHakkimizda = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnDaireler
            // 
            this.btnDaireler.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDaireler.Appearance.Options.UseFont = true;
            this.btnDaireler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaireler.ImageOptions.Image")));
            this.btnDaireler.Location = new System.Drawing.Point(59, 67);
            this.btnDaireler.Name = "btnDaireler";
            this.btnDaireler.Size = new System.Drawing.Size(194, 54);
            this.btnDaireler.TabIndex = 1;
            this.btnDaireler.Text = "Daireler";
            this.btnDaireler.Click += new System.EventHandler(this.btnDaireler_Click);
            // 
            // btnBorclar
            // 
            this.btnBorclar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBorclar.Appearance.Options.UseFont = true;
            this.btnBorclar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorclar.ImageOptions.Image")));
            this.btnBorclar.Location = new System.Drawing.Point(317, 67);
            this.btnBorclar.Name = "btnBorclar";
            this.btnBorclar.Size = new System.Drawing.Size(194, 54);
            this.btnBorclar.TabIndex = 2;
            this.btnBorclar.Text = "Borçlar";
            this.btnBorclar.Click += new System.EventHandler(this.btnBorclar_Click);
            // 
            // btnKayitlar
            // 
            this.btnKayitlar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnKayitlar.Appearance.Options.UseFont = true;
            this.btnKayitlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitlar.ImageOptions.Image")));
            this.btnKayitlar.Location = new System.Drawing.Point(59, 185);
            this.btnKayitlar.Name = "btnKayitlar";
            this.btnKayitlar.Size = new System.Drawing.Size(194, 54);
            this.btnKayitlar.TabIndex = 3;
            this.btnKayitlar.Text = "Kayıtlar";
            this.btnKayitlar.Click += new System.EventHandler(this.btnKayitlar_Click);
            // 
            // btnFotograf
            // 
            this.btnFotograf.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFotograf.Appearance.Options.UseFont = true;
            this.btnFotograf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFotograf.ImageOptions.Image")));
            this.btnFotograf.Location = new System.Drawing.Point(317, 185);
            this.btnFotograf.Name = "btnFotograf";
            this.btnFotograf.Size = new System.Drawing.Size(194, 54);
            this.btnFotograf.TabIndex = 4;
            this.btnFotograf.Text = "Fotoğraflar";
            this.btnFotograf.Click += new System.EventHandler(this.btnFotograf_Click);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnHakkimizda.Appearance.Options.UseFont = true;
            this.btnHakkimizda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkimizda.ImageOptions.Image")));
            this.btnHakkimizda.Location = new System.Drawing.Point(59, 293);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(194, 54);
            this.btnHakkimizda.TabIndex = 5;
            this.btnHakkimizda.Text = "Hakkımızda";
            this.btnHakkimizda.Click += new System.EventHandler(this.btnHakkimizda_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(317, 293);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(194, 54);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHakkimizda);
            this.Controls.Add(this.btnFotograf);
            this.Controls.Add(this.btnKayitlar);
            this.Controls.Add(this.btnBorclar);
            this.Controls.Add(this.btnDaireler);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDaireler;
        private DevExpress.XtraEditors.SimpleButton btnBorclar;
        private DevExpress.XtraEditors.SimpleButton btnKayitlar;
        private DevExpress.XtraEditors.SimpleButton btnFotograf;
        private DevExpress.XtraEditors.SimpleButton btnHakkimizda;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}