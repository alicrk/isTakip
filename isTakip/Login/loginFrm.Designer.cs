namespace isTakip.Login
{
    partial class loginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFrm));
            this.adminGirisiBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tcTe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.sifreTe = new DevExpress.XtraEditors.TextEdit();
            this.personelGirisBtn = new System.Windows.Forms.Button();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl3 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // adminGirisiBtn
            // 
            this.adminGirisiBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminGirisiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminGirisiBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGirisiBtn.Location = new System.Drawing.Point(312, 201);
            this.adminGirisiBtn.Name = "adminGirisiBtn";
            this.adminGirisiBtn.Size = new System.Drawing.Size(138, 31);
            this.adminGirisiBtn.TabIndex = 0;
            this.adminGirisiBtn.Text = "Admin Girişi";
            this.adminGirisiBtn.UseVisualStyleBackColor = false;
            this.adminGirisiBtn.Click += new System.EventHandler(this.adminGirisBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 343);
            this.panel1.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(76, 43);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(134, 132);
            this.pictureEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 204);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(268, 23);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "İş Takip ve Yönetim Sistemi\r\n";
            // 
            // tcTe
            // 
            this.tcTe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcTe.Location = new System.Drawing.Point(375, 112);
            this.tcTe.Name = "tcTe";
            this.tcTe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcTe.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tcTe.Properties.Appearance.Options.UseFont = true;
            this.tcTe.Properties.Appearance.Options.UseForeColor = true;
            this.tcTe.Size = new System.Drawing.Size(190, 24);
            this.tcTe.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(314, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(272, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "TC Numaranız ve Şifrenizle Giriş Yapınız";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(322, 145);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(47, 36);
            this.pictureEdit2.TabIndex = 4;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(322, 101);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(47, 48);
            this.pictureEdit3.TabIndex = 5;
            // 
            // sifreTe
            // 
            this.sifreTe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifreTe.Location = new System.Drawing.Point(375, 151);
            this.sifreTe.Name = "sifreTe";
            this.sifreTe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTe.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sifreTe.Properties.Appearance.Options.UseFont = true;
            this.sifreTe.Properties.Appearance.Options.UseForeColor = true;
            this.sifreTe.Properties.UseSystemPasswordChar = true;
            this.sifreTe.Size = new System.Drawing.Size(190, 24);
            this.sifreTe.TabIndex = 6;
            // 
            // personelGirisBtn
            // 
            this.personelGirisBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.personelGirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personelGirisBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelGirisBtn.Location = new System.Drawing.Point(453, 201);
            this.personelGirisBtn.Name = "personelGirisBtn";
            this.personelGirisBtn.Size = new System.Drawing.Size(138, 31);
            this.personelGirisBtn.TabIndex = 7;
            this.personelGirisBtn.Text = "Personel Girişi";
            this.personelGirisBtn.UseVisualStyleBackColor = false;
            this.personelGirisBtn.Click += new System.EventHandler(this.personelGirisBtn_Click_1);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(334, 317);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(76, 13);
            this.hyperlinkLabelControl1.TabIndex = 8;
            this.hyperlinkLabelControl1.Text = "Şifremi Unuttum";
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(430, 317);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(32, 13);
            this.hyperlinkLabelControl2.TabIndex = 9;
            this.hyperlinkLabelControl2.Text = "Yardım";
            // 
            // hyperlinkLabelControl3
            // 
            this.hyperlinkLabelControl3.Location = new System.Drawing.Point(477, 317);
            this.hyperlinkLabelControl3.Name = "hyperlinkLabelControl3";
            this.hyperlinkLabelControl3.Size = new System.Drawing.Size(86, 13);
            this.hyperlinkLabelControl3.TabIndex = 10;
            this.hyperlinkLabelControl3.Text = "Uygulamayı Kapat";
            // 
            // loginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 342);
            this.Controls.Add(this.hyperlinkLabelControl3);
            this.Controls.Add(this.hyperlinkLabelControl2);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.personelGirisBtn);
            this.Controls.Add(this.sifreTe);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tcTe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminGirisiBtn);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminGirisiBtn;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tcTe;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.TextEdit sifreTe;
        private System.Windows.Forms.Button personelGirisBtn;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl3;
    }
}