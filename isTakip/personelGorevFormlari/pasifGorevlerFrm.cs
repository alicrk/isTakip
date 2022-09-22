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
    public partial class pasifGorevlerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public int personelId;
        public pasifGorevlerFrm()
        {
            InitializeComponent();
        }

        private void pasifGorevlerFrm_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.gorevler
                            select new
                            {
                                x.id,
                                x.aciklama,
                                x.tarih,
                                x.gorevAlan,
                                GörevAlan = x.elemanlar1.ad+" "+x.elemanlar1.soyad,
                                x.durum,
                                GörevDurumu = x.islemDurmu.ad
                            }).Where(x => x.gorevAlan == personelId && x.GörevDurumu == "İşlem Tamamlandı" || x.gorevAlan == personelId && x.GörevDurumu == "İşlem Sürüyor").ToList();
            gridControl1.DataSource = degerler;
            gridView1.Columns["durum"].Visible = false;
            gridView1.Columns["gorevAlan"].Visible = false;
        }
    }
}
