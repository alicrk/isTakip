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
    public partial class PersonellerFrm : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        int silinecekId = 0;
        public PersonellerFrm()
        {
            InitializeComponent();
            
        }
        private void PersonellerFrm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Formlar.personelEkleFrm fr = new personelEkleFrm ();
            fr.Show();
        }
        

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (silinecekId != 0)
            {
                var deger = db.elemanlar.Find(silinecekId);
                db.elemanlar.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Silme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                listele();
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            Formlar.personelGuncelleFrm fr = new personelGuncelleFrm();
            fr.Show();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            listele();
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
                                Ünvan = x.unvan1.ad,
                                x.sifre,
                                x.telefon
                            });

            gridControl1.DataSource = degerler.ToList();
        }

        
    }
}




