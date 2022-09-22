namespace isTakip.Formlar
{
    partial class mudurlukGuncelleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mudurlukGuncelleFrm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.mudurlukAdTe = new DevExpress.XtraEditors.TextEdit();
            this.vazgecBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.mudurluklerGrd = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.mudurlukAdTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mudurluklerGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Müdürlük Ad:";
            // 
            // mudurlukAdTe
            // 
            this.mudurlukAdTe.Location = new System.Drawing.Point(83, 42);
            this.mudurlukAdTe.Name = "mudurlukAdTe";
            this.mudurlukAdTe.Size = new System.Drawing.Size(178, 20);
            this.mudurlukAdTe.TabIndex = 2;
            // 
            // vazgecBtn
            // 
            this.vazgecBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("vazgecBtn.ImageOptions.Image")));
            this.vazgecBtn.Location = new System.Drawing.Point(24, 95);
            this.vazgecBtn.Name = "vazgecBtn";
            this.vazgecBtn.Size = new System.Drawing.Size(95, 30);
            this.vazgecBtn.TabIndex = 8;
            this.vazgecBtn.Text = "VAZGEÇ";
            this.vazgecBtn.Click += new System.EventHandler(this.vazgecBtn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.vazgecBtn);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.mudurlukAdTe);
            this.panelControl1.Controls.Add(this.guncelleBtn);
            this.panelControl1.Location = new System.Drawing.Point(438, 70);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(284, 141);
            this.panelControl1.TabIndex = 7;
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.Location = new System.Drawing.Point(152, 95);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(95, 30);
            this.guncelleBtn.TabIndex = 6;
            this.guncelleBtn.Text = "GÜNCELLE";
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // mudurluklerGrd
            // 
            this.mudurluklerGrd.Location = new System.Drawing.Point(6, 12);
            this.mudurluklerGrd.MainView = this.gridView1;
            this.mudurluklerGrd.Name = "mudurluklerGrd";
            this.mudurluklerGrd.Size = new System.Drawing.Size(426, 303);
            this.mudurluklerGrd.TabIndex = 8;
            this.mudurluklerGrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.mudurluklerGrd;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // mudurlukGuncelleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 311);
            this.Controls.Add(this.mudurluklerGrd);
            this.Controls.Add(this.panelControl1);
            this.Name = "mudurlukGuncelleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müdürlük Güncelleme";
            this.Load += new System.EventHandler(this.mudurlukGuncelleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mudurlukAdTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mudurluklerGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit mudurlukAdTe;
        private DevExpress.XtraEditors.SimpleButton vazgecBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraGrid.GridControl mudurluklerGrd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}