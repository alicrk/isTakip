namespace isTakip.Formlar
{
    partial class gorevDuzenleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gorevDuzenleFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.gorevIdTe = new DevExpress.XtraEditors.TextEdit();
            this.gorevDurumuLe = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aciklamaTe = new DevExpress.XtraEditors.MemoEdit();
            this.vazgecBtn = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gorevIdTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDurumuLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaTe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Görev ID:";
            // 
            // gorevIdTe
            // 
            this.gorevIdTe.Location = new System.Drawing.Point(99, 68);
            this.gorevIdTe.Name = "gorevIdTe";
            this.gorevIdTe.Size = new System.Drawing.Size(221, 20);
            this.gorevIdTe.TabIndex = 1;
            // 
            // gorevDurumuLe
            // 
            this.gorevDurumuLe.Location = new System.Drawing.Point(99, 109);
            this.gorevDurumuLe.Name = "gorevDurumuLe";
            this.gorevDurumuLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gorevDurumuLe.Size = new System.Drawing.Size(221, 20);
            this.gorevDurumuLe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Görev Durumu:";
            // 
            // aciklamaTe
            // 
            this.aciklamaTe.Location = new System.Drawing.Point(99, 146);
            this.aciklamaTe.Name = "aciklamaTe";
            this.aciklamaTe.Size = new System.Drawing.Size(221, 94);
            this.aciklamaTe.TabIndex = 26;
            // 
            // vazgecBtn
            // 
            this.vazgecBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("vazgecBtn.ImageOptions.Image")));
            this.vazgecBtn.Location = new System.Drawing.Point(97, 265);
            this.vazgecBtn.Name = "vazgecBtn";
            this.vazgecBtn.Size = new System.Drawing.Size(95, 30);
            this.vazgecBtn.TabIndex = 28;
            this.vazgecBtn.Text = "VAZGEÇ";
            this.vazgecBtn.Click += new System.EventHandler(this.vazgecBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtn.ImageOptions.Image")));
            this.guncelleBtn.Location = new System.Drawing.Point(225, 265);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(95, 30);
            this.guncelleBtn.TabIndex = 27;
            this.guncelleBtn.Text = "GÜNCELLE";
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // gorevDuzenleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.vazgecBtn);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.aciklamaTe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gorevDurumuLe);
            this.Controls.Add(this.gorevIdTe);
            this.Controls.Add(this.label1);
            this.Name = "gorevDuzenleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Düzenle";
            this.Load += new System.EventHandler(this.gorevDuzenleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gorevIdTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDurumuLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaTe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit gorevIdTe;
        private DevExpress.XtraEditors.LookUpEdit gorevDurumuLe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.MemoEdit aciklamaTe;
        private DevExpress.XtraEditors.SimpleButton vazgecBtn;
        private DevExpress.XtraEditors.SimpleButton guncelleBtn;
    }
}