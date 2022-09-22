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
    public partial class birimGuncelleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int guncellenecekId = 0;
        public birimGuncelleFrm()
        {
            InitializeComponent();
        }

        private void birimGuncelleFrm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            birimAdTe.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
            var deger = (from x in db.mudurlukler.Where(x => x.durum ==true)
                         select new
                         {
                             x.id,
                             x.ad

                         }).ToList();
            mudurlukAdLe.Properties.ValueMember = "id";
            mudurlukAdLe.Properties.DisplayMember = "ad";
            mudurlukAdLe.Properties.DataSource = deger;
            guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var deger = db.birimler.Find(guncellenecekId);
            if (guncellenecekId != 0)
            {
                deger.ad = birimAdTe.Text;
                deger.mudurluk = int.Parse(mudurlukAdLe.EditValue.ToString());
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

            birimlerGrd.DataSource = degerler.ToList();
        }

        
    }

}
