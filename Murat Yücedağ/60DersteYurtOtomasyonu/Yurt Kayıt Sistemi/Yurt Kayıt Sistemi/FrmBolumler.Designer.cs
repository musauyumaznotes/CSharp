
namespace Yurt_Kayıt_Sistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.pcbBolumSil = new System.Windows.Forms.PictureBox();
            this.pcbBolumGuncelle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet = new Yurt_Kayıt_Sistemi.YurtKayitDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.bolumlerTableAdapter = new Yurt_Kayıt_Sistemi.YurtKayitDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBolumEkle
            // 
            this.pcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumEkle.Image")));
            this.pcbBolumEkle.Location = new System.Drawing.Point(377, 101);
            this.pcbBolumEkle.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBolumEkle.Name = "pcbBolumEkle";
            this.pcbBolumEkle.Size = new System.Drawing.Size(60, 63);
            this.pcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBolumEkle.TabIndex = 0;
            this.pcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumEkle, "Bölüm Ekle");
            this.pcbBolumEkle.Click += new System.EventHandler(this.pcbBolumEkle_Click);
            // 
            // pcbBolumSil
            // 
            this.pcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumSil.Image")));
            this.pcbBolumSil.Location = new System.Drawing.Point(546, 101);
            this.pcbBolumSil.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBolumSil.Name = "pcbBolumSil";
            this.pcbBolumSil.Size = new System.Drawing.Size(60, 63);
            this.pcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBolumSil.TabIndex = 1;
            this.pcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumSil, "Bölüm Sil");
            this.pcbBolumSil.Click += new System.EventHandler(this.pcbBolumSil_Click);
            // 
            // pcbBolumGuncelle
            // 
            this.pcbBolumGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumGuncelle.Image")));
            this.pcbBolumGuncelle.Location = new System.Drawing.Point(459, 101);
            this.pcbBolumGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBolumGuncelle.Name = "pcbBolumGuncelle";
            this.pcbBolumGuncelle.Size = new System.Drawing.Size(60, 63);
            this.pcbBolumGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBolumGuncelle.TabIndex = 2;
            this.pcbBolumGuncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumGuncelle, "Bölüm Güncelle");
            this.pcbBolumGuncelle.Click += new System.EventHandler(this.pcbBolumGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(94, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(133, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 28);
            this.textBox1.TabIndex = 4;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(133, 144);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(214, 28);
            this.txtBolumAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 318);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtKayitDataSet;
            // 
            // yurtKayitDataSet
            // 
            this.yurtKayitDataSet.DataSetName = "YurtKayitDataSet";
            this.yurtKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 92);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(671, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbBolumGuncelle);
            this.Controls.Add(this.pcbBolumSil);
            this.Controls.Add(this.pcbBolumEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölüm Ekle";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBolumEkle;
        private System.Windows.Forms.PictureBox pcbBolumSil;
        private System.Windows.Forms.PictureBox pcbBolumGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private YurtKayitDataSet yurtKayitDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtKayitDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}