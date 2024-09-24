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
    public partial class Rapor_Olustur : Form
    {
        public Rapor_Olustur()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text.Trim() == "")
            {
                MessageBox.Show("Açıklama giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            hafizarapor.rapor = new Rapor();
            if (RbIc.Checked==true)
            {
                hafizarapor.rapor.Gorev_Tipi = "Sehirici";
                hafizarapor.rapor.Sehir = "ANKARA";
                hafizarapor.rapor.Yer = CbGorev_yeri.Text;
            }
            else
            {
                hafizarapor.rapor.Gorev_Tipi = "Sehirdisi";
                hafizarapor.rapor.Sehir = CbGorev_yeri.Text;
                hafizarapor.rapor.Yer = "-----";

            }
            if (cb1.Checked==true && cb2.Checked==true)
            {
                hafizarapor.rapor.Gorevli_Personel = "Ahmet Efe" + ", " + "Habip";
            }
            else if (cb1.Checked == true)
            {
                hafizarapor.rapor.Gorevli_Personel = "Ahmet Efe";
            }
            else if (cb2.Checked == true)
            {
                hafizarapor.rapor.Gorevli_Personel = "Habip";
            }
            hafizarapor.rapor.Tarih = Convert.ToDateTime(DtpTarih.Value.ToShortDateString());
            hafizarapor.raporveritabani.Rapors.InsertOnSubmit(hafizarapor.rapor);
            hafizarapor.raporveritabani.SubmitChanges();
            hafizarapor.islem = new Islem();
            hafizarapor.islem.rapor_id = hafizarapor.rapor.id;
            hafizarapor.islem.Aciklama = txtAciklama.Text;
            hafizarapor.raporveritabani.Islems.InsertOnSubmit(hafizarapor.islem);
            hafizarapor.raporveritabani.SubmitChanges();
            txtAciklama.Clear();
            var cevap= (MessageBox.Show("İşleminiz kaydedildi. Yapılan başka işlem var mı","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if (cevap == DialogResult.Yes)
            {
                Yeni_Islem yeni = new Yeni_Islem();
                yeni.Show();
                txtAciklama.Text = hafizarapor.islem.Aciklama;
                temizle();
            }
            else
            {
                MessageBox.Show("Rapor oluşturulmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
        }
        public void temizle()
        {
            txtAciklama.Clear();
            RbIc.Checked = true;
            RbDis.Checked = false;
            cb1.Checked = false;
            cb2.Checked = false;
            CbGorev_yeri.SelectedIndex = -1;
            DtpTarih.ResetText();
            
        }

        private void Rapor_Olustur_Load(object sender, EventArgs e)
        {
            RbIc.Checked = true;
        }

        private void RbIc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbIc.Checked==true)
            {
                CbGorev_yeri.DisplayMember = "TakimAdi";
                CbGorev_yeri.DataSource = (from a in hafizarapor.raporveritabani.Rapors
                                           where a.Gorev_Tipi=="Sehirici"
                                     select new {TakimAdi = a.Yer}).Distinct();
            }
        }

        private void RbDis_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDis.Checked == true)
            {
                CbGorev_yeri.DisplayMember = "TakimAdi";
                CbGorev_yeri.DataSource = (from a in hafizarapor.raporveritabani.Rapors
                                           where a.Gorev_Tipi == "Sehirdisi"
                                           select new { TakimAdi = a.Sehir }).Distinct();
            }
        }
    }
}
