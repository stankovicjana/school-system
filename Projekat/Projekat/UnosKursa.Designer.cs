namespace Projekat
{
    partial class UnosKursa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosKursa));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbJezik = new System.Windows.Forms.ComboBox();
            this.cmbNastavnik = new System.Windows.Forms.ComboBox();
            this.txtNazivK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCenaK = new System.Windows.Forms.TextBox();
            this.btnZapamtiKurs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNivo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv kursa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nastavnik:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jezik:";
            // 
            // cmbJezik
            // 
            this.cmbJezik.FormattingEnabled = true;
            this.cmbJezik.Location = new System.Drawing.Point(133, 197);
            this.cmbJezik.Name = "cmbJezik";
            this.cmbJezik.Size = new System.Drawing.Size(252, 24);
            this.cmbJezik.TabIndex = 6;
            // 
            // cmbNastavnik
            // 
            this.cmbNastavnik.FormattingEnabled = true;
            this.cmbNastavnik.Location = new System.Drawing.Point(133, 138);
            this.cmbNastavnik.Name = "cmbNastavnik";
            this.cmbNastavnik.Size = new System.Drawing.Size(252, 24);
            this.cmbNastavnik.TabIndex = 10;
            // 
            // txtNazivK
            // 
            this.txtNazivK.Location = new System.Drawing.Point(133, 33);
            this.txtNazivK.Name = "txtNazivK";
            this.txtNazivK.Size = new System.Drawing.Size(254, 22);
            this.txtNazivK.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cena:";
            // 
            // txtCenaK
            // 
            this.txtCenaK.Location = new System.Drawing.Point(133, 89);
            this.txtCenaK.Name = "txtCenaK";
            this.txtCenaK.Size = new System.Drawing.Size(254, 22);
            this.txtCenaK.TabIndex = 13;
            // 
            // btnZapamtiKurs
            // 
            this.btnZapamtiKurs.BackColor = System.Drawing.Color.OldLace;
            this.btnZapamtiKurs.Location = new System.Drawing.Point(60, 304);
            this.btnZapamtiKurs.Name = "btnZapamtiKurs";
            this.btnZapamtiKurs.Size = new System.Drawing.Size(294, 58);
            this.btnZapamtiKurs.TabIndex = 14;
            this.btnZapamtiKurs.Text = "Zapamti novi kurs";
            this.btnZapamtiKurs.UseVisualStyleBackColor = false;
            this.btnZapamtiKurs.Click += new System.EventHandler(this.btnZapamtiKurs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nivo:";
            // 
            // cmbNivo
            // 
            this.cmbNivo.FormattingEnabled = true;
            this.cmbNivo.Location = new System.Drawing.Point(133, 244);
            this.cmbNivo.Name = "cmbNivo";
            this.cmbNivo.Size = new System.Drawing.Size(252, 24);
            this.cmbNivo.TabIndex = 19;
            // 
            // UnosKursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 435);
            this.Controls.Add(this.cmbNivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZapamtiKurs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCenaK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNazivK);
            this.Controls.Add(this.cmbJezik);
            this.Controls.Add(this.cmbNastavnik);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UnosKursa";
            this.Text = "UnosKursaForm2";
            this.Load += new System.EventHandler(this.UnosKursa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbJezik;
        private System.Windows.Forms.ComboBox cmbNastavnik;
        private System.Windows.Forms.TextBox txtNazivK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCenaK;
        private System.Windows.Forms.Button btnZapamtiKurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNivo;
    }
}