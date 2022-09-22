using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isTakip.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace isTakip.Formlar
{
    public partial class islemBaslikEkleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public islemBaslikEkleFrm()
        {
            InitializeComponent();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            islemBasliklari temp = new islemBasliklari();
            temp.ad = islemBaslikAdTe.Text;
            temp.durum = true;
            db.islemBasliklari.Add(temp);
            db.SaveChanges();
            XtraMessageBox.Show("Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
