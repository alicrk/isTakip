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
    public partial class personelEkleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public personelEkleFrm()
        {
            InitializeComponent();
        }
        
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            elemanlar t = new elemanlar();
            t.tc = tcTe.Text;
            t.ad = adTe.Text;
            t.soyad = soyadTe.Text;
            t.unvan = int.Parse(unvanLe.EditValue.ToString());
            t.sifre = sifreTe.Text;
            t.telefon = telefonTe.Text;
            db.elemanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personelEkleFrm_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.unvan
                         select new
                         {
                             x.id,
                             x.ad,

                         }).ToList();
            unvanLe.Properties.ValueMember = "id";
            unvanLe.Properties.DisplayMember = "ad";
            unvanLe.Properties.DataSource = deger;
        }
    }
}
