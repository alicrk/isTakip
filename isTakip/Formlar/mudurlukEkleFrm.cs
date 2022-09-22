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
    public partial class mudurlukEkleFrm : Form
    {
        public mudurlukEkleFrm()
        {
            InitializeComponent();
        }
        dbIsTakipEntities db = new dbIsTakipEntities();

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            mudurlukler t = new mudurlukler();
            t.ad = mudurlukAdTe.Text;
            t.durum = true;
            db.mudurlukler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ekleme Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
