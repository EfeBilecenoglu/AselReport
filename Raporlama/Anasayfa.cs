using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raporlama
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void raporOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama.Rapor_Olustur.Rapor_Olustur form = new Raporlama.Rapor_Olustur.Rapor_Olustur();
            form.TopLevel = false;
            pnlArkaplan.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.BringToFront();
        }

        private void raporDuzeltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama.Rapor_Duzelt.Rapor_Duzelt form = new Raporlama.Rapor_Duzelt.Rapor_Duzelt();
            form.TopLevel = false;
            pnlArkaplan.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.BringToFront();
        }

        private void raporSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama.Rapor_Sil.Rapor_Sil form = new Raporlama.Rapor_Sil.Rapor_Sil();
            form.TopLevel = false;
            pnlArkaplan.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.BringToFront();
        }

        private void excelEKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama.Excele_Kaydet.Excele_Kaydet form = new Raporlama.Excele_Kaydet.Excele_Kaydet();
            form.TopLevel = false;
            pnlArkaplan.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
            form.BringToFront();
        }
    }
}
