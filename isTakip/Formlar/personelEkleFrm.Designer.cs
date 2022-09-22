namespace isTakip.Formlar
{
    partial class personelEkleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelEkleFrm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.vazgecBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.unvanLe = new DevExpress.XtraEditors.LookUpEdit();
            this.telefonTe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sifreTe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.soyadTe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.adTe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tcTe = new DevExpress.XtraEditors.TextEdit();
            this.ekleBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unvanLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcTe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ad:";
            // 
            // vazgecBtn
            // 
            this.vazgecBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("vazgecBtn.ImageOptions.Image")));
            this.vazgecBtn.Location = new System.Drawing.Point(61, 283);
            this.vazgecBtn.Name = "vazgecBtn";
            this.vazgecBtn.Size = new System.Drawing.Size(95, 30);
            this.vazgecBtn.TabIndex = 14;
            this.vazgecBtn.Text = "VAZGEÇ";
            this.vazgecBtn.Click += new System.EventHandler(this.vazgecBtn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.unvanLe);
            this.panelControl1.Controls.Add(this.telefonTe);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.sifreTe);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.soyadTe);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.adTe);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.tcTe);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(23, 27);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(293, 227);
            this.panelControl1.TabIndex = 13;
            // 
            // unvanLe
            // 
            this.unvanLe.Location = new System.Drawing.Point(83, 127);
            this.unvanLe.Name = "unvanLe";
            this.unvanLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unvanLe.Size = new System.Drawing.Size(178, 20);
            this.unvanLe.TabIndex = 14;
            // 
            // telefonTe
            // 
            this.telefonTe.Location = new System.Drawing.Point(83, 202);
            this.telefonTe.Name = "telefonTe";
            this.telefonTe.Size = new System.Drawing.Size(178, 20);
            this.telefonTe.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(48, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Şifre:";
            // 
            // sifreTe
            // 
            this.sifreTe.Location = new System.Drawing.Point(83, 163);
            this.sifreTe.Name = "sifreTe";
            this.sifreTe.Size = new System.Drawing.Size(178, 20);
            this.sifreTe.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(34, 205);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Telefon:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Soyad:";
            // 
            // soyadTe
            // 
            this.soyadTe.Location = new System.Drawing.Point(83, 92);
            this.soyadTe.Name = "soyadTe";
            this.soyadTe.Size = new System.Drawing.Size(178, 20);
            this.soyadTe.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ünvan:";
            // 
            // adTe
            // 
            this.adTe.Location = new System.Drawing.Point(83, 57);
            this.adTe.Name = "adTe";
            this.adTe.Size = new System.Drawing.Size(178, 20);
            this.adTe.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tc:";
            // 
            // tcTe
            // 
            this.tcTe.Location = new System.Drawing.Point(83, 22);
            this.tcTe.Name = "tcTe";
            this.tcTe.Size = new System.Drawing.Size(178, 20);
            this.tcTe.TabIndex = 4;
            // 
            // ekleBtn
            // 
            this.ekleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtn.ImageOptions.Image")));
            this.ekleBtn.Location = new System.Drawing.Point(189, 283);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(95, 30);
            this.ekleBtn.TabIndex = 12;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // personelEkleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 361);
            this.Controls.Add(this.vazgecBtn);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ekleBtn);
            this.Name = "personelEkleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekleme";
            this.Load += new System.EventHandler(this.personelEkleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unvanLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcTe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton vazgecBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tcTe;
        private DevExpress.XtraEditors.SimpleButton ekleBtn;
        private DevExpress.XtraEditors.TextEdit telefonTe;
        private DevExpress.XtraEditors.TextEdit sifreTe;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit soyadTe;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit adTe;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit unvanLe;
    }
}