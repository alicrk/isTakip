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

namespace isTakip.Formlar
{
    public partial class gorevlerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public int adminId;
        public int gorevId;
        public int gorevDurumu;
        public string gorevAciklamasi;
        public gorevlerFrm()
        {
            InitializeComponent();
        }

        private void gorevlerFrm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Formlar.gorevOlusturFrm fr = new gorevOlusturFrm();
            fr.adminId = this.adminId;
            fr.Show();
        }
        
        private void DuzenleBtn_Click(object sender, EventArgs e)
        {
            Formlar.gorevDuzenleFrm fr = new gorevDuzenleFrm();
            fr.gorevId = this.gorevId;
            fr.gorevDurumu = this.gorevDurumu;
            fr.gorevAciklamasi = this.gorevAciklamasi;
            fr.Show();
        }
        
        
        private void yenileBtn_Click(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            var degerler = (from x in db.gorevler
                            select new
                            {
                                x.id,
                                GörevVeren = x.elemanlar.ad + " " + x.elemanlar.soyad,
                                GörevAlan = x.elemanlar1.ad + " " + x.elemanlar1.soyad,
                                Müdürlük = x.mudurlukler.ad,
                                Birim = x.birimler.ad,
                                İşlemBaşlığı = x.islemBasliklari.ad,
                                İşlem = x.islemler.ad,
                                Açıklama = x.aciklama,
                                Tarih = x.tarih,
                                İşlemDurumu = x.islemDurmu.ad
                            });

            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gorevId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            string temp = gridView1.GetFocusedRowCellValue("İşlemDurumu").ToString();
            var gorev = db.gorevler.Where(x => x.islemDurmu.ad == temp).Select(y => y.id).FirstOrDefault();
            gorevDurumu = gorev;
            gorevAciklamasi = gridView1.GetFocusedRowCellValue("Açıklama").ToString();
        }
    }
}
