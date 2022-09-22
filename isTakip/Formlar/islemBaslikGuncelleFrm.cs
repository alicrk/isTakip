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
    public partial class islemBaslikGuncelleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int guncellenecekId = 0;
        public islemBaslikGuncelleFrm()
        {
            InitializeComponent();
        }
        private void islemBaslikGuncelleFrm_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var deger = db.islemBasliklari.Find(guncellenecekId);
            if (guncellenecekId != 0)
            {
                deger.ad = islemBaslikAdTe.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
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

            ialemBaslikGrd.DataSource = degerler.Where(x => x.durum == true).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            islemBaslikAdTe.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
            guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
