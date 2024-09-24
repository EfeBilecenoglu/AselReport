namespace Raporlama.Rapor_Duzelt
{
    partial class Rapor_Duzelt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.DgvRapor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RbDis = new System.Windows.Forms.RadioButton();
            this.RbIc = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbGorev_yeri = new System.Windows.Forms.ComboBox();
            this.DtpTarih = new System.Windows.Forms.DateTimePicker();
            this.CbPersonel_İsmi = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Transparent;
            this.pnl1.Controls.Add(this.DgvRapor);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(641, 261);
            this.pnl1.TabIndex = 0;
            // 
            // DgvRapor
            // 
            this.DgvRapor.AllowUserToAddRows = false;
            this.DgvRapor.AllowUserToDeleteRows = false;
            this.DgvRapor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRapor.DefaultCellStyle = dataGridViewCellStyle20;
            this.DgvRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRapor.Location = new System.Drawing.Point(0, 0);
            this.DgvRapor.MultiSelect = false;
            this.DgvRapor.Name = "DgvRapor";
            this.DgvRapor.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRapor.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DgvRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRapor.Size = new System.Drawing.Size(641, 261);
            this.DgvRapor.TabIndex = 0;
            this.DgvRapor.Click += new System.EventHandler(this.DgvRapor_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "islem";
            this.Column1.HeaderText = "İşlemler";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tarih";
            this.Column2.HeaderText = "Tarih";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "personel";
            this.Column3.HeaderText = "Görevli Personel";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gorevtipi";
            this.Column4.HeaderText = "Görev Tipi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "yer";
            this.Column5.HeaderText = "Yer";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sehir";
            this.Column6.HeaderText = "Şehir";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "id";
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "islemid";
            this.Column8.HeaderText = "islemid";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // RbDis
            // 
            this.RbDis.AutoSize = true;
            this.RbDis.BackColor = System.Drawing.Color.Transparent;
            this.RbDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbDis.ForeColor = System.Drawing.Color.Red;
            this.RbDis.Location = new System.Drawing.Point(447, 264);
            this.RbDis.Name = "RbDis";
            this.RbDis.Size = new System.Drawing.Size(93, 20);
            this.RbDis.TabIndex = 23;
            this.RbDis.Text = "Şehir Dışı";
            this.RbDis.UseVisualStyleBackColor = false;
            this.RbDis.CheckedChanged += new System.EventHandler(this.RbDis_CheckedChanged);
            // 
            // RbIc
            // 
            this.RbIc.AutoSize = true;
            this.RbIc.BackColor = System.Drawing.Color.Transparent;
            this.RbIc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbIc.ForeColor = System.Drawing.Color.Red;
            this.RbIc.Location = new System.Drawing.Point(348, 264);
            this.RbIc.Name = "RbIc";
            this.RbIc.Size = new System.Drawing.Size(82, 20);
            this.RbIc.TabIndex = 22;
            this.RbIc.Text = "Şehir İçi";
            this.RbIc.UseVisualStyleBackColor = false;
            this.RbIc.CheckedChanged += new System.EventHandler(this.RbIc_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(249, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "GÖREV TİPİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(288, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "TARİH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(242, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "GÖREV YERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "AÇIKLAMA";
            // 
            // CbGorev_yeri
            // 
            this.CbGorev_yeri.FormattingEnabled = true;
            this.CbGorev_yeri.Location = new System.Drawing.Point(354, 324);
            this.CbGorev_yeri.Name = "CbGorev_yeri";
            this.CbGorev_yeri.Size = new System.Drawing.Size(121, 21);
            this.CbGorev_yeri.TabIndex = 16;
            // 
            // DtpTarih
            // 
            this.DtpTarih.Location = new System.Drawing.Point(354, 294);
            this.DtpTarih.Name = "DtpTarih";
            this.DtpTarih.Size = new System.Drawing.Size(200, 20);
            this.DtpTarih.TabIndex = 15;
            // 
            // CbPersonel_İsmi
            // 
            this.CbPersonel_İsmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPersonel_İsmi.FormattingEnabled = true;
            this.CbPersonel_İsmi.Items.AddRange(new object[] {
            "Ahmet Efe",
            "Habip",
            "Ahmet Efe/Habip"});
            this.CbPersonel_İsmi.Location = new System.Drawing.Point(354, 354);
            this.CbPersonel_İsmi.Name = "CbPersonel_İsmi";
            this.CbPersonel_İsmi.Size = new System.Drawing.Size(121, 21);
            this.CbPersonel_İsmi.TabIndex = 14;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(16, 283);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(212, 121);
            this.txtAciklama.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(253, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "PERSONEL";
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDuzelt.ForeColor = System.Drawing.Color.Red;
            this.btnDuzelt.Location = new System.Drawing.Point(510, 322);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(120, 82);
            this.btnDuzelt.TabIndex = 25;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // Rapor_Duzelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Raporlama.Properties.Resources.Yeni_Bit_Eşlem_Resmi;
            this.ClientSize = new System.Drawing.Size(641, 410);
            this.Controls.Add(this.btnDuzelt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RbDis);
            this.Controls.Add(this.RbIc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbGorev_yeri);
            this.Controls.Add(this.DtpTarih);
            this.Controls.Add(this.CbPersonel_İsmi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapor_Duzelt";
            this.Text = "Rapor_Duzelt";
            this.Load += new System.EventHandler(this.Rapor_Duzelt_Load);
            this.pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.RadioButton RbDis;
        private System.Windows.Forms.RadioButton RbIc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbGorev_yeri;
        private System.Windows.Forms.DateTimePicker DtpTarih;
        private System.Windows.Forms.ComboBox CbPersonel_İsmi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDuzelt;
        internal System.Windows.Forms.DataGridView DgvRapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}