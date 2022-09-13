
namespace TaraftarTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkBoxFb = new System.Windows.Forms.CheckBox();
            this.checkBoxBjk = new System.Windows.Forms.CheckBox();
            this.checkBoxGs = new System.Windows.Forms.CheckBox();
            this.checkBoxTs = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 197);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 197);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 197);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(660, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 197);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 197);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(220, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 197);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(437, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 197);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(660, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(211, 197);
            this.button8.TabIndex = 4;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // checkBoxFb
            // 
            this.checkBoxFb.AutoSize = true;
            this.checkBoxFb.Location = new System.Drawing.Point(57, 418);
            this.checkBoxFb.Name = "checkBoxFb";
            this.checkBoxFb.Size = new System.Drawing.Size(102, 20);
            this.checkBoxFb.TabIndex = 8;
            this.checkBoxFb.Text = "Fenerbahçe";
            this.checkBoxFb.UseVisualStyleBackColor = true;
            this.checkBoxFb.CheckedChanged += new System.EventHandler(this.checkBoxFb_CheckedChanged);
            // 
            // checkBoxBjk
            // 
            this.checkBoxBjk.AutoSize = true;
            this.checkBoxBjk.Location = new System.Drawing.Point(205, 418);
            this.checkBoxBjk.Name = "checkBoxBjk";
            this.checkBoxBjk.Size = new System.Drawing.Size(81, 20);
            this.checkBoxBjk.TabIndex = 9;
            this.checkBoxBjk.Text = "Beşiktaş";
            this.checkBoxBjk.UseVisualStyleBackColor = true;
            this.checkBoxBjk.CheckedChanged += new System.EventHandler(this.checkBoxBjk_CheckedChanged);
            // 
            // checkBoxGs
            // 
            this.checkBoxGs.AutoSize = true;
            this.checkBoxGs.Location = new System.Drawing.Point(344, 418);
            this.checkBoxGs.Name = "checkBoxGs";
            this.checkBoxGs.Size = new System.Drawing.Size(103, 20);
            this.checkBoxGs.TabIndex = 10;
            this.checkBoxGs.Text = "Galatasaray";
            this.checkBoxGs.UseVisualStyleBackColor = true;
            this.checkBoxGs.CheckedChanged += new System.EventHandler(this.checkBoxGs_CheckedChanged);
            // 
            // checkBoxTs
            // 
            this.checkBoxTs.AutoSize = true;
            this.checkBoxTs.Location = new System.Drawing.Point(494, 418);
            this.checkBoxTs.Name = "checkBoxTs";
            this.checkBoxTs.Size = new System.Drawing.Size(106, 20);
            this.checkBoxTs.TabIndex = 11;
            this.checkBoxTs.Text = "Trabzonspor";
            this.checkBoxTs.UseVisualStyleBackColor = true;
            this.checkBoxTs.CheckedChanged += new System.EventHandler(this.checkBoxTs_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(642, 406);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(224, 32);
            this.axWindowsMediaPlayer1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.checkBoxTs);
            this.Controls.Add(this.checkBoxGs);
            this.Controls.Add(this.checkBoxBjk);
            this.Controls.Add(this.checkBoxFb);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox checkBoxFb;
        private System.Windows.Forms.CheckBox checkBoxBjk;
        private System.Windows.Forms.CheckBox checkBoxGs;
        private System.Windows.Forms.CheckBox checkBoxTs;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

