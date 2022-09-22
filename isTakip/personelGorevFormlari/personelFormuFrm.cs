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
    public partial class personelFormuFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public string personelIsim;
        public personelFormuFrm()
        {
            InitializeComponent();
        }

        personelGorevFormlari.aktifGorevlerFrm frm;
        private void aktifGorevlerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new personelGorevFormlari.aktifGorevlerFrm();
                var personel = db.elemanlar.Where(x => x.ad == personelIsim).Select(y => y.id).FirstOrDefault();
                frm.personelId = personel;
                frm.MdiParent = this;
                frm.Show();
            }
        }

        personelGorevFormlari.pasifGorevlerFrm frm1;
        private void pasifGorevlerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new personelGorevFormlari.pasifGorevlerFrm();
                frm1.MdiParent = this;
                var personel = db.elemanlar.Where(x => x.ad == personelIsim).Select(y => y.id).FirstOrDefault();
                frm1.personelId = personel;
                frm1.Show();
            }
        }

        private void personelFormuFrm_Load(object sender, EventArgs e)
        {
            this.Text = personelIsim.ToString();
        }
    }
}

