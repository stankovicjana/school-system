namespace Projekat
{
    partial class FrmPretragaPolaznika
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
            this.btnPrikaziPolaznika = new System.Windows.Forms.Button();
            this.btnObrisiPolaznika = new System.Windows.Forms.Button();
            this.txtPrez = new System.Windows.Forms.TextBox();
            this.btnNadjiPolaznika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPronadjeniPolaznici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniPolaznici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikaziPolaznika
            // 
            this.btnPrikaziPolaznika.Location = new System.Drawing.Point(69, 482);
            this.btnPrikaziPolaznika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrikaziPolaznika.Name = "btnPrikaziPolaznika";
            this.btnPrikaziPolaznika.Size = new System.Drawing.Size(235, 59);
            this.btnPrikaziPolaznika.TabIndex = 11;
            this.btnPrikaziPolaznika.Text = "Prikaži polaznika";
            this.btnPrikaziPolaznika.UseVisualStyleBackColor = true;
            this.btnPrikaziPolaznika.Click += new System.EventHandler(this.btnPrikaziPolaznika_Click);
            // 
            // btnObrisiPolaznika
            // 
            this.btnObrisiPolaznika.Location = new System.Drawing.Point(537, 482);
            this.btnObrisiPolaznika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrisiPolaznika.Name = "btnObrisiPolaznika";
            this.btnObrisiPolaznika.Size = new System.Drawing.Size(235, 59);
            this.btnObrisiPolaznika.TabIndex = 10;
            this.btnObrisiPolaznika.Text = "Obriši polaznika";
            this.btnObrisiPolaznika.UseVisualStyleBackColor = true;
            this.btnObrisiPolaznika.Click += new System.EventHandler(this.btnObrisiPolaznika_Click);
            // 
            // txtPrez
            // 
            this.txtPrez.Location = new System.Drawing.Point(46, 89);
            this.txtPrez.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrez.Name = "txtPrez";
            this.txtPrez.Size = new System.Drawing.Size(325, 26);
            this.txtPrez.TabIndex = 9;
            // 
            // btnNadjiPolaznika
            // 
            this.btnNadjiPolaznika.Location = new System.Drawing.Point(441, 45);
            this.btnNadjiPolaznika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNadjiPolaznika.Name = "btnNadjiPolaznika";
            this.btnNadjiPolaznika.Size = new System.Drawing.Size(195, 59);
            this.btnNadjiPolaznika.TabIndex = 8;
            this.btnNadjiPolaznika.Text = "Pronadji polaznika";
            this.btnNadjiPolaznika.UseVisualStyleBackColor = true;
            this.btnNadjiPolaznika.Click += new System.EventHandler(this.btnNadjiPolaznika_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPronadjeniPolaznici);
            this.groupBox1.Location = new System.Drawing.Point(46, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(726, 316);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o pronađenim polaznicima";
            // 
            // dgvPronadjeniPolaznici
            // 
            this.dgvPronadjeniPolaznici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPronadjeniPolaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPronadjeniPolaznici.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPronadjeniPolaznici.Location = new System.Drawing.Point(11, 36);
            this.dgvPronadjeniPolaznici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPronadjeniPolaznici.Name = "dgvPronadjeniPolaznici";
            this.dgvPronadjeniPolaznici.RowHeadersWidth = 62;
            this.dgvPronadjeniPolaznici.RowTemplate.Height = 24;
            this.dgvPronadjeniPolaznici.Size = new System.Drawing.Size(680, 245);
            this.dgvPronadjeniPolaznici.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesite prezime polaznika:";
            // 
            // FrmPretragaPolaznika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 605);
            this.Controls.Add(this.btnPrikaziPolaznika);
            this.Controls.Add(this.btnObrisiPolaznika);
            this.Controls.Add(this.txtPrez);
            this.Controls.Add(this.btnNadjiPolaznika);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPretragaPolaznika";
            this.Text = "PretragaPolaznika";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniPolaznici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziPolaznika;
        private System.Windows.Forms.Button btnObrisiPolaznika;
        private System.Windows.Forms.TextBox txtPrez;
        private System.Windows.Forms.Button btnNadjiPolaznika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPronadjeniPolaznici;
        private System.Windows.Forms.Label label1;
    }
}