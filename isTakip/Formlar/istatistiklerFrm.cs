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
    public partial class istatistiklerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public istatistiklerFrm()
        {
            InitializeComponent();
        }

        private void istatistiklerFrm_Load(object sender, EventArgs e)
        {
            calisanSayisiLbl.Text = db.elemanlar.Count().ToString();
            yoneticiSayisiLbl.Text = db.elemanlar.Where(x=>x.unvan == 1).Count().ToString();
            elemanSayisiLbl.Text = db.elemanlar.Where(x=>x.unvan == 2).Count().ToString();
            gorevSayisiLbl.Text = db.gorevler.Count().ToString();
            aktifGorevLbl.Text = db.gorevler.Where(x=>x.islemDurumu == 2).Count().ToString();
            pasifGorevLbl.Text = db.gorevler.Where(x => x.islemDurumu == 1 || x.islemDurumu == 3).Count().ToString();
            DateTime bugün = DateTime.Today;
            gununGorevleriLbl.Text = db.gorevler.Count(x=>x.tarih == bugün).ToString();
        }
    }
}
