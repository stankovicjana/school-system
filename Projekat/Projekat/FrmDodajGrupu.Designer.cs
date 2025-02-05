namespace Projekat
{
    partial class FrmDodajGrupu
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
            this.txtTermin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZapamtiGrupu = new System.Windows.Forms.Button();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPolaznici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolaznici)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTermin
            // 
            this.txtTermin.Location = new System.Drawing.Point(127, 81);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(254, 22);
            this.txtTermin.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Termin:";
            // 
            // cmbKurs
            // 
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Location = new System.Drawing.Point(127, 132);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(252, 24);
            this.cmbKurs.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kurs:";
            // 
            // btnZapamtiGrupu
            // 
            this.btnZapamtiGrupu.Location = new System.Drawing.Point(493, 63);
            this.btnZapamtiGrupu.Name = "btnZapamtiGrupu";
            this.btnZapamtiGrupu.Size = new System.Drawing.Size(294, 58);
            this.btnZapamtiGrupu.TabIndex = 41;
            this.btnZapamtiGrupu.Text = "Zapamti novu grupu";
            this.btnZapamtiGrupu.UseVisualStyleBackColor = true;
            this.btnZapamtiGrupu.Click += new System.EventHandler(this.btnZapamtiGrupu_Click);
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(127, 28);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(254, 22);
            this.txtNazivGrupe.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Naziv grupe:";
            // 
            // dgvPolaznici
            // 
            this.dgvPolaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolaznici.Location = new System.Drawing.Point(23, 181);
            this.dgvPolaznici.Name = "dgvPolaznici";
            this.dgvPolaznici.RowHeadersWidth = 51;
            this.dgvPolaznici.RowTemplate.Height = 24;
            this.dgvPolaznici.Size = new System.Drawing.Size(764, 316);
            this.dgvPolaznici.TabIndex = 46;
            // 
            // FrmDodajGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 540);
            this.Controls.Add(this.dgvPolaznici);
            this.Controls.Add(this.txtTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZapamtiGrupu);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label3);
            this.Name = "FrmDodajGrupu";
            this.Text = "FrmDodajGrupu";
            this.Load += new System.EventHandler(this.FrmDodajGrupu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolaznici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTermin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZapamtiGrupu;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPolaznici;
    }
}