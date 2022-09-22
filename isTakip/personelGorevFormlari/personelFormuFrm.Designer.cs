﻿using DevExpress.XtraBars.Ribbon;

namespace isTakip.personelGorevFormlari
{
    partial class personelFormuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelFormuFrm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.aktifGorevlerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.pasifGorevlerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.aktifGorevlerBtn,
            this.pasifGorevlerBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 150);
            // 
            // aktifGorevlerBtn
            // 
            this.aktifGorevlerBtn.Caption = "Aktif Görevler";
            this.aktifGorevlerBtn.Id = 1;
            this.aktifGorevlerBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aktifGorevlerBtn.ImageOptions.Image")));
            this.aktifGorevlerBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("aktifGorevlerBtn.ImageOptions.LargeImage")));
            this.aktifGorevlerBtn.Name = "aktifGorevlerBtn";
            this.aktifGorevlerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.aktifGorevlerBtn_ItemClick);
            // 
            // pasifGorevlerBtn
            // 
            this.pasifGorevlerBtn.Caption = "Pasif Görevler";
            this.pasifGorevlerBtn.Id = 2;
            this.pasifGorevlerBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pasifGorevlerBtn.ImageOptions.Image")));
            this.pasifGorevlerBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("pasifGorevlerBtn.ImageOptions.LargeImage")));
            this.pasifGorevlerBtn.Name = "pasifGorevlerBtn";
            this.pasifGorevlerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pasifGorevlerBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Personel";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.aktifGorevlerBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.pasifGorevlerBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // personelFormuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "personelFormuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Görevleri";
            this.Load += new System.EventHandler(this.personelFormuFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem aktifGorevlerBtn;
        private DevExpress.XtraBars.BarButtonItem pasifGorevlerBtn;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}