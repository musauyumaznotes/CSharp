
namespace Klasör_İşlemleri
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
            this.btnKlasorOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.btnKlasorSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnYolVarMı = new DevExpress.XtraEditors.SimpleButton();
            this.btnOlusturmaTarihi = new DevExpress.XtraEditors.SimpleButton();
            this.btnAktifProgramYolu = new DevExpress.XtraEditors.SimpleButton();
            this.btnProgramFiles = new DevExpress.XtraEditors.SimpleButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKlasorAdDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuruculer = new DevExpress.XtraEditors.SimpleButton();
            this.btnUstDizin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKlasorOlustur
            // 
            this.btnKlasorOlustur.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlasorOlustur.Appearance.Options.UseFont = true;
            this.btnKlasorOlustur.Location = new System.Drawing.Point(0, 0);
            this.btnKlasorOlustur.Name = "btnKlasorOlustur";
            this.btnKlasorOlustur.Size = new System.Drawing.Size(168, 56);
            this.btnKlasorOlustur.TabIndex = 0;
            this.btnKlasorOlustur.Text = "Klasör oluştur";
            this.btnKlasorOlustur.Click += new System.EventHandler(this.btnKlasorOlustur_Click);
            // 
            // btnKlasorSil
            // 
            this.btnKlasorSil.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlasorSil.Appearance.Options.UseFont = true;
            this.btnKlasorSil.Location = new System.Drawing.Point(0, 62);
            this.btnKlasorSil.Name = "btnKlasorSil";
            this.btnKlasorSil.Size = new System.Drawing.Size(168, 56);
            this.btnKlasorSil.TabIndex = 1;
            this.btnKlasorSil.Text = "Klasör Sil";
            this.btnKlasorSil.Click += new System.EventHandler(this.btnKlasorSil_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(309, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Klasör Adı:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(411, 26);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(261, 30);
            this.textEdit1.TabIndex = 3;
            // 
            // btnYolVarMı
            // 
            this.btnYolVarMı.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolVarMı.Appearance.Options.UseFont = true;
            this.btnYolVarMı.Location = new System.Drawing.Point(0, 124);
            this.btnYolVarMı.Name = "btnYolVarMı";
            this.btnYolVarMı.Size = new System.Drawing.Size(168, 56);
            this.btnYolVarMı.TabIndex = 4;
            this.btnYolVarMı.Text = "Klasör Var Mı";
            this.btnYolVarMı.Click += new System.EventHandler(this.btnYolVarMı_Click);
            // 
            // btnOlusturmaTarihi
            // 
            this.btnOlusturmaTarihi.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlusturmaTarihi.Appearance.Options.UseFont = true;
            this.btnOlusturmaTarihi.Location = new System.Drawing.Point(0, 186);
            this.btnOlusturmaTarihi.Name = "btnOlusturmaTarihi";
            this.btnOlusturmaTarihi.Size = new System.Drawing.Size(168, 56);
            this.btnOlusturmaTarihi.TabIndex = 5;
            this.btnOlusturmaTarihi.Text = "Oluşturulma Tarihi";
            this.btnOlusturmaTarihi.Click += new System.EventHandler(this.btnOlusturmaTarihi_Click);
            // 
            // btnAktifProgramYolu
            // 
            this.btnAktifProgramYolu.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktifProgramYolu.Appearance.Options.UseFont = true;
            this.btnAktifProgramYolu.Location = new System.Drawing.Point(0, 248);
            this.btnAktifProgramYolu.Name = "btnAktifProgramYolu";
            this.btnAktifProgramYolu.Size = new System.Drawing.Size(168, 56);
            this.btnAktifProgramYolu.TabIndex = 6;
            this.btnAktifProgramYolu.Text = "Aktif Program Yolu";
            this.btnAktifProgramYolu.Click += new System.EventHandler(this.btnAktifProgramYolu_Click);
            // 
            // btnProgramFiles
            // 
            this.btnProgramFiles.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProgramFiles.Appearance.Options.UseFont = true;
            this.btnProgramFiles.Location = new System.Drawing.Point(0, 310);
            this.btnProgramFiles.Name = "btnProgramFiles";
            this.btnProgramFiles.Size = new System.Drawing.Size(168, 56);
            this.btnProgramFiles.TabIndex = 7;
            this.btnProgramFiles.Text = "Program Files";
            this.btnProgramFiles.Click += new System.EventHandler(this.btnProgramFiles_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(395, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 276);
            this.listBox1.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(494, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(205, 24);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Program Files Dosyalar";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(0, 372);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(168, 56);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Son Erişim Zamanı";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnKlasorAdDegistir
            // 
            this.btnKlasorAdDegistir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlasorAdDegistir.Appearance.Options.UseFont = true;
            this.btnKlasorAdDegistir.Location = new System.Drawing.Point(174, 372);
            this.btnKlasorAdDegistir.Name = "btnKlasorAdDegistir";
            this.btnKlasorAdDegistir.Size = new System.Drawing.Size(168, 56);
            this.btnKlasorAdDegistir.TabIndex = 11;
            this.btnKlasorAdDegistir.Text = "Klasör Ad Değiştir";
            this.btnKlasorAdDegistir.Click += new System.EventHandler(this.btnKlasorAdDegistir_Click);
            // 
            // btnSuruculer
            // 
            this.btnSuruculer.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSuruculer.Appearance.Options.UseFont = true;
            this.btnSuruculer.Location = new System.Drawing.Point(174, 310);
            this.btnSuruculer.Name = "btnSuruculer";
            this.btnSuruculer.Size = new System.Drawing.Size(168, 56);
            this.btnSuruculer.TabIndex = 12;
            this.btnSuruculer.Text = "Sürücüler";
            this.btnSuruculer.Click += new System.EventHandler(this.btnSuruculer_Click);
            // 
            // btnUstDizin
            // 
            this.btnUstDizin.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUstDizin.Appearance.Options.UseFont = true;
            this.btnUstDizin.Location = new System.Drawing.Point(174, 248);
            this.btnUstDizin.Name = "btnUstDizin";
            this.btnUstDizin.Size = new System.Drawing.Size(168, 56);
            this.btnUstDizin.TabIndex = 13;
            this.btnUstDizin.Text = "Üst Dizin";
            this.btnUstDizin.Click += new System.EventHandler(this.btnUstDizin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUstDizin);
            this.Controls.Add(this.btnSuruculer);
            this.Controls.Add(this.btnKlasorAdDegistir);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnProgramFiles);
            this.Controls.Add(this.btnAktifProgramYolu);
            this.Controls.Add(this.btnOlusturmaTarihi);
            this.Controls.Add(this.btnYolVarMı);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKlasorSil);
            this.Controls.Add(this.btnKlasorOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKlasorOlustur;
        private DevExpress.XtraEditors.SimpleButton btnKlasorSil;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnYolVarMı;
        private DevExpress.XtraEditors.SimpleButton btnOlusturmaTarihi;
        private DevExpress.XtraEditors.SimpleButton btnAktifProgramYolu;
        private DevExpress.XtraEditors.SimpleButton btnProgramFiles;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnKlasorAdDegistir;
        private DevExpress.XtraEditors.SimpleButton btnSuruculer;
        private DevExpress.XtraEditors.SimpleButton btnUstDizin;
    }
}

