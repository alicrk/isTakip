namespace isTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.gorevListeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.akrifGorevBtn = new DevExpress.XtraBars.BarButtonItem();
            this.pasifGorevBtn = new DevExpress.XtraBars.BarButtonItem();
            this.personellerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.islemBaslikBtn = new DevExpress.XtraBars.BarButtonItem();
            this.islemlerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.mudurluklerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.birimBtn = new DevExpress.XtraBars.BarButtonItem();
            this.istatistikBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage10 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage11 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage12 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage13 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage14 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage15 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup16 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage16 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup17 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem,
            this.gorevListeBtn,
            this.akrifGorevBtn,
            this.pasifGorevBtn,
            this.personellerBtn,
            this.islemBaslikBtn,
            this.islemlerBtn,
            this.mudurluklerBtn,
            this.birimBtn,
            this.istatistikBtn});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 10;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage10,
            this.ribbonPage11,
            this.ribbonPage12,
            this.ribbonPage13,
            this.ribbonPage14,
            this.ribbonPage15,
            this.ribbonPage16});
            this.ribbonControl2.Size = new System.Drawing.Size(934, 150);
            // 
            // gorevListeBtn
            // 
            this.gorevListeBtn.Caption = "Görev Listesi";
            this.gorevListeBtn.Id = 1;
            this.gorevListeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gorevListeBtn.ImageOptions.Image")));
            this.gorevListeBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("gorevListeBtn.ImageOptions.LargeImage")));
            this.gorevListeBtn.Name = "gorevListeBtn";
            this.gorevListeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.gorevListeBtn_ItemClick);
            // 
            // akrifGorevBtn
            // 
            this.akrifGorevBtn.Caption = "Aktif Görevler";
            this.akrifGorevBtn.Id = 2;
            this.akrifGorevBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("akrifGorevBtn.ImageOptions.Image")));
            this.akrifGorevBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("akrifGorevBtn.ImageOptions.LargeImage")));
            this.akrifGorevBtn.Name = "akrifGorevBtn";
            this.akrifGorevBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.akrifGorevBtn_ItemClick);
            // 
            // pasifGorevBtn
            // 
            this.pasifGorevBtn.Caption = "Pasif Görevler";
            this.pasifGorevBtn.Id = 3;
            this.pasifGorevBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pasifGorevBtn.ImageOptions.Image")));
            this.pasifGorevBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("pasifGorevBtn.ImageOptions.LargeImage")));
            this.pasifGorevBtn.Name = "pasifGorevBtn";
            this.pasifGorevBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tamamlananGorevBtn_ItemClick);
            // 
            // personellerBtn
            // 
            this.personellerBtn.Caption = "Personel Listesi";
            this.personellerBtn.Id = 4;
            this.personellerBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("personellerBtn.ImageOptions.Image")));
            this.personellerBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("personellerBtn.ImageOptions.LargeImage")));
            this.personellerBtn.Name = "personellerBtn";
            this.personellerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.personellerBtn_ItemClick);
            // 
            // islemBaslikBtn
            // 
            this.islemBaslikBtn.Caption = "İşlem Başlıkları Listesi";
            this.islemBaslikBtn.Id = 5;
            this.islemBaslikBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("islemBaslikBtn.ImageOptions.Image")));
            this.islemBaslikBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("islemBaslikBtn.ImageOptions.LargeImage")));
            this.islemBaslikBtn.Name = "islemBaslikBtn";
            this.islemBaslikBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.islemBaslikBtn_ItemClick);
            // 
            // islemlerBtn
            // 
            this.islemlerBtn.Caption = "İşlemler";
            this.islemlerBtn.Id = 6;
            this.islemlerBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("islemlerBtn.ImageOptions.Image")));
            this.islemlerBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("islemlerBtn.ImageOptions.LargeImage")));
            this.islemlerBtn.Name = "islemlerBtn";
            this.islemlerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.islemlerBtn_ItemClick);
            // 
            // mudurluklerBtn
            // 
            this.mudurluklerBtn.Caption = "Müdürlükler";
            this.mudurluklerBtn.Id = 7;
            this.mudurluklerBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mudurluklerBtn.ImageOptions.Image")));
            this.mudurluklerBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mudurluklerBtn.ImageOptions.LargeImage")));
            this.mudurluklerBtn.Name = "mudurluklerBtn";
            this.mudurluklerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mudurluklerBtn_ItemClick);
            // 
            // birimBtn
            // 
            this.birimBtn.Caption = "Birimler";
            this.birimBtn.Id = 8;
            this.birimBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("birimBtn.ImageOptions.Image")));
            this.birimBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("birimBtn.ImageOptions.LargeImage")));
            this.birimBtn.Name = "birimBtn";
            this.birimBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.birimBtn_ItemClick);
            // 
            // istatistikBtn
            // 
            this.istatistikBtn.Caption = "İstatistikler";
            this.istatistikBtn.Id = 9;
            this.istatistikBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.istatistikBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.istatistikBtn.Name = "istatistikBtn";
            this.istatistikBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.istatistikBtn_ItemClick);
            // 
            // ribbonPage10
            // 
            this.ribbonPage10.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11});
            this.ribbonPage10.Name = "ribbonPage10";
            this.ribbonPage10.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.istatistikBtn);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPage11
            // 
            this.ribbonPage11.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup12});
            this.ribbonPage11.Name = "ribbonPage11";
            this.ribbonPage11.Text = "Görevler";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.gorevListeBtn);
            this.ribbonPageGroup12.ItemLinks.Add(this.akrifGorevBtn);
            this.ribbonPageGroup12.ItemLinks.Add(this.pasifGorevBtn);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPage12
            // 
            this.ribbonPage12.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup13});
            this.ribbonPage12.Name = "ribbonPage12";
            this.ribbonPage12.Text = "Personeller";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.personellerBtn);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // ribbonPage13
            // 
            this.ribbonPage13.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup14});
            this.ribbonPage13.Name = "ribbonPage13";
            this.ribbonPage13.Text = "İşlem Başlıkları";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.islemBaslikBtn);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            // 
            // ribbonPage14
            // 
            this.ribbonPage14.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup15});
            this.ribbonPage14.Name = "ribbonPage14";
            this.ribbonPage14.Text = "İşlemler";
            // 
            // ribbonPageGroup15
            // 
            this.ribbonPageGroup15.ItemLinks.Add(this.islemlerBtn);
            this.ribbonPageGroup15.Name = "ribbonPageGroup15";
            // 
            // ribbonPage15
            // 
            this.ribbonPage15.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup16});
            this.ribbonPage15.Name = "ribbonPage15";
            this.ribbonPage15.Text = "Müdürlükler";
            // 
            // ribbonPageGroup16
            // 
            this.ribbonPageGroup16.ItemLinks.Add(this.mudurluklerBtn);
            this.ribbonPageGroup16.Name = "ribbonPageGroup16";
            // 
            // ribbonPage16
            // 
            this.ribbonPage16.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup17});
            this.ribbonPage16.Name = "ribbonPage16";
            this.ribbonPage16.Text = "Birimler";
            // 
            // ribbonPageGroup17
            // 
            this.ribbonPageGroup17.ItemLinks.Add(this.birimBtn);
            this.ribbonPageGroup17.Name = "ribbonPageGroup17";
            // 
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.ribbonControl2);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        //private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        //private DevExpress.XtraBars.BarButtonItem perListeleBtn;
        //private DevExpress.XtraBars.BarButtonItem personelEkleBtn;
        //private DevExpress.XtraBars.BarButtonItem gorevListesiBtn;
        //private DevExpress.XtraBars.BarButtonItem gorevOlusturBtn;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        //private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        //private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        //private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        //private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        //private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage8;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage9;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        //private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        //private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        //private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        //private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        //private DevExpress.XtraBars.BarButtonItem islemBasliklariBtn;
        //private DevExpress.XtraBars.BarButtonItem birimlerBtn;
        //private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem gorevListeBtn;
        private DevExpress.XtraBars.BarButtonItem akrifGorevBtn;
        private DevExpress.XtraBars.BarButtonItem pasifGorevBtn;
        private DevExpress.XtraBars.BarButtonItem personellerBtn;
        private DevExpress.XtraBars.BarButtonItem islemBaslikBtn;
        private DevExpress.XtraBars.BarButtonItem islemlerBtn;
        private DevExpress.XtraBars.BarButtonItem mudurluklerBtn;
        private DevExpress.XtraBars.BarButtonItem birimBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage14;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup15;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage15;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup16;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage16;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup17;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
        private DevExpress.XtraBars.BarButtonItem istatistikBtn;
    }
}

