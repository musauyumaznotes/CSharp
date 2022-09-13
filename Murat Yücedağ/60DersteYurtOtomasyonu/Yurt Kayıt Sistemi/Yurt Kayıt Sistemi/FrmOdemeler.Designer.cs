
namespace Yurt_Kayıt_Sistemi
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.txtOdenenMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet2 = new Yurt_Kayıt_Sistemi.YurtKayitDataSet2();
            this.borcDetayTableAdapter = new Yurt_Kayıt_Sistemi.YurtKayitDataSet2TableAdapters.BorcDetayTableAdapter();
            this.lblKalanBorc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Id:";
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(242, 309);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.ReadOnly = true;
            this.txtOgrenciId.Size = new System.Drawing.Size(200, 28);
            this.txtOgrenciId.TabIndex = 1;
            // 
            // txtOdenenMiktar
            // 
            this.txtOdenenMiktar.Location = new System.Drawing.Point(242, 411);
            this.txtOdenenMiktar.Name = "txtOdenenMiktar";
            this.txtOdenenMiktar.Size = new System.Drawing.Size(200, 28);
            this.txtOdenenMiktar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Location = new System.Drawing.Point(257, 497);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(155, 49);
            this.btnOdemeAl.TabIndex = 4;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = true;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.kalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borcDetayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 291);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // kalanBorcDataGridViewTextBoxColumn
            // 
            this.kalanBorcDataGridViewTextBoxColumn.DataPropertyName = "KalanBorc";
            this.kalanBorcDataGridViewTextBoxColumn.HeaderText = "KalanBorc";
            this.kalanBorcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalanBorcDataGridViewTextBoxColumn.Name = "kalanBorcDataGridViewTextBoxColumn";
            // 
            // borcDetayBindingSource
            // 
            this.borcDetayBindingSource.DataMember = "BorcDetay";
            this.borcDetayBindingSource.DataSource = this.yurtKayitDataSet2;
            // 
            // yurtKayitDataSet2
            // 
            this.yurtKayitDataSet2.DataSetName = "YurtKayitDataSet2";
            this.yurtKayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borcDetayTableAdapter
            // 
            this.borcDetayTableAdapter.ClearBeforeFill = true;
            // 
            // lblKalanBorc
            // 
            this.lblKalanBorc.AutoSize = true;
            this.lblKalanBorc.Font = new System.Drawing.Font("Georgia", 20F);
            this.lblKalanBorc.Location = new System.Drawing.Point(541, 433);
            this.lblKalanBorc.Name = "lblKalanBorc";
            this.lblKalanBorc.Size = new System.Drawing.Size(0, 39);
            this.lblKalanBorc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14F);
            this.label4.Location = new System.Drawing.Point(528, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kalan Borç";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.BackgroundImage")));
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.Location = new System.Drawing.Point(4, 461);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(95, 85);
            this.btnAnasayfa.TabIndex = 8;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(242, 343);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(200, 28);
            this.txtAd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ödenen Miktar:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(242, 377);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(200, 28);
            this.txtSoyad.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyad:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(242, 449);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 28);
            this.dtpTarih.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tarih:";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(697, 558);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKalanBorc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.txtOdenenMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmOdemeler";
            this.Text = "FrmOdemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.TextBox txtOdenenMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitDataSet2 yurtKayitDataSet2;
        private System.Windows.Forms.BindingSource borcDetayBindingSource;
        private YurtKayitDataSet2TableAdapters.BorcDetayTableAdapter borcDetayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblKalanBorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label6;
    }
}