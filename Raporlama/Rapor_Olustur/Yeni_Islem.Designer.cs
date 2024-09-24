namespace Raporlama.Rapor_Olustur
{
    partial class Yeni_Islem
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
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtIslem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(264, 71);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 0;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtIslem
            // 
            this.txtIslem.Location = new System.Drawing.Point(12, 12);
            this.txtIslem.Multiline = true;
            this.txtIslem.Name = "txtIslem";
            this.txtIslem.Size = new System.Drawing.Size(267, 53);
            this.txtIslem.TabIndex = 1;
            // 
            // Yeni_Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 97);
            this.Controls.Add(this.txtIslem);
            this.Controls.Add(this.btnOnayla);
            this.Name = "Yeni_Islem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni İslem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtIslem;
    }
}