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
    public partial class IslemlerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int secilenIdId = 0;
        string secilenBaslikAd;
        public IslemlerFrm()
        {
            InitializeComponent();
        }
        private void IslemlerFrm_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            var degerler = (from x in db.islemler
                            select new
                            {
                                x.id,
                                x.ad,
                                Başlık = x.islemBasliklari.ad
                            });

            gridControl1.DataSource = degerler.ToList();


        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Formlar.islemEkleFrm fr = new islemEkleFrm();
            fr.Show();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (secilenIdId != 0)
            {
                var deger = db.islemler.Find(secilenIdId);
                db.islemler.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Silme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                listele();
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            Formlar.islemGuncelleFrm fr = new islemGuncelleFrm();
            fr.secilenBaslikAd = gridView1.GetFocusedRowCellValue("Başlık").ToString();
            fr.Show();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            secilenIdId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            secilenBaslikAd = gridView1.GetFocusedRowCellValue("Başlık").ToString();
        }

        
    }
}
