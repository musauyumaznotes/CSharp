
namespace DevExpress_Ders_7__RibbonControl_Kullanımı
{
    partial class FrmHarita
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
            DevExpress.XtraMap.MiniMap miniMap1 = new DevExpress.XtraMap.MiniMap();
            DevExpress.XtraMap.DynamicMiniMapBehavior dynamicMiniMapBehavior1 = new DevExpress.XtraMap.DynamicMiniMapBehavior();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.miniMapImageTilesLayer1 = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.miniMapVectorItemsLayer1 = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.bingMapDataProvider2 = new DevExpress.XtraMap.BingMapDataProvider();
            this.ımageLayer1 = new DevExpress.XtraMap.ImageLayer();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.ımageLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            miniMap1.Behavior = dynamicMiniMapBehavior1;
            miniMap1.Height = 1;
            miniMap1.Layers.Add(this.miniMapImageTilesLayer1);
            miniMap1.Layers.Add(this.miniMapVectorItemsLayer1);
            miniMap1.Width = 1;
            this.mapControl1.MiniMap = miniMap1;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(832, 330);
            this.mapControl1.TabIndex = 0;
            this.bingMapDataProvider1.BingKey = "YOUR BING MAPS KEY";
            this.miniMapImageTilesLayer1.DataProvider = this.bingMapDataProvider1;
            this.miniMapVectorItemsLayer1.Data = this.mapItemStorage1;
            this.bingMapDataProvider2.BingKey = "YOUR BING MAPS KEY";
            this.ımageLayer1.DataProvider = this.bingMapDataProvider2;
            // 
            // FrmHarita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 330);
            this.Controls.Add(this.mapControl1);
            this.Name = "FrmHarita";
            this.Text = "FrmHarita";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.MiniMapImageTilesLayer miniMapImageTilesLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.MiniMapVectorItemsLayer miniMapVectorItemsLayer1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
        private DevExpress.XtraMap.ImageLayer ımageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider2;
    }
}