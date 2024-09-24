using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Raporhafiza;
using Excel = Microsoft.Office.Interop.Excel;

namespace Raporlama.Excele_Kaydet
{
    public partial class Excele_Kaydet : Form
    {
        public Excele_Kaydet()
        {
            InitializeComponent();
        }

        private void Excele_Kaydet_Load(object sender, EventArgs e)
        {
            DtpBitis_Tarihi.Value = DtpBitis_Tarihi.Value.AddDays(7);
            Kodlar.raporuexcelefiltreligetir(DgvRapor, DtpBaslangic_Tarih, DtpBitis_Tarihi);
        }

        private void DtpBaslangic_Tarih_ValueChanged(object sender, EventArgs e)
        {
            Kodlar.raporuexcelefiltreligetir(DgvRapor, DtpBaslangic_Tarih, DtpBitis_Tarihi);
            if (DtpBaslangic_Tarih.Value > DtpBitis_Tarihi.Value)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DtpBitis_Tarihi_ValueChanged(object sender, EventArgs e)
        {
            Kodlar.raporuexcelefiltreligetir(DgvRapor, DtpBaslangic_Tarih, DtpBitis_Tarihi);
            if (DtpBaslangic_Tarih.Value > DtpBitis_Tarihi.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            hafizarapor.islem = hafizarapor.raporveritabani.Islems.Where(a => a.Islem_id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[7].Value)).SingleOrDefault();
            hafizarapor.rapor = hafizarapor.raporveritabani.Rapors.Where(b => b.id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[6].Value)).SingleOrDefault();
            if (hafizarapor.rapor.Gorev_Tipi=="Sehirici")
            {
                string path1 = Application.StartupPath.ToString() + "\\Sehir Ici Rapor.xlsx";
                Excel.Application ExcelUygulama = new Excel.Application();
                Excel.Workbook orjBook;
                Excel.Worksheet orjSheet;
                Microsoft.Office.Interop.Excel.Range orjRange;
                orjBook = ExcelUygulama.Workbooks.Open(path1);
                ExcelUygulama.Visible = true;
                orjSheet = orjBook.Sheets["Sayfa1"];
                int baslangıcsutun = 1;
                int baslangıcsatir = 3;
                orjRange = orjSheet.Cells[1, 5];
                orjRange.Value2 = hafizarapor.rapor.Tarih.Value.ToShortDateString();
                for (int j = 0; j < hafizarapor.rapor.Islems.Count; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 0)
                        {
                            orjRange = orjSheet.Cells[baslangıcsatir + j, baslangıcsutun + i];
                            orjRange.Value2 = j + 1;
                        }
                        else if (i == 1)
                        {
                            orjRange = orjSheet.Cells[baslangıcsatir + j, baslangıcsutun + i];
                            orjRange.Value2 = hafizarapor.islem.Aciklama;
                            hafizarapor.islem = hafizarapor.raporveritabani.Islems.Where(a => a.Islem_id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[7].Value)+j+1).SingleOrDefault();

                        }
                        if (i == 2)
                        {
                            orjRange = orjSheet.Cells[baslangıcsatir + j, baslangıcsutun + i];
                            orjRange.Value2 = hafizarapor.rapor.Yer;
                        }
                        else if (i == 3)
                        {
                            orjRange = orjSheet.Cells[baslangıcsatir + j, baslangıcsutun + i];
                            orjRange.Value2 = hafizarapor.rapor.Gorevli_Personel;
                        }
                    }
                    System.GC.Collect();
                }
                System.GC.Collect();
                
            }
            else
            {
                    string path1 = Application.StartupPath.ToString() + "\\Sehir Disi Rapor.xlsx";
                    Excel.Application ExcelUygulama = new Excel.Application();
                    Excel.Workbook orjBook;
                    Excel.Worksheet orjSheet;
                    Microsoft.Office.Interop.Excel.Range orjRange;
                    orjBook = ExcelUygulama.Workbooks.Open(path1);
                    ExcelUygulama.Visible = true;
                    orjSheet = orjBook.Sheets["Sayfa1"];
                    int baslangıcsutun = 1;
                    int baslangıcsatir = 3;
                    orjRange = orjSheet.Cells[1, 5];
                    orjRange.Value2 = hafizarapor.rapor.Tarih.Value.ToShortDateString();
                    for (int j = 0; j < hafizarapor.rapor.Islems.Count; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (i == 0)
                            {
                                orjRange = orjSheet.Cells[baslangıcsatir + j, baslangıcsutun + i];
                                orjRange.Value2 = j + 1;
                            }
                            else if (i == 1)
                            {
                                orjRange = orjSheet.Cells[baslangıcsatir + j, baslangıcsutun + i];
                                orjRange.Value2 = hafizarapor.islem.Aciklama;
                                hafizarapor.islem = hafizarapor.raporveritabani.Islems.Where(a => a.Islem_id == Convert.ToInt32(DgvRapor.CurrentRow.Cells[7].Value) + j + 1).SingleOrDefault();

                            }
                            if (i == 2)
                            {
                                orjRange = orjSheet.Cells[baslangıcsatir + j, baslangıcsutun + i];
                                orjRange.Value2 = hafizarapor.rapor.Sehir;
                            }
                            else if (i == 3)
                            {
                                orjRange = orjSheet.Cells[baslangıcsatir + j, baslangıcsutun + i];
                                orjRange.Value2 = hafizarapor.rapor.Gorevli_Personel;
                            }
                        }
                        System.GC.Collect();
                    }
                    System.GC.Collect();

                }
        }
    }
}
