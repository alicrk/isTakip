namespace isTakip.Formlar
{
    partial class gorevOlusturFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gorevOlusturFrm));
            this.gorevAlanLbl = new DevExpress.XtraEditors.LabelControl();
            this.vazgecBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.islemDurumuLe = new DevExpress.XtraEditors.LookUpEdit();
            this.islemLe = new DevExpress.XtraEditors.LookUpEdit();
            this.islemBasligiLe = new DevExpress.XtraEditors.LookUpEdit();
            this.birimLe = new DevExpress.XtraEditors.LookUpEdit();
            this.mudurlukLe = new DevExpress.XtraEditors.LookUpEdit();
            this.gorevAlanLe = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tarihLbl = new DevExpress.XtraEditors.LabelControl();
            this.islemBasligiLbl = new DevExpress.XtraEditors.LabelControl();
            this.islemLbl = new DevExpress.XtraEditors.LabelControl();
            this.mudurlukLbl = new DevExpress.XtraEditors.LabelControl();
            this.birimLbl = new DevExpress.XtraEditors.LabelControl();
            this.gorevVerenLbl = new DevExpress.XtraEditors.LabelControl();
            this.aciklamaTe = new DevExpress.XtraEditors.MemoEdit();
            this.tarihTe = new DevExpress.XtraEditors.DateEdit();
            this.ekleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.gorevVerenTe = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemDurumuLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBasligiLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudurlukLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevAlanLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihTe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevVerenTe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gorevAlanLbl
            // 
            this.gorevAlanLbl.Location = new System.Drawing.Point(17, 64);
            this.gorevAlanLbl.Name = "gorevAlanLbl";
            this.gorevAlanLbl.Size = new System.Drawing.Size(57, 13);
            this.gorevAlanLbl.TabIndex = 1;
            this.gorevAlanLbl.Text = "Görev Alan:";
            // 
            // vazgecBtn
            // 
            this.vazgecBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("vazgecBtn.ImageOptions.Image")));
            this.vazgecBtn.Location = new System.Drawing.Point(62, 452);
            this.vazgecBtn.Name = "vazgecBtn";
            this.vazgecBtn.Size = new System.Drawing.Size(95, 30);
            this.vazgecBtn.TabIndex = 17;
            this.vazgecBtn.Text = "VAZGEÇ";
            this.vazgecBtn.Click += new System.EventHandler(this.vazgecBtn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.islemDurumuLe);
            this.panelControl1.Controls.Add(this.islemLe);
            this.panelControl1.Controls.Add(this.islemBasligiLe);
            this.panelControl1.Controls.Add(this.birimLe);
            this.panelControl1.Controls.Add(this.mudurlukLe);
            this.panelControl1.Controls.Add(this.gorevAlanLe);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.tarihLbl);
            this.panelControl1.Controls.Add(this.islemBasligiLbl);
            this.panelControl1.Controls.Add(this.islemLbl);
            this.panelControl1.Controls.Add(this.mudurlukLbl);
            this.panelControl1.Controls.Add(this.birimLbl);
            this.panelControl1.Controls.Add(this.gorevVerenLbl);
            this.panelControl1.Controls.Add(this.gorevAlanLbl);
            this.panelControl1.Controls.Add(this.aciklamaTe);
            this.panelControl1.Controls.Add(this.tarihTe);
            this.panelControl1.Controls.Add(this.gorevVerenTe);
            this.panelControl1.Location = new System.Drawing.Point(24, 37);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(293, 389);
            this.panelControl1.TabIndex = 16;
            // 
            // islemDurumuLe
            // 
            this.islemDurumuLe.EditValue = "İşlem Durumu Seçin";
            this.islemDurumuLe.Location = new System.Drawing.Point(91, 245);
            this.islemDurumuLe.Name = "islemDurumuLe";
            this.islemDurumuLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.islemDurumuLe.Size = new System.Drawing.Size(170, 20);
            this.islemDurumuLe.TabIndex = 24;
            // 
            // islemLe
            // 
            this.islemLe.EditValue = "İşlem Seçin";
            this.islemLe.Location = new System.Drawing.Point(91, 187);
            this.islemLe.Name = "islemLe";
            this.islemLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.islemLe.Size = new System.Drawing.Size(170, 20);
            this.islemLe.TabIndex = 22;
            // 
            // islemBasligiLe
            // 
            this.islemBasligiLe.EditValue = "İşlem Başlığı Seçin";
            this.islemBasligiLe.Location = new System.Drawing.Point(91, 159);
            this.islemBasligiLe.Name = "islemBasligiLe";
            this.islemBasligiLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.islemBasligiLe.Size = new System.Drawing.Size(170, 20);
            this.islemBasligiLe.TabIndex = 21;
            // 
            // birimLe
            // 
            this.birimLe.EditValue = "Birim Seçin";
            this.birimLe.Location = new System.Drawing.Point(91, 127);
            this.birimLe.Name = "birimLe";
            this.birimLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birimLe.Size = new System.Drawing.Size(170, 20);
            this.birimLe.TabIndex = 20;
            // 
            // mudurlukLe
            // 
            this.mudurlukLe.EditValue = "Müdürlük Seçin";
            this.mudurlukLe.Location = new System.Drawing.Point(91, 96);
            this.mudurlukLe.Name = "mudurlukLe";
            this.mudurlukLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mudurlukLe.Size = new System.Drawing.Size(170, 20);
            this.mudurlukLe.TabIndex = 19;
            // 
            // gorevAlanLe
            // 
            this.gorevAlanLe.EditValue = "Görev Alan Seçin";
            this.gorevAlanLe.Location = new System.Drawing.Point(91, 61);
            this.gorevAlanLe.Name = "gorevAlanLe";
            this.gorevAlanLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gorevAlanLe.Size = new System.Drawing.Size(170, 20);
            this.gorevAlanLe.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 280);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Açıklama:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 248);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "İşlem Durumu:";
            // 
            // tarihLbl
            // 
            this.tarihLbl.Location = new System.Drawing.Point(46, 220);
            this.tarihLbl.Name = "tarihLbl";
            this.tarihLbl.Size = new System.Drawing.Size(28, 13);
            this.tarihLbl.TabIndex = 14;
            this.tarihLbl.Text = "Tarih:";
            // 
            // islemBasligiLbl
            // 
            this.islemBasligiLbl.Location = new System.Drawing.Point(17, 162);
            this.islemBasligiLbl.Name = "islemBasligiLbl";
            this.islemBasligiLbl.Size = new System.Drawing.Size(57, 13);
            this.islemBasligiLbl.TabIndex = 11;
            this.islemBasligiLbl.Text = "İşlem Başlığı";
            // 
            // islemLbl
            // 
            this.islemLbl.Location = new System.Drawing.Point(45, 190);
            this.islemLbl.Name = "islemLbl";
            this.islemLbl.Size = new System.Drawing.Size(29, 13);
            this.islemLbl.TabIndex = 10;
            this.islemLbl.Text = "İşlem:";
            // 
            // mudurlukLbl
            // 
            this.mudurlukLbl.Location = new System.Drawing.Point(27, 99);
            this.mudurlukLbl.Name = "mudurlukLbl";
            this.mudurlukLbl.Size = new System.Drawing.Size(47, 13);
            this.mudurlukLbl.TabIndex = 7;
            this.mudurlukLbl.Text = "Müdürlük:";
            // 
            // birimLbl
            // 
            this.birimLbl.Location = new System.Drawing.Point(48, 130);
            this.birimLbl.Name = "birimLbl";
            this.birimLbl.Size = new System.Drawing.Size(26, 13);
            this.birimLbl.TabIndex = 6;
            this.birimLbl.Text = "Birim:";
            // 
            // gorevVerenLbl
            // 
            this.gorevVerenLbl.Location = new System.Drawing.Point(10, 29);
            this.gorevVerenLbl.Name = "gorevVerenLbl";
            this.gorevVerenLbl.Size = new System.Drawing.Size(64, 13);
            this.gorevVerenLbl.TabIndex = 3;
            this.gorevVerenLbl.Text = "Görev Veren:";
            // 
            // aciklamaTe
            // 
            this.aciklamaTe.Location = new System.Drawing.Point(91, 277);
            this.aciklamaTe.Name = "aciklamaTe";
            this.aciklamaTe.Size = new System.Drawing.Size(170, 94);
            this.aciklamaTe.TabIndex = 25;
            // 
            // tarihTe
            // 
            this.tarihTe.EditValue = null;
            this.tarihTe.Location = new System.Drawing.Point(91, 219);
            this.tarihTe.Name = "tarihTe";
            this.tarihTe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarihTe.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarihTe.Properties.DisplayFormat.FormatString = "";
            this.tarihTe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tarihTe.Properties.EditFormat.FormatString = "";
            this.tarihTe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tarihTe.Size = new System.Drawing.Size(170, 20);
            this.tarihTe.TabIndex = 26;
            // 
            // ekleBtn
            // 
            this.ekleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtn.ImageOptions.Image")));
            this.ekleBtn.Location = new System.Drawing.Point(190, 452);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(95, 30);
            this.ekleBtn.TabIndex = 15;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // gorevVerenTe
            // 
            this.gorevVerenTe.Location = new System.Drawing.Point(91, 26);
            this.gorevVerenTe.Name = "gorevVerenTe";
            this.gorevVerenTe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gorevVerenTe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gorevVerenTe.Properties.Mask.EditMask = "d";
            this.gorevVerenTe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.gorevVerenTe.Size = new System.Drawing.Size(170, 20);
            this.gorevVerenTe.TabIndex = 27;
            // 
            // gorevOlusturFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 561);
            this.Controls.Add(this.vazgecBtn);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ekleBtn);
            this.Name = "gorevOlusturFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Oluştur";
            this.Load += new System.EventHandler(this.gorevOlusturFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemDurumuLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBasligiLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudurlukLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevAlanLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihTe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevVerenTe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl gorevAlanLbl;
        private DevExpress.XtraEditors.SimpleButton vazgecBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl islemBasligiLbl;
        private DevExpress.XtraEditors.LabelControl islemLbl;
        private DevExpress.XtraEditors.LabelControl mudurlukLbl;
        private DevExpress.XtraEditors.LabelControl birimLbl;
        private DevExpress.XtraEditors.LabelControl gorevVerenLbl;
        private DevExpress.XtraEditors.SimpleButton ekleBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl tarihLbl;
        private DevExpress.XtraEditors.LookUpEdit islemDurumuLe;
        private DevExpress.XtraEditors.LookUpEdit islemLe;
        private DevExpress.XtraEditors.LookUpEdit islemBasligiLe;
        private DevExpress.XtraEditors.LookUpEdit birimLe;
        private DevExpress.XtraEditors.LookUpEdit mudurlukLe;
        private DevExpress.XtraEditors.LookUpEdit gorevAlanLe;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit aciklamaTe;
        private DevExpress.XtraEditors.DateEdit tarihTe;
        private DevExpress.XtraEditors.TextEdit gorevVerenTe;
    }
}