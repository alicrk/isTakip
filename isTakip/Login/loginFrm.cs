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

namespace isTakip.Login
{
    public partial class loginFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public loginFrm()
        {
            InitializeComponent();
        }

        private void adminGirisBtn_Click(object sender, EventArgs e)
        {
            var personel = db.elemanlar.Where(x => x.tc == tcTe.Text && x.sifre == sifreTe.Text && x.unvan == 1).FirstOrDefault();
            if(personel != null)
            {
                Form1 fr = new Form1();
                var isim = db.elemanlar.Where(x => x.tc == tcTe.Text).Select(y => y.ad).FirstOrDefault();
                fr.adminAd = isim.ToString();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
            
            
        }

        private void personelGirisBtn_Click_1(object sender, EventArgs e)
        {
            var personel = db.elemanlar.Where(x => x.tc == tcTe.Text && x.sifre == sifreTe.Text && x.unvan == 2).FirstOrDefault();
            if (personel != null)
            {
                personelGorevFormlari.personelFormuFrm fr1 = new personelGorevFormlari.personelFormuFrm();
                var isim = db.elemanlar.Where(x => x.tc == tcTe.Text).Select(y=>y.ad).FirstOrDefault();
                fr1.personelIsim = isim.ToString();
                fr1.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }

        }
    }
}
