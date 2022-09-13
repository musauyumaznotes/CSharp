
namespace Grafik_İşlemleri
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDeger1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtDeger2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDeger3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeger1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeger2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeger3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Değer-1";
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(108, 73);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDeger1.Properties.Appearance.Options.UseFont = true;
            this.txtDeger1.Size = new System.Drawing.Size(228, 28);
            this.txtDeger1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(118, 269);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(173, 59);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Grafik Oluştur";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(108, 116);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDeger2.Properties.Appearance.Options.UseFont = true;
            this.txtDeger2.Size = new System.Drawing.Size(228, 28);
            this.txtDeger2.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Değer-2";
            // 
            // txtDeger3
            // 
            this.txtDeger3.Location = new System.Drawing.Point(108, 164);
            this.txtDeger3.Name = "txtDeger3";
            this.txtDeger3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDeger3.Properties.Appearance.Options.UseFont = true;
            this.txtDeger3.Size = new System.Drawing.Size(228, 28);
            this.txtDeger3.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 22);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Değer-3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDeger3);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtDeger1);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.Text = "Grafik İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.txtDeger1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeger2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeger3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDeger1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtDeger2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDeger3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

