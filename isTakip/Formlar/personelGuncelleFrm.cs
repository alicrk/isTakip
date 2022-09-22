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
    public partial class personelGuncelleFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int guncellenecekId = 0;
        public personelGuncelleFrm()
        {
            InitializeComponent();
            
        }
        private void personelGuncelleFrm_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var deger = db.elemanlar.Find(guncellenecekId);
            if (guncellenecekId != 0)
            {
                deger.tc = tcTe.Text;
                deger.ad = adTe.Text;
                deger.soyad = soyadTe.Text;
                deger.unvan = int.Parse(unvanLe.EditValue.ToString());
                deger.sifre = sifreTe.Text;
                deger.telefon = telefonTe.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tcTe.Text = gridView1.GetFocusedRowCellValue("tc").ToString();
            adTe.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
            soyadTe.Text = gridView1.GetFocusedRowCellValue("soyad").ToString();
            

            var deger = (from x in db.unvan
                         select new
                         {
                             x.id,
                             x.ad

                         }).ToList();
            unvanLe.Properties.ValueMember = "id";
            unvanLe.Properties.DisplayMember = "ad";
            unvanLe.Properties.DataSource = deger;


            sifreTe.Text = gridView1.GetFocusedRowCellValue("sifre").ToString();
            telefonTe.Text = gridView1.GetFocusedRowCellValue("telefon").ToString();
            guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
        }
        void listele()
        {
            var degerler = (from x in db.elemanlar
                            select new
                            {
                                x.id,
                                x.tc,
                                x.ad,
                                x.soyad,
                                x.unvan,
                                x.sifre,
                                x.telefon
                            });

            personellerGrd.DataSource = degerler.ToList();
        }

       
    }
}
