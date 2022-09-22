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
    public partial class mudurlukGuncelleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int guncellenecekId = 0;
        public mudurlukGuncelleFrm()
        {
            InitializeComponent();
            
        }
        private void mudurlukGuncelleFrm_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var deger = db.mudurlukler.Find(guncellenecekId);
            if(guncellenecekId != 0)
            {
                deger.ad = mudurlukAdTe.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            mudurlukAdTe.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
            guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void listele()
        {

            var degerler = (from x in db.mudurlukler
                            select new
                            {
                                x.id,
                                x.ad,
                                x.durum
                            });

            mudurluklerGrd.DataSource = degerler.Where(x => x.durum == true).ToList();
        }

       
    }
}
