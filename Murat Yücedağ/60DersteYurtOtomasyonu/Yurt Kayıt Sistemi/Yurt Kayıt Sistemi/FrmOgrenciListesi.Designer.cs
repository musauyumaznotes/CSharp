
namespace Yurt_Kayıt_Sistemi
{
    partial class FrmOgrenciListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciListesi));
            this.yurtKayitDataSet4 = new Yurt_Kayıt_Sistemi.YurtKayitDataSet4();
            this.ogrenciListeleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciListeleTableAdapter = new Yurt_Kayıt_Sistemi.YurtKayitDataSet4TableAdapters.OgrenciListeleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAnaformTableAdapter1 = new Yurt_Kayıt_Sistemi.YurtKayitDataSet1TableAdapters.OgrenciAnaformTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListeleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yurtKayitDataSet4
            // 
            this.yurtKayitDataSet4.DataSetName = "YurtKayitDataSet4";
            this.yurtKayitDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciListeleBindingSource
            // 
            this.ogrenciListeleBindingSource.DataMember = "OgrenciListele";
            this.ogrenciListeleBindingSource.DataSource = this.yurtKayitDataSet4;
            // 
            // ogrenciListeleTableAdapter
            // 
            this.ogrenciListeleTableAdapter.ClearBeforeFill = true;
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
            this.tcDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.odaNoDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.veliAdSoyadDataGridViewTextBoxColumn,
            this.veliTelefonDataGridViewTextBoxColumn,
            this.veliAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciListeleBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 545);
            this.dataGridView1.TabIndex = 0;
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
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "Tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "Tc";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // veliAdSoyadDataGridViewTextBoxColumn
            // 
            this.veliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "VeliAdSoyad";
            this.veliAdSoyadDataGridViewTextBoxColumn.HeaderText = "VeliAdSoyad";
            this.veliAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliAdSoyadDataGridViewTextBoxColumn.Name = "veliAdSoyadDataGridViewTextBoxColumn";
            // 
            // veliTelefonDataGridViewTextBoxColumn
            // 
            this.veliTelefonDataGridViewTextBoxColumn.DataPropertyName = "VeliTelefon";
            this.veliTelefonDataGridViewTextBoxColumn.HeaderText = "VeliTelefon";
            this.veliTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliTelefonDataGridViewTextBoxColumn.Name = "veliTelefonDataGridViewTextBoxColumn";
            // 
            // veliAdresDataGridViewTextBoxColumn
            // 
            this.veliAdresDataGridViewTextBoxColumn.DataPropertyName = "VeliAdres";
            this.veliAdresDataGridViewTextBoxColumn.HeaderText = "VeliAdres";
            this.veliAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliAdresDataGridViewTextBoxColumn.Name = "veliAdresDataGridViewTextBoxColumn";
            // 
            // ogrenciAnaformTableAdapter1
            // 
            this.ogrenciAnaformTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1330, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmOgrenciListesi";
            this.Text = "FrmOgrenciListesi";
            this.Load += new System.EventHandler(this.FrmOgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListeleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private YurtKayitDataSet4 yurtKayitDataSet4;
        private System.Windows.Forms.BindingSource ogrenciListeleBindingSource;
        private YurtKayitDataSet4TableAdapters.OgrenciListeleTableAdapter ogrenciListeleTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdresDataGridViewTextBoxColumn;
        private YurtKayitDataSet1TableAdapters.OgrenciAnaformTableAdapter ogrenciAnaformTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}