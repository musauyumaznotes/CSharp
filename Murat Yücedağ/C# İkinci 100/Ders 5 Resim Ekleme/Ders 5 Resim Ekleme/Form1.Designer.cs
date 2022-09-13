
namespace Ders_5_Resim_Ekleme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblFilmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_FilmArsivDataSet = new Ders_5_Resim_Ekleme.Dbo_FilmArsivDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbl_FilmlerTableAdapter = new Ders_5_Resim_Ekleme.Dbo_FilmArsivDataSetTableAdapters.Tbl_FilmlerTableAdapter();
            this.dbo_FilmArsivDataSet1 = new Ders_5_Resim_Ekleme.Dbo_FilmArsivDataSet1();
            this.tblFilmlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_FilmlerTableAdapter1 = new Ders_5_Resim_Ekleme.Dbo_FilmArsivDataSet1TableAdapters.Tbl_FilmlerTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmKategoriDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filmResimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_FilmArsivDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_FilmArsivDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 28);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türü:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 28);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puan:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 28);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategori:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 28);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resim:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(238, 28);
            this.textBox5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Film Id:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(95, 26);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(238, 28);
            this.textBox6.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(129, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(129, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(340, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(525, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.filmTurDataGridViewTextBoxColumn,
            this.filmPuanDataGridViewTextBoxColumn,
            this.filmKategoriDataGridViewCheckBoxColumn,
            this.filmResimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFilmlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 224);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tblFilmlerBindingSource
            // 
            this.tblFilmlerBindingSource.DataMember = "Tbl_Filmler";
            this.tblFilmlerBindingSource.DataSource = this.dbo_FilmArsivDataSet;
            // 
            // dbo_FilmArsivDataSet
            // 
            this.dbo_FilmArsivDataSet.DataSetName = "Dbo_FilmArsivDataSet";
            this.dbo_FilmArsivDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbl_FilmlerTableAdapter
            // 
            this.tbl_FilmlerTableAdapter.ClearBeforeFill = true;
            // 
            // dbo_FilmArsivDataSet1
            // 
            this.dbo_FilmArsivDataSet1.DataSetName = "Dbo_FilmArsivDataSet1";
            this.dbo_FilmArsivDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFilmlerBindingSource1
            // 
            this.tblFilmlerBindingSource1.DataMember = "Tbl_Filmler";
            this.tblFilmlerBindingSource1.DataSource = this.dbo_FilmArsivDataSet1;
            // 
            // tbl_FilmlerTableAdapter1
            // 
            this.tbl_FilmlerTableAdapter1.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            this.filmAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmTurDataGridViewTextBoxColumn
            // 
            this.filmTurDataGridViewTextBoxColumn.DataPropertyName = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.HeaderText = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmTurDataGridViewTextBoxColumn.Name = "filmTurDataGridViewTextBoxColumn";
            this.filmTurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmPuanDataGridViewTextBoxColumn
            // 
            this.filmPuanDataGridViewTextBoxColumn.DataPropertyName = "FilmPuan";
            this.filmPuanDataGridViewTextBoxColumn.HeaderText = "FilmPuan";
            this.filmPuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmPuanDataGridViewTextBoxColumn.Name = "filmPuanDataGridViewTextBoxColumn";
            this.filmPuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmKategoriDataGridViewCheckBoxColumn
            // 
            this.filmKategoriDataGridViewCheckBoxColumn.DataPropertyName = "FilmKategori";
            this.filmKategoriDataGridViewCheckBoxColumn.HeaderText = "FilmKategori";
            this.filmKategoriDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.filmKategoriDataGridViewCheckBoxColumn.Name = "filmKategoriDataGridViewCheckBoxColumn";
            this.filmKategoriDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // filmResimDataGridViewTextBoxColumn
            // 
            this.filmResimDataGridViewTextBoxColumn.DataPropertyName = "FilmResim";
            this.filmResimDataGridViewTextBoxColumn.HeaderText = "FilmResim";
            this.filmResimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmResimDataGridViewTextBoxColumn.Name = "filmResimDataGridViewTextBoxColumn";
            this.filmResimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_FilmArsivDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_FilmArsivDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Dbo_FilmArsivDataSet dbo_FilmArsivDataSet;
        private System.Windows.Forms.BindingSource tblFilmlerBindingSource;
        private Dbo_FilmArsivDataSetTableAdapters.Tbl_FilmlerTableAdapter tbl_FilmlerTableAdapter;
        private Dbo_FilmArsivDataSet1 dbo_FilmArsivDataSet1;
        private System.Windows.Forms.BindingSource tblFilmlerBindingSource1;
        private Dbo_FilmArsivDataSet1TableAdapters.Tbl_FilmlerTableAdapter tbl_FilmlerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn filmKategoriDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmResimDataGridViewTextBoxColumn;
    }
}

