using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Raporhafiza;

namespace Raporlama.Rapor_Olustur
{
    public partial class Yeni_Islem : Form
    {
        public Yeni_Islem()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            hafizarapor.islem = new Islem();
            hafizarapor.islem.rapor_id = hafizarapor.rapor.id;
            hafizarapor.islem.Aciklama = txtIslem.Text;
            hafizarapor.raporveritabani.Islems.InsertOnSubmit(hafizarapor.islem);
            hafizarapor.raporveritabani.SubmitChanges();
            var cevap = (MessageBox.Show("İşleminiz kaydedildi. Yapılan başka işlem var mı", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (cevap == DialogResult.Yes)
            {
                if (hafizarapor.islem.Aciklama != txtIslem.Text)
                {
                    hafizarapor.islem = new Islem();
                    hafizarapor.islem.rapor_id = hafizarapor.rapor.id;
                    hafizarapor.islem.Aciklama = txtIslem.Text;
                    hafizarapor.raporveritabani.Islems.InsertOnSubmit(hafizarapor.islem);
                    hafizarapor.raporveritabani.SubmitChanges();
                }
                txtIslem.Clear();
            }
            else
            {
                MessageBox.Show("Rapor oluşturulmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
