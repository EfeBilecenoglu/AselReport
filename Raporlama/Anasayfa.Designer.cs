namespace Raporlama
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raporOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporDuzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelEKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlArkaplan = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporOlusturToolStripMenuItem,
            this.raporDuzeltToolStripMenuItem,
            this.raporSilToolStripMenuItem,
            this.excelEKaydetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(137, 410);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raporOlusturToolStripMenuItem
            // 
            this.raporOlusturToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporOlusturToolStripMenuItem.Name = "raporOlusturToolStripMenuItem";
            this.raporOlusturToolStripMenuItem.Size = new System.Drawing.Size(124, 25);
            this.raporOlusturToolStripMenuItem.Text = "Rapor Oluştur";
            this.raporOlusturToolStripMenuItem.Click += new System.EventHandler(this.raporOluşturToolStripMenuItem_Click);
            // 
            // raporDuzeltToolStripMenuItem
            // 
            this.raporDuzeltToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.raporDuzeltToolStripMenuItem.Name = "raporDuzeltToolStripMenuItem";
            this.raporDuzeltToolStripMenuItem.Size = new System.Drawing.Size(124, 25);
            this.raporDuzeltToolStripMenuItem.Text = "Rapor Düzelt";
            this.raporDuzeltToolStripMenuItem.Click += new System.EventHandler(this.raporDuzeltToolStripMenuItem_Click);
            // 
            // raporSilToolStripMenuItem
            // 
            this.raporSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.raporSilToolStripMenuItem.Name = "raporSilToolStripMenuItem";
            this.raporSilToolStripMenuItem.Size = new System.Drawing.Size(124, 25);
            this.raporSilToolStripMenuItem.Text = "Rapor Sil";
            this.raporSilToolStripMenuItem.Click += new System.EventHandler(this.raporSilToolStripMenuItem_Click);
            // 
            // excelEKaydetToolStripMenuItem
            // 
            this.excelEKaydetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.excelEKaydetToolStripMenuItem.Name = "excelEKaydetToolStripMenuItem";
            this.excelEKaydetToolStripMenuItem.Size = new System.Drawing.Size(124, 25);
            this.excelEKaydetToolStripMenuItem.Text = "Excel e kaydet";
            this.excelEKaydetToolStripMenuItem.Click += new System.EventHandler(this.excelEKaydetToolStripMenuItem_Click);
            // 
            // pnlArkaplan
            // 
            this.pnlArkaplan.AllowDrop = true;
            this.pnlArkaplan.BackColor = System.Drawing.Color.Transparent;
            this.pnlArkaplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArkaplan.Location = new System.Drawing.Point(137, 0);
            this.pnlArkaplan.Name = "pnlArkaplan";
            this.pnlArkaplan.Size = new System.Drawing.Size(641, 410);
            this.pnlArkaplan.TabIndex = 1;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Raporlama.Properties.Resources.Yeni_Bit_Eşlem_Resmi;
            this.ClientSize = new System.Drawing.Size(778, 410);
            this.Controls.Add(this.pnlArkaplan);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlama";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raporOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporDuzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelEKaydetToolStripMenuItem;
        private System.Windows.Forms.Panel pnlArkaplan;
    }
}

