using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Raporhafiza;

namespace Raporlama.Rapor_Duzelt
{
    public partial class Rapor_Duzelt : Form
    {
        public Rapor_Duzelt()
        {
            InitializeComponent();
        }

        private void Rapor_Duzelt_Load(object sender, EventArgs e)
        {
            Kodlar.raporgetir(DgvRapor);
            hafizarapor.rapor = hafizarapor.raporveritabani.Rapors.Where(c => c.id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[6].Value)).SingleOrDefault();
            hafizarapor.islem = hafizarapor.raporveritabani.Islems.Where(a => a.Islem_id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[7].Value)).SingleOrDefault();
            txtAciklama.Text = hafizarapor.islem.Aciklama;
        }
        private void DgvRapor_Click(object sender, EventArgs e)
        {
            hafizarapor.rapor = hafizarapor.raporveritabani.Rapors.Where(c => c.id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[6].Value)).SingleOrDefault();
            hafizarapor.islem = hafizarapor.raporveritabani.Islems.Where(a => a.Islem_id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[7].Value)).SingleOrDefault();
            txtAciklama.Text = hafizarapor.islem.Aciklama;
            DtpTarih.Value = Convert.ToDateTime(hafizarapor.rapor.Tarih.Value.ToShortDateString());
            if (hafizarapor.rapor.Gorevli_Personel=="Ahmet Efe")
            {
                CbPersonel_İsmi.Text = "Ahmet Efe";
            }
            else if (hafizarapor.rapor.Gorevli_Personel == "Habip")
            {
                CbPersonel_İsmi.Text = "Habip";
            }
            else
            {
                CbPersonel_İsmi.Text = "Ahmet Efe/Habip";
            }
            if (hafizarapor.rapor.Gorev_Tipi=="Sehirici")
            {
                RbIc.Checked = true;
                CbGorev_yeri.DisplayMember = "TakimAdi";
                CbGorev_yeri.DataSource = (from a in hafizarapor.raporveritabani.Rapors
                                           where a.Gorev_Tipi == "Sehirici"
                                           select new { TakimAdi = a.Yer }).Distinct();
                CbGorev_yeri.Text = hafizarapor.rapor.Yer;
            }
            else
            {
                RbDis.Checked = true;
                CbGorev_yeri.DisplayMember = "TakimAdi";
                CbGorev_yeri.DataSource = (from a in hafizarapor.raporveritabani.Rapors
                                           where a.Gorev_Tipi == "Sehirdisi"
                                           select new { TakimAdi = a.Sehir }).Distinct();
                CbGorev_yeri.Text = hafizarapor.rapor.Sehir;
            }
        }
        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            if (RbIc.Checked == true)
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
            if (CbPersonel_İsmi.Text=="Ahmet Efe/Habip")
            {
                hafizarapor.rapor.Gorevli_Personel = "Ahmet Efe" + ", " + "Habip";
            }
            else if (CbPersonel_İsmi.Text=="Ahmet Efe")
            {
                hafizarapor.rapor.Gorevli_Personel = "Ahmet Efe";
            }
            else
            {
                hafizarapor.rapor.Gorevli_Personel ="Habip";
            }
            hafizarapor.rapor.Tarih = Convert.ToDateTime(DtpTarih.Value.ToShortDateString());
            hafizarapor.raporveritabani.SubmitChanges();
            hafizarapor.islem.rapor_id = hafizarapor.rapor.id;
            hafizarapor.islem.Aciklama = txtAciklama.Text;
            hafizarapor.raporveritabani.SubmitChanges();
            MessageBox.Show("Düzenleme işlemi kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Kodlar.raporgetir(DgvRapor);
            }

        private void RbIc_CheckedChanged(object sender, EventArgs e)
        {
            CbGorev_yeri.DisplayMember = "TakimAdi";
            CbGorev_yeri.DataSource = (from a in hafizarapor.raporveritabani.Rapors
                                       where a.Gorev_Tipi == "Sehirici"
                                       select new { TakimAdi = a.Yer }).Distinct();
            CbGorev_yeri.Text = hafizarapor.rapor.Yer;
            
        }
        private void RbDis_CheckedChanged(object sender, EventArgs e)
        {
            CbGorev_yeri.DisplayMember = "TakimAdi";
            CbGorev_yeri.DataSource = (from a in hafizarapor.raporveritabani.Rapors
                                       where a.Gorev_Tipi == "Sehirdisi"
                                       select new { TakimAdi = a.Sehir }).Distinct();
            CbGorev_yeri.Text = hafizarapor.rapor.Sehir;
        }
        }

    }