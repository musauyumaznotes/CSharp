
namespace Şehir_Tahmin_Oyunu
{
    partial class Form1
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
            this.grpOyunAlani = new System.Windows.Forms.GroupBox();
            this.grpCevapAlani = new System.Windows.Forms.GroupBox();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.btnHarfGir = new System.Windows.Forms.Button();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGirilenHarfler = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCevapAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOyunAlani
            // 
            this.grpOyunAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grpOyunAlani.Location = new System.Drawing.Point(136, 71);
            this.grpOyunAlani.Name = "grpOyunAlani";
            this.grpOyunAlani.Size = new System.Drawing.Size(543, 222);
            this.grpOyunAlani.TabIndex = 0;
            this.grpOyunAlani.TabStop = false;
            this.grpOyunAlani.Text = "Oyun Alanı";
            // 
            // grpCevapAlani
            // 
            this.grpCevapAlani.Controls.Add(this.lblKalanHak);
            this.grpCevapAlani.Controls.Add(this.label3);
            this.grpCevapAlani.Controls.Add(this.lblGirilenHarfler);
            this.grpCevapAlani.Controls.Add(this.label1);
            this.grpCevapAlani.Controls.Add(this.txtKelime);
            this.grpCevapAlani.Controls.Add(this.btnTahmin);
            this.grpCevapAlani.Controls.Add(this.btnHarfGir);
            this.grpCevapAlani.Controls.Add(this.txtHarf);
            this.grpCevapAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grpCevapAlani.Location = new System.Drawing.Point(136, 299);
            this.grpCevapAlani.Name = "grpCevapAlani";
            this.grpCevapAlani.Size = new System.Drawing.Size(543, 214);
            this.grpCevapAlani.TabIndex = 1;
            this.grpCevapAlani.TabStop = false;
            this.grpCevapAlani.Text = "Cevap Alanı";
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnYeniOyun.Location = new System.Drawing.Point(136, 13);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(543, 39);
            this.btnYeniOyun.TabIndex = 2;
            this.btnYeniOyun.Text = "Yeni Oyun Başlat";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // txtHarf
            // 
            this.txtHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtHarf.Location = new System.Drawing.Point(6, 47);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(117, 28);
            this.txtHarf.TabIndex = 0;
            // 
            // btnHarfGir
            // 
            this.btnHarfGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHarfGir.Location = new System.Drawing.Point(129, 35);
            this.btnHarfGir.Name = "btnHarfGir";
            this.btnHarfGir.Size = new System.Drawing.Size(145, 52);
            this.btnHarfGir.TabIndex = 3;
            this.btnHarfGir.Text = "Harf Gir";
            this.btnHarfGir.UseVisualStyleBackColor = true;
            this.btnHarfGir.Click += new System.EventHandler(this.btnHarfGir_Click);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTahmin.Location = new System.Drawing.Point(408, 35);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(135, 52);
            this.btnTahmin.TabIndex = 4;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtKelime.Location = new System.Drawing.Point(285, 47);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(117, 28);
            this.txtKelime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Girilen Harfler:";
            // 
            // lblGirilenHarfler
            // 
            this.lblGirilenHarfler.AutoSize = true;
            this.lblGirilenHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblGirilenHarfler.Location = new System.Drawing.Point(136, 123);
            this.lblGirilenHarfler.Name = "lblGirilenHarfler";
            this.lblGirilenHarfler.Size = new System.Drawing.Size(0, 24);
            this.lblGirilenHarfler.TabIndex = 7;
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKalanHak.Location = new System.Drawing.Point(103, 161);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(20, 24);
            this.lblKalanHak.TabIndex = 9;
            this.lblKalanHak.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(7, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kalan Hak:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.grpCevapAlani);
            this.Controls.Add(this.grpOyunAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCevapAlani.ResumeLayout(false);
            this.grpCevapAlani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOyunAlani;
        private System.Windows.Forms.GroupBox grpCevapAlani;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGirilenHarfler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Button btnHarfGir;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button btnYeniOyun;
    }
}

