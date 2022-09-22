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
    public partial class IslembasliklariFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int silinecekId = 0;
        public IslembasliklariFrm()
        {
            InitializeComponent();
        }
        private void IslembasliklariFrm_Load(object sender, EventArgs e)
        {
            listele();

        }
        
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Formlar.islemBaslikEkleFrm fr = new islemBaslikEkleFrm();
            fr.Show();
        }
        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
        }
        private void yenileBtn_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void silBtn_Click_1(object sender, EventArgs e)
        {
            if (silinecekId != 0)
            {
                var deger = db.islemBasliklari.Find(silinecekId);
                deger.durum = false;
                db.SaveChanges();
                XtraMessageBox.Show("Silme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                listele();
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            Formlar.islemBaslikGuncelleFrm fr = new islemBaslikGuncelleFrm();
            fr.Show();
        }
        void listele()
        {
            var degerler = (from x in db.islemBasliklari
                            select new
                            {
                                x.id,
                                x.ad,
                                x.durum
                            });

            gridControl1.DataSource = degerler.Where(x => x.durum == true).ToList();
            gridView1.Columns["durum"].Visible = false;
        }

    }
}
