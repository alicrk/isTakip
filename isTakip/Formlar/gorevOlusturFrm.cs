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
    public partial class gorevOlusturFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public int adminId;
        public gorevOlusturFrm()
        {
            InitializeComponent();
        }

   
        private void gorevOlusturFrm_Load(object sender, EventArgs e)
        {

            gorevVerenTe.Text = adminId.ToString();   
            var deger = (from x in db.elemanlar
                         select new
                         {
                             x.id,
                             AdSoyad = x.ad+" "+x.soyad
                         }).ToList();

            gorevAlanLe.Properties.ValueMember = "id";
            gorevAlanLe.Properties.DisplayMember = "AdSoyad";
            gorevAlanLe.Properties.DataSource = deger;

            mudurlukLe.ItemIndex = 1;
            var deger1 = (from x in db.mudurlukler.Where(x=>x.durum == true)
                         select new
                         {
                             x.id,
                             x.ad
                         }).ToList();
            mudurlukLe.Properties.ValueMember = "id";
            mudurlukLe.Properties.DisplayMember = "ad";
            mudurlukLe.Properties.DataSource = deger1;

            var deger2 = (from x in db.birimler
                          select new
                          {
                              x.id,
                              x.ad
                          }).ToList();
            birimLe.Properties.ValueMember = "id";
            birimLe.Properties.DisplayMember = "ad";
            birimLe.Properties.DataSource = deger2;

            var deger3 = (from x in db.islemBasliklari.Where(x => x.durum == true)
                          select new
                          {
                              x.id,
                              x.ad
                          }).ToList();
            islemBasligiLe.Properties.ValueMember = "id";
            islemBasligiLe.Properties.DisplayMember = "ad";
            islemBasligiLe.Properties.DataSource = deger3;

            var deger4 = (from x in db.islemler
                          select new
                          {
                              x.id,
                              x.ad
                          }).ToList();
            islemLe.Properties.ValueMember = "id";
            islemLe.Properties.DisplayMember = "ad";
            islemLe.Properties.DataSource = deger4;

            var deger5 = (from x in db.islemDurmu
                          select new
                          {
                              x.id,
                              x.ad
                          }).ToList();
            islemDurumuLe.Properties.ValueMember = "id";
            islemDurumuLe.Properties.DisplayMember = "ad";
            islemDurumuLe.Properties.DataSource = deger5;
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            gorevler t = new gorevler();
            t.gorevVeren = adminId;
            t.gorevAlan = int.Parse(gorevAlanLe.EditValue.ToString());
            t.mudurluk = int.Parse(mudurlukLe.EditValue.ToString());
            t.birim = int.Parse(birimLe.EditValue.ToString());
            t.baslik = int.Parse(islemBasligiLe.EditValue.ToString());
            t.islem = int.Parse(islemLe.EditValue.ToString());
            t.islem = int.Parse(islemLe.EditValue.ToString());
            t.aciklama = aciklamaTe.Text;
            t.durum = true;
            t.tarih = DateTime.Parse(tarihTe.Text);
            t.islemDurumu = int.Parse(islemDurumuLe.EditValue.ToString());
            db.gorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
