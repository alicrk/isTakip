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
    public partial class islemGuncelleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int guncellenecekId = 0;
        public string secilenBaslikAd;
        public islemGuncelleFrm()
        {
            InitializeComponent();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var deger = (from x in db.islemBasliklari.Where(x => x.durum == true)
                         select new
                         {
                             x.id,
                             x.ad

                         }).ToList();
            baslikAdLe.Properties.ValueMember = "id";
            baslikAdLe.Properties.DisplayMember = "ad";
            baslikAdLe.Properties.DataSource = deger;
            guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
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

            islemlerGrd.DataSource = degerler.ToList();
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var deger = db.islemler.Find(guncellenecekId);
            if (guncellenecekId != 0)
            {
                deger.ad = islemAdTe.Text;
                deger.islemBasligi = int.Parse(baslikAdLe.EditValue.ToString());
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
        }

        private void islemGuncelleFrm_Load(object sender, EventArgs e)
        {
            listele();
            islemAdTe.Text = secilenBaslikAd.ToString();
        }
    }
}
