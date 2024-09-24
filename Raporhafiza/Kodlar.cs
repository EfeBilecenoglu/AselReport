using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raporhafiza
{
    public static class Kodlar
    {
        static public void raporgetir(DataGridView dgv)
    {
        dgv.DataSource = (from a in hafizarapor.raporveritabani.Rapors
                          from b in hafizarapor.raporveritabani.Islems.Where(b => b.rapor_id == a.id)
                          orderby a.Tarih.Value
                          select new
                          {
                              islem=b.Aciklama,
                              tarih=a.Tarih,
                              personel=a.Gorevli_Personel,
                              gorevtipi=a.Gorev_Tipi,
                              yer=a.Yer,
                              sehir=a.Sehir,
                              id=a.id,
                              islemid=b.Islem_id
                          }).Distinct();
    }
        static public void raporfiltreligetir(DataGridView dgv, DateTimePicker dtpbaslangic, DateTimePicker dtpbitis)
        {
            dgv.DataSource = (from a in hafizarapor.raporveritabani.Rapors
                              from b in hafizarapor.raporveritabani.Islems.Where(b => b.rapor_id == a.id)
                              orderby a.Tarih.Value
                              where dtpbaslangic.Value<=a.Tarih.Value.AddDays(1) && dtpbitis.Value>=a.Tarih
                              select new
                              {
                                  islem = b.Aciklama,
                                  tarih = a.Tarih,
                                  personel = a.Gorevli_Personel,
                                  gorevtipi = a.Gorev_Tipi,
                                  yer = a.Yer,
                                  sehir = a.Sehir,
                                  id = a.id,
                                  islemid = b.Islem_id
                              }).Distinct();
        }

        static public void raporuexcelefiltreligetir(DataGridView dgv, DateTimePicker dtpbaslangic, DateTimePicker dtpbitis)
        {
            dgv.DataSource = ((from a in hafizarapor.raporveritabani.Rapors
                              from b in hafizarapor.raporveritabani.Islems.Where(b => b.rapor_id == a.id)
                              orderby a.Tarih.Value
                              where dtpbaslangic.Value <= a.Tarih.Value.AddDays(1) && dtpbitis.Value >= a.Tarih
                              select new
                              {
                                  islem = b.Aciklama,
                                  tarih = a.Tarih,
                                  personel = a.Gorevli_Personel,
                                  gorevtipi = a.Gorev_Tipi,
                                  yer = a.Yer,
                                  sehir = a.Sehir,
                                  id = a.id,
                                  islemid = b.Islem_id
                              }).Distinct()).FirstOrDefault();
        }
    }
}
