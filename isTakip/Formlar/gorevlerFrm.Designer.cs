namespace isTakip.Formlar
{
    partial class gorevlerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gorevlerFrm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.yenileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DuzenleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ekleBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(847, 300);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // yenileBtn
            // 
            this.yenileBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("yenileBtn.ImageOptions.Image")));
            this.yenileBtn.Location = new System.Drawing.Point(703, 306);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(132, 35);
            this.yenileBtn.TabIndex = 10;
            this.yenileBtn.Text = "YENİLE";
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // DuzenleBtn
            // 
            this.DuzenleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DuzenleBtn.ImageOptions.Image")));
            this.DuzenleBtn.Location = new System.Drawing.Point(545, 306);
            this.DuzenleBtn.Name = "DuzenleBtn";
            this.DuzenleBtn.Size = new System.Drawing.Size(132, 35);
            this.DuzenleBtn.TabIndex = 9;
            this.DuzenleBtn.Text = "DÜZENLE";
            this.DuzenleBtn.Click += new System.EventHandler(this.DuzenleBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtn.ImageOptions.Image")));
            this.ekleBtn.Location = new System.Drawing.Point(389, 306);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(132, 35);
            this.ekleBtn.TabIndex = 8;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // gorevlerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 369);
            this.Controls.Add(this.yenileBtn);
            this.Controls.Add(this.DuzenleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.gridControl1);
            this.Name = "gorevlerFrm";
            this.Text = "Görevler";
            this.Load += new System.EventHandler(this.gorevlerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton yenileBtn;
        private DevExpress.XtraEditors.SimpleButton DuzenleBtn;
        private DevExpress.XtraEditors.SimpleButton ekleBtn;
    }
}