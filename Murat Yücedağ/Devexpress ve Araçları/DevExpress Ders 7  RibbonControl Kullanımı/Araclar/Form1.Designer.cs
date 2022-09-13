
namespace Araclar
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
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape5 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape6 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape7 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector2 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector3 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector4 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector5 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector6 = new DevExpress.XtraDiagram.DiagramConnector();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape3,
            this.diagramShape4,
            this.diagramShape5,
            this.diagramShape6,
            this.diagramShape7,
            this.diagramConnector1,
            this.diagramConnector2,
            this.diagramConnector3,
            this.diagramConnector4,
            this.diagramConnector5,
            this.diagramConnector6});
            this.diagramControl1.Location = new System.Drawing.Point(0, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.Size = new System.Drawing.Size(800, 450);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            // 
            // diagramShape1
            // 
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Tahoma", 36F);
            this.diagramShape1.Content = "PROJE YÖNETİCİSİ";
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(350F, 50F);
            this.diagramShape1.Size = new System.Drawing.SizeF(350F, 116.6667F);
            // 
            // diagramShape2
            // 
            this.diagramShape2.Appearance.Font = new System.Drawing.Font("Tahoma", 28F);
            this.diagramShape2.Content = "GELİŞTİRİCİ";
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(0F, 200F);
            this.diagramShape2.Size = new System.Drawing.SizeF(300F, 100F);
            // 
            // diagramShape3
            // 
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Tahoma", 28F);
            this.diagramShape3.Content = "TESTÇİ\r\n";
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(375F, 200F);
            this.diagramShape3.Size = new System.Drawing.SizeF(300F, 100F);
            // 
            // diagramShape4
            // 
            this.diagramShape4.Appearance.Font = new System.Drawing.Font("Tahoma", 28F);
            this.diagramShape4.Content = "ANALİST";
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(750F, 200F);
            this.diagramShape4.Size = new System.Drawing.SizeF(300F, 100F);
            // 
            // diagramShape5
            // 
            this.diagramShape5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.diagramShape5.Content = "WEB";
            this.diagramShape5.Position = new DevExpress.Utils.PointFloat(0F, 400F);
            this.diagramShape5.Size = new System.Drawing.SizeF(100F, 50F);
            // 
            // diagramShape6
            // 
            this.diagramShape6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.diagramShape6.Content = "MOBİL";
            this.diagramShape6.Position = new DevExpress.Utils.PointFloat(150F, 400F);
            this.diagramShape6.Size = new System.Drawing.SizeF(100F, 50F);
            // 
            // diagramShape7
            // 
            this.diagramShape7.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.diagramShape7.Content = "MASAÜSTÜ";
            this.diagramShape7.Position = new DevExpress.Utils.PointFloat(300F, 400F);
            this.diagramShape7.Size = new System.Drawing.SizeF(100F, 50F);
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginItem = this.diagramShape1;
            this.diagramConnector1.BeginItemPointIndex = 2;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(525F, 166.6667F);
            this.diagramConnector1.EndItem = this.diagramShape3;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(525F, 200F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            // 
            // diagramConnector2
            // 
            this.diagramConnector2.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector2.BeginItem = this.diagramShape1;
            this.diagramConnector2.BeginItemPointIndex = 2;
            this.diagramConnector2.BeginPoint = new DevExpress.Utils.PointFloat(525F, 166.6667F);
            this.diagramConnector2.EndItem = this.diagramShape4;
            this.diagramConnector2.EndItemPointIndex = 0;
            this.diagramConnector2.EndPoint = new DevExpress.Utils.PointFloat(900F, 200F);
            this.diagramConnector2.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(525F, 183F),
            new DevExpress.Utils.PointFloat(900F, 183F)});
            // 
            // diagramConnector3
            // 
            this.diagramConnector3.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector3.BeginItem = this.diagramShape1;
            this.diagramConnector3.BeginItemPointIndex = 2;
            this.diagramConnector3.BeginPoint = new DevExpress.Utils.PointFloat(525F, 166.6667F);
            this.diagramConnector3.EndItem = this.diagramShape2;
            this.diagramConnector3.EndItemPointIndex = 0;
            this.diagramConnector3.EndPoint = new DevExpress.Utils.PointFloat(150F, 200F);
            this.diagramConnector3.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(525F, 183F),
            new DevExpress.Utils.PointFloat(150F, 183F)});
            // 
            // diagramConnector4
            // 
            this.diagramConnector4.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector4.BeginItem = this.diagramShape2;
            this.diagramConnector4.BeginItemPointIndex = 2;
            this.diagramConnector4.BeginPoint = new DevExpress.Utils.PointFloat(150F, 300F);
            this.diagramConnector4.EndItem = this.diagramShape5;
            this.diagramConnector4.EndItemPointIndex = 0;
            this.diagramConnector4.EndPoint = new DevExpress.Utils.PointFloat(50F, 400F);
            this.diagramConnector4.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(150F, 390F),
            new DevExpress.Utils.PointFloat(50F, 390F)});
            // 
            // diagramConnector5
            // 
            this.diagramConnector5.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector5.BeginItem = this.diagramShape7;
            this.diagramConnector5.BeginItemPointIndex = 0;
            this.diagramConnector5.BeginPoint = new DevExpress.Utils.PointFloat(350F, 400F);
            this.diagramConnector5.EndItem = this.diagramShape6;
            this.diagramConnector5.EndItemPointIndex = 0;
            this.diagramConnector5.EndPoint = new DevExpress.Utils.PointFloat(200F, 400F);
            this.diagramConnector5.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(350F, 383F),
            new DevExpress.Utils.PointFloat(200F, 383F)});
            // 
            // diagramConnector6
            // 
            this.diagramConnector6.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector6.BeginItem = this.diagramShape2;
            this.diagramConnector6.BeginItemPointIndex = 2;
            this.diagramConnector6.BeginPoint = new DevExpress.Utils.PointFloat(150F, 300F);
            this.diagramConnector6.EndPoint = new DevExpress.Utils.PointFloat(200F, 400F);
            this.diagramConnector6.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(150F, 383F),
            new DevExpress.Utils.PointFloat(200F, 383F)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diagramControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramShape diagramShape3;
        private DevExpress.XtraDiagram.DiagramShape diagramShape4;
        private DevExpress.XtraDiagram.DiagramShape diagramShape5;
        private DevExpress.XtraDiagram.DiagramShape diagramShape6;
        private DevExpress.XtraDiagram.DiagramShape diagramShape7;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector1;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector2;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector3;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector4;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector5;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector6;
    }
}

