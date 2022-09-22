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
    public partial class islemEkleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public islemEkleFrm()
        {
            InitializeComponent();
        }

        private void islemEkleFrm_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.islemBasliklari.Where(x => x.durum == true)
                         select new
                         {
                             x.id,
                             x.ad,

                         }).ToList();
            baslikAdLe.Properties.ValueMember = "id";
            baslikAdLe.Properties.DisplayMember = "ad";
            baslikAdLe.Properties.DataSource = deger;
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            islemler t = new islemler();
            t.ad = islemAdTe.Text;
            t.islemBasligi = int.Parse(baslikAdLe.EditValue.ToString());
            db.islemler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
