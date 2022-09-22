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

namespace isTakip.personelGorevFormlari
{
    public partial class aktifGorevlerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public int personelId;
        public int gorevId;
        public int gorevDurumu;
        public string gorevAciklamasi;
        public aktifGorevlerFrm()
        {
            InitializeComponent();
        }
        
        private void aktifGorevlerFrm_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void DuzenleBtn_Click(object sender, EventArgs e)
        {
            personelGorevFormlari.gorevDuzenleFrm fr = new personelGorevFormlari.gorevDuzenleFrm();
            fr.gorevId = this.gorevId;
            fr.gorevDurumu = this.gorevDurumu;
            fr.gorevAciklamasi = this.gorevAciklamasi;
            fr.Show();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            yenile();
        }

        public void yenile()
        {
            var degerler = (from x in db.gorevler
                            select new
                            {
                                x.id,
                                x.aciklama,
                                x.tarih,
                                GörevAlan = x.elemanlar1.ad + " " + x.elemanlar1.soyad,
                                x.gorevAlan,
                                x.islemDurumu,
                                GörevDurumu = x.islemDurmu.ad
                            }).Where(x => x.gorevAlan == personelId && x.islemDurumu == 2).ToList();
            gridControl2.DataSource = degerler;
            gridView2.Columns["islemDurumu"].Visible = false;
            gridView2.Columns["gorevAlan"].Visible = false;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gorevId = int.Parse(gridView2.GetFocusedRowCellValue("id").ToString());
            string temp = gridView2.GetFocusedRowCellValue("islemDurumu").ToString();
            var gorev = db.gorevler.Where(x => x.islemDurmu.ad == temp).Select(y => y.id).FirstOrDefault();
            gorevDurumu = gorev;
            gorevAciklamasi = gridView2.GetFocusedRowCellValue("aciklama").ToString();
        }
    }
}
