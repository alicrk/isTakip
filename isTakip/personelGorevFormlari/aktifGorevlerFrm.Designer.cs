namespace isTakip.personelGorevFormlari
{
    partial class aktifGorevlerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aktifGorevlerFrm));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.yenileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DuzenleBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(19, 10);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(847, 300);
            this.gridControl2.TabIndex = 15;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // yenileBtn
            // 
            this.yenileBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("yenileBtn.ImageOptions.Image")));
            this.yenileBtn.Location = new System.Drawing.Point(734, 316);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(132, 35);
            this.yenileBtn.TabIndex = 16;
            this.yenileBtn.Text = "YENİLE";
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // DuzenleBtn
            // 
            this.DuzenleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DuzenleBtn.ImageOptions.Image")));
            this.DuzenleBtn.Location = new System.Drawing.Point(579, 316);
            this.DuzenleBtn.Name = "DuzenleBtn";
            this.DuzenleBtn.Size = new System.Drawing.Size(132, 35);
            this.DuzenleBtn.TabIndex = 17;
            this.DuzenleBtn.Text = "DÜZENLE";
            this.DuzenleBtn.Click += new System.EventHandler(this.DuzenleBtn_Click);
            // 
            // aktifGorevlerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.DuzenleBtn);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.yenileBtn);
            this.Name = "aktifGorevlerFrm";
            this.Text = "Aktif Görevlerim";
            this.Load += new System.EventHandler(this.aktifGorevlerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraEditors.SimpleButton yenileBtn;
        private DevExpress.XtraEditors.SimpleButton DuzenleBtn;
    }
}