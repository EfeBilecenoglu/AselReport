using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Raporhafiza;

namespace Raporlama.Rapor_Sil
{
    public partial class Rapor_Sil : Form
    {
        public Rapor_Sil()
        {
            InitializeComponent();
        }

        private void Rapor_Sil_Load(object sender, EventArgs e)
        {
            DtpBitis_Tarihi.Value = DtpBitis_Tarihi.Value.AddDays(7);
            Kodlar.raporfiltreligetir(DgvRapor, DtpBaslangic_Tarih, DtpBitis_Tarihi);
        }

        private void DtpBaslangic_Tarih_ValueChanged(object sender, EventArgs e)
        {
            Kodlar.raporfiltreligetir(DgvRapor, DtpBaslangic_Tarih, DtpBitis_Tarihi);
            if (DtpBaslangic_Tarih.Value>DtpBitis_Tarihi.Value)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DtpBitis_Tarihi_ValueChanged(object sender, EventArgs e)
        {
            Kodlar.raporfiltreligetir(DgvRapor, DtpBaslangic_Tarih, DtpBitis_Tarihi);
            if (DtpBaslangic_Tarih.Value> DtpBitis_Tarihi.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            hafizarapor.islem = hafizarapor.raporveritabani.Islems.Where(a => a.Islem_id==Convert.ToInt32(DgvRapor.CurrentRow.Cells[7].Value)).SingleOrDefault();
            hafizarapor.rapor = hafizarapor.raporveritabani.Rapors.Where(b => b.id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[6].Value)).SingleOrDefault();
            hafizarapor.raporveritabani.Islems.DeleteOnSubmit(hafizarapor.islem);
            hafizarapor.raporveritabani.SubmitChanges();
            if (hafizarapor.rapor.Islems.Count.ToString()=="0")
            {
                hafizarapor.raporveritabani.Rapors.DeleteOnSubmit(hafizarapor.rapor);
                hafizarapor.raporveritabani.SubmitChanges();
            }
            MessageBox.Show("İşlem kaydı başarıyla silinmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Kodlar.raporfiltreligetir(DgvRapor, DtpBaslangic_Tarih, DtpBitis_Tarihi);
        }

    }
}
