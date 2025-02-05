namespace Projekat
{
    partial class PrikaziTest
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.txtGrupa = new System.Windows.Forms.TextBox();
            this.txtPolaznik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(419, 34);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(299, 26);
            this.dtpDatum.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Grupa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Polaznik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Rezultat testa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Datum polaganja testa";
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(419, 97);
            this.txtRezultat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(299, 26);
            this.txtRezultat.TabIndex = 34;
            // 
            // txtGrupa
            // 
            this.txtGrupa.Location = new System.Drawing.Point(419, 168);
            this.txtGrupa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrupa.Name = "txtGrupa";
            this.txtGrupa.Size = new System.Drawing.Size(299, 26);
            this.txtGrupa.TabIndex = 41;
            // 
            // txtPolaznik
            // 
            this.txtPolaznik.Location = new System.Drawing.Point(419, 248);
            this.txtPolaznik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPolaznik.Name = "txtPolaznik";
            this.txtPolaznik.Size = new System.Drawing.Size(299, 26);
            this.txtPolaznik.TabIndex = 42;
            // 
            // PrikaziTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 342);
            this.Controls.Add(this.txtPolaznik);
            this.Controls.Add(this.txtGrupa);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRezultat);
            this.Name = "PrikaziTest";
            this.Text = "PrikaziGrupu";
            this.Load += new System.EventHandler(this.PrikaziGrupu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.TextBox txtGrupa;
        private System.Windows.Forms.TextBox txtPolaznik;
    }
}