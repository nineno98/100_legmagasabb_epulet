
namespace _100_legmagasabb_GUI
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orszag_gomb = new System.Windows.Forms.Button();
            this.osszemelet_gomb = new System.Windows.Forms.Button();
            this.Ország = new System.Windows.Forms.Label();
            this.atlagos_emeletszam_lab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 526);
            this.dataGridView1.TabIndex = 0;
            // 
            // orszag_gomb
            // 
            this.orszag_gomb.Location = new System.Drawing.Point(56, 35);
            this.orszag_gomb.Name = "orszag_gomb";
            this.orszag_gomb.Size = new System.Drawing.Size(123, 48);
            this.orszag_gomb.TabIndex = 1;
            this.orszag_gomb.Text = "Ország";
            this.orszag_gomb.UseVisualStyleBackColor = true;
            // 
            // osszemelet_gomb
            // 
            this.osszemelet_gomb.Location = new System.Drawing.Point(54, 229);
            this.osszemelet_gomb.Name = "osszemelet_gomb";
            this.osszemelet_gomb.Size = new System.Drawing.Size(124, 62);
            this.osszemelet_gomb.TabIndex = 2;
            this.osszemelet_gomb.Text = "Összemelet";
            this.osszemelet_gomb.UseVisualStyleBackColor = true;
            // 
            // Ország
            // 
            this.Ország.AutoSize = true;
            this.Ország.Location = new System.Drawing.Point(70, 148);
            this.Ország.Name = "Ország";
            this.Ország.Size = new System.Drawing.Size(40, 13);
            this.Ország.TabIndex = 3;
            this.Ország.Text = "Ország";
            // 
            // atlagos_emeletszam_lab
            // 
            this.atlagos_emeletszam_lab.AutoSize = true;
            this.atlagos_emeletszam_lab.Location = new System.Drawing.Point(65, 318);
            this.atlagos_emeletszam_lab.Name = "atlagos_emeletszam_lab";
            this.atlagos_emeletszam_lab.Size = new System.Drawing.Size(0, 13);
            this.atlagos_emeletszam_lab.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 550);
            this.Controls.Add(this.atlagos_emeletszam_lab);
            this.Controls.Add(this.Ország);
            this.Controls.Add(this.osszemelet_gomb);
            this.Controls.Add(this.orszag_gomb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button orszag_gomb;
        private System.Windows.Forms.Button osszemelet_gomb;
        private System.Windows.Forms.Label Ország;
        private System.Windows.Forms.Label atlagos_emeletszam_lab;
    }
}

