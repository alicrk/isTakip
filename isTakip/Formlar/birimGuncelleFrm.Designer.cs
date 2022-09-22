namespace isTakip.Formlar
{
    partial class birimGuncelleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(birimGuncelleFrm));
            this.birimlerGrd = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vazgecBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.mudurlukAdLe = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.birimAdTe = new DevExpress.XtraEditors.TextEdit();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mudurlukAdLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimAdTe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // birimlerGrd
            // 
            this.birimlerGrd.Location = new System.Drawing.Point(9, 4);
            this.birimlerGrd.MainView = this.gridView1;
            this.birimlerGrd.Name = "birimlerGrd";
            this.birimlerGrd.Size = new System.Drawing.Size(426, 303);
            this.birimlerGrd.TabIndex = 10;
            this.birimlerGrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.birimlerGrd;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // vazgecBtn
            // 
            this.vazgecBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("vazgecBtn.ImageOptions.Image")));
            this.vazgecBtn.Location = new System.Drawing.Point(470, 196);
            this.vazgecBtn.Name = "vazgecBtn";
            this.vazgecBtn.Size = new System.Drawing.Size(95, 30);
            this.vazgecBtn.TabIndex = 13;
            this.vazgecBtn.Text = "VAZGEÇ";
            this.vazgecBtn.Click += new System.EventHandler(this.vazgecBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Müdürlük Ad:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mudurlukAdLe);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.birimAdTe);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(441, 69);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(284, 94);
            this.panelControl1.TabIndex = 12;
            // 
            // mudurlukAdLe
            // 
            this.mudurlukAdLe.EditValue = "";
            this.mudurlukAdLe.Location = new System.Drawing.Point(83, 57);
            this.mudurlukAdLe.Name = "mudurlukAdLe";
            this.mudurlukAdLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mudurlukAdLe.Size = new System.Drawing.Size(178, 20);
            this.mudurlukAdLe.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Birim Ad:";
            // 
            // birimAdTe
            // 
            this.birimAdTe.Location = new System.Drawing.Point(83, 22);
            this.birimAdTe.Name = "birimAdTe";
            this.birimAdTe.Size = new System.Drawing.Size(178, 20);
            this.birimAdTe.TabIndex = 4;
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.Location = new System.Drawing.Point(607, 196);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(95, 30);
            this.guncelleBtn.TabIndex = 14;
            this.guncelleBtn.Text = "GÜNCELLE";
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // birimGuncelleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 311);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.vazgecBtn);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.birimlerGrd);
            this.Name = "birimGuncelleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birim Güncelle";
            this.Load += new System.EventHandler(this.birimGuncelleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birimlerGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mudurlukAdLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimAdTe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl birimlerGrd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton vazgecBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit mudurlukAdLe;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit birimAdTe;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
    }
}