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
    public partial class birimEkleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public birimEkleFrm()
        {
            InitializeComponent();
        }

        private void birimEkleFrm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            birimler t = new birimler();
            t.ad = birimAdTe.Text;
            t.mudurluk =int.Parse(mudurlukAdLe.EditValue.ToString());
            db.birimler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void listele()
        {
            var deger = (from x in db.mudurlukler.Where(x => x.durum == true)
                         select new
                         {
                             x.id,
                             x.ad,

                         }).ToList();
            mudurlukAdLe.Properties.ValueMember = "id";
            mudurlukAdLe.Properties.DisplayMember = "ad";
            mudurlukAdLe.Properties.DataSource = deger;
        }
        
    }
}
