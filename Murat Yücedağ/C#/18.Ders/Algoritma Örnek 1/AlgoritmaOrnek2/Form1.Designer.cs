
namespace AlgoritmaOrnek2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCiftSayilarToplam = new System.Windows.Forms.Label();
            this.lblTekSayilarToplam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(179, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "   Tek Sayılar\r\n------------------\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "   Çift Sayılar\r\n------------------\r\n";
            // 
            // lblCiftSayilarToplam
            // 
            this.lblCiftSayilarToplam.AutoSize = true;
            this.lblCiftSayilarToplam.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiftSayilarToplam.ForeColor = System.Drawing.Color.White;
            this.lblCiftSayilarToplam.Location = new System.Drawing.Point(312, 156);
            this.lblCiftSayilarToplam.Name = "lblCiftSayilarToplam";
            this.lblCiftSayilarToplam.Size = new System.Drawing.Size(19, 21);
            this.lblCiftSayilarToplam.TabIndex = 3;
            this.lblCiftSayilarToplam.Text = "0\r\n";
            // 
            // lblTekSayilarToplam
            // 
            this.lblTekSayilarToplam.AutoSize = true;
            this.lblTekSayilarToplam.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTekSayilarToplam.ForeColor = System.Drawing.Color.White;
            this.lblTekSayilarToplam.Location = new System.Drawing.Point(108, 156);
            this.lblTekSayilarToplam.Name = "lblTekSayilarToplam";
            this.lblTekSayilarToplam.Size = new System.Drawing.Size(19, 21);
            this.lblTekSayilarToplam.TabIndex = 4;
            this.lblTekSayilarToplam.Text = "0\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(166, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 30);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTekSayilarToplam);
            this.Controls.Add(this.lblCiftSayilarToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCiftSayilarToplam;
        private System.Windows.Forms.Label lblTekSayilarToplam;
        private System.Windows.Forms.TextBox textBox1;
    }
}

