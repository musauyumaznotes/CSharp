
namespace Devexpress_3
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
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ratingControl1 = new DevExpress.XtraEditors.RatingControl();
            this.monthEdit1 = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.timeZoneEdit1 = new DevExpress.XtraScheduler.UI.TimeZoneEdit();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.weekDaysEdit1 = new DevExpress.XtraScheduler.UI.WeekDaysEdit();
            this.weekDaysCheckEdit1 = new DevExpress.XtraScheduler.UI.WeekDaysCheckEdit();
            this.weekOfMonthEdit1 = new DevExpress.XtraScheduler.UI.WeekOfMonthEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeZoneEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekOfMonthEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(311, 54);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(125, 22);
            this.progressBarControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(71, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(194, 64);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Progress Bar Değer Arttır";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ratingControl1
            // 
            this.ratingControl1.Location = new System.Drawing.Point(173, 103);
            this.ratingControl1.Name = "ratingControl1";
            this.ratingControl1.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ratingControl1.Size = new System.Drawing.Size(92, 16);
            this.ratingControl1.TabIndex = 2;
            this.ratingControl1.Text = "ratingControl1";
            // 
            // monthEdit1
            // 
            this.monthEdit1.Location = new System.Drawing.Point(311, 97);
            this.monthEdit1.Name = "monthEdit1";
            this.monthEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.monthEdit1.Size = new System.Drawing.Size(136, 22);
            this.monthEdit1.TabIndex = 3;
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("İstanbul"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Ankara"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("İzmir"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Adana"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Bursa")});
            this.checkedListBoxControl1.Location = new System.Drawing.Point(9, 125);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(286, 139);
            this.checkedListBoxControl1.TabIndex = 4;
            // 
            // timeZoneEdit1
            // 
            this.timeZoneEdit1.Location = new System.Drawing.Point(484, 153);
            this.timeZoneEdit1.Name = "timeZoneEdit1";
            this.timeZoneEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeZoneEdit1.Size = new System.Drawing.Size(226, 22);
            this.timeZoneEdit1.TabIndex = 5;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(575, 278);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(178, 128);
            this.pdfViewer1.TabIndex = 6;
            // 
            // weekDaysEdit1
            // 
            this.weekDaysEdit1.Location = new System.Drawing.Point(628, 50);
            this.weekDaysEdit1.Name = "weekDaysEdit1";
            this.weekDaysEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weekDaysEdit1.Size = new System.Drawing.Size(125, 22);
            this.weekDaysEdit1.TabIndex = 7;
            // 
            // weekDaysCheckEdit1
            // 
            this.weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.weekDaysCheckEdit1.Appearance.Options.UseBackColor = true;
            this.weekDaysCheckEdit1.Location = new System.Drawing.Point(9, 323);
            this.weekDaysCheckEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.weekDaysCheckEdit1.Name = "weekDaysCheckEdit1";
            this.weekDaysCheckEdit1.Size = new System.Drawing.Size(184, 118);
            this.weekDaysCheckEdit1.TabIndex = 8;
            // 
            // weekOfMonthEdit1
            // 
            this.weekOfMonthEdit1.Location = new System.Drawing.Point(340, 278);
            this.weekOfMonthEdit1.Name = "weekOfMonthEdit1";
            this.weekOfMonthEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weekOfMonthEdit1.Size = new System.Drawing.Size(125, 22);
            this.weekOfMonthEdit1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weekOfMonthEdit1);
            this.Controls.Add(this.weekDaysCheckEdit1);
            this.Controls.Add(this.weekDaysEdit1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.timeZoneEdit1);
            this.Controls.Add(this.checkedListBoxControl1);
            this.Controls.Add(this.monthEdit1);
            this.Controls.Add(this.ratingControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.progressBarControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeZoneEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekOfMonthEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.RatingControl ratingControl1;
        private DevExpress.XtraScheduler.UI.MonthEdit monthEdit1;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.XtraScheduler.UI.TimeZoneEdit timeZoneEdit1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraScheduler.UI.WeekDaysEdit weekDaysEdit1;
        private DevExpress.XtraScheduler.UI.WeekDaysCheckEdit weekDaysCheckEdit1;
        private DevExpress.XtraScheduler.UI.WeekOfMonthEdit weekOfMonthEdit1;
    }
}

