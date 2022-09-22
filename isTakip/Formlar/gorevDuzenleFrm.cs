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
    public partial class gorevDuzenleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public int gorevId;
        public int gorevDurumu;
        public string gorevAciklamasi;
        public gorevDuzenleFrm()
        {
            InitializeComponent();
        }

        private void gorevDuzenleFrm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var deger = db.gorevler.Find(gorevId);
            if (gorevId != 0)
            {
                deger.islemDurumu = int.Parse(gorevDurumuLe.EditValue.ToString());
                deger.aciklama = aciklamaTe.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void listele()
        {
            var deger = (from x in db.islemDurmu
                         select new
                         {
                             x.id,
                             x.ad

                         }).ToList();
            gorevDurumuLe.Properties.ValueMember = "id";
            gorevDurumuLe.Properties.DisplayMember = "ad";
            gorevDurumuLe.Properties.DataSource = deger;

            gorevIdTe.Text = gorevId.ToString();
            gorevDurumuLe.ItemIndex = gorevDurumu;
            aciklamaTe.Text = gorevAciklamasi;
        }
    }
}
