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
    public partial class BirimlerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int silinecekId = 0;
        public BirimlerFrm()
        {
            InitializeComponent();
        }

        private void BirimlerFrm_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Formlar.birimEkleFrm fr = new birimEkleFrm();
            fr.Show();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            Formlar.birimGuncelleFrm fr = new birimGuncelleFrm();
            fr.Show();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (silinecekId != 0)
            {
                var deger = db.birimler.Find(silinecekId);
                db.birimler.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Silme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
        }
        void listele()
        {
            var degerler = (from x in db.birimler
                            select new
                            {
                                x.id,
                                x.ad,
                                Müdürlük = x.mudurlukler.ad
                            });

            gridControl1.DataSource = degerler.ToList();


        }

        
    }

}
