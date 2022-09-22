using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isTakip.Entity;
using isTakip.Formlar;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace isTakip.Formlar
{
    public partial class MudurluklerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int silinecekId = 0;

        public MudurluklerFrm()
        {
            InitializeComponent();
            
        }

        private void MudurluklerFrm_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void yenileBtn_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Formlar.mudurlukEkleFrm fr = new mudurlukEkleFrm();
            fr.Show();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            Formlar.mudurlukGuncelleFrm fr = new mudurlukGuncelleFrm();
            fr.Show();
        
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            silinecekId =int.Parse (gridView1.GetFocusedRowCellValue("id").ToString());
        }
        private void silBtn_Click(object sender, EventArgs e)
        {
            if(silinecekId != 0)
            {
                var deger = db.mudurlukler.Find(silinecekId);
                deger.durum = false;
                db.SaveChanges();
                XtraMessageBox.Show("Silme Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                listele();
            }
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
            gridView1.Columns["durum"].Visible = false;
        }

        
    }
}
