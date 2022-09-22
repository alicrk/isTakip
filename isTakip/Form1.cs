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


namespace isTakip
{
    public partial class Form1 : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public string adminAd;
        public Form1()
        {
            InitializeComponent();
        }

        
        Formlar.gorevlerFrm frm;
        private void gorevListeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.gorevlerFrm();
                var personel = db.elemanlar.Where(x => x.ad == adminAd).Select(y => y.id).FirstOrDefault();
                frm.adminId = personel;
                frm.MdiParent = this;
                frm.Show();
            }
        }

        Formlar.PersonellerFrm frm2;
        private void personellerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.PersonellerFrm();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        Formlar.IslembasliklariFrm frm3;
        private void islemBaslikBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.IslembasliklariFrm();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        Formlar.IslemlerFrm frm4;
        private void islemlerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.IslemlerFrm();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        Formlar.MudurluklerFrm frm5;
        private void mudurluklerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Formlar.MudurluklerFrm();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        Formlar.BirimlerFrm frm6;
        private void birimBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new Formlar.BirimlerFrm();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }
        private void gorevOlusturBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.gorevOlusturFrm fr = new Formlar.gorevOlusturFrm();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = adminAd;
        }

        Formlar.aktifGorevlerFrm frm7;
        private void akrifGorevBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                if (frm7 == null || frm7.IsDisposed)
                {
                    frm7 = new Formlar.aktifGorevlerFrm();
                    frm7.MdiParent = this;
                    frm7.Show();
                }
        }

        Formlar.pasifGorevlerFrm frm8;
        private void tamamlananGorevBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Formlar.pasifGorevlerFrm();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }

        Formlar.istatistiklerFrm frm9;
        private void istatistikBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Formlar.istatistiklerFrm ();
                frm9.MdiParent = this;
                frm9.Show();
            }
        }
    }
}
