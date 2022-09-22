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
    public partial class pasifGorevlerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public pasifGorevlerFrm()
        {
            InitializeComponent();
        }

        private void pasifGorevlerFrm_Load(object sender, EventArgs e)
        {
            listele();
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
                                İşlemDurumu = x.islemDurmu.ad,
                                x.islemDurmu
                            }).Where(x => x.islemDurmu.id == 1 || x.islemDurmu.id == 3);

            gridControl1.DataSource = degerler.ToList();
            gridView1.Columns["islemDurmu"].Visible = false;
        }
    }
}
