﻿namespace isTakip.Formlar
{
    partial class MudurluklerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MudurluklerFrm));
            this.mudurluklerGrd = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.yenileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.silBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ekleBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mudurluklerGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mudurluklerGrd
            // 
            this.mudurluklerGrd.Location = new System.Drawing.Point(105, 5);
            this.mudurluklerGrd.MainView = this.gridView1;
            this.mudurluklerGrd.Name = "mudurluklerGrd";
            this.mudurluklerGrd.Size = new System.Drawing.Size(636, 302);
            this.mudurluklerGrd.TabIndex = 6;
            this.mudurluklerGrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.mudurluklerGrd;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.yenileBtn);
            this.groupControl1.Controls.Add(this.guncelleBtn);
            this.groupControl1.Controls.Add(this.silBtn);
            this.groupControl1.Controls.Add(this.ekleBtn);
            this.groupControl1.Location = new System.Drawing.Point(105, 313);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(636, 51);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "groupControl1";
            // 
            // yenileBtn
            // 
            this.yenileBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("yenileBtn.ImageOptions.Image")));
            this.yenileBtn.Location = new System.Drawing.Point(512, 5);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(95, 35);
            this.yenileBtn.TabIndex = 3;
            this.yenileBtn.Text = "YENİLE";
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.Location = new System.Drawing.Point(354, 5);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(95, 35);
            this.guncelleBtn.TabIndex = 2;
            this.guncelleBtn.Text = "GÜNCELLE";
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.ImageOptions.Image")));
            this.silBtn.Location = new System.Drawing.Point(193, 5);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(95, 35);
            this.silBtn.TabIndex = 1;
            this.silBtn.Text = "SİL";
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtn.ImageOptions.Image")));
            this.ekleBtn.Location = new System.Drawing.Point(34, 5);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(95, 35);
            this.ekleBtn.TabIndex = 0;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // MudurluklerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 369);
            this.Controls.Add(this.mudurluklerGrd);
            this.Controls.Add(this.groupControl1);
            this.Name = "MudurluklerFrm";
            this.Text = "Müdürlükler";
            this.Load += new System.EventHandler(this.MudurluklerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mudurluklerGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl mudurluklerGrd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton yenileBtn;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
        private DevExpress.XtraEditors.SimpleButton silBtn;
        private DevExpress.XtraEditors.SimpleButton ekleBtn;
    }
}