namespace Projekat
{
    partial class FrmPrikaziTestove
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
            this.btnDodajTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.btnDodajPolaznike = new System.Windows.Forms.Button();
            this.cmbGrupe = new System.Windows.Forms.ComboBox();
            this.cmbPolaznik = new System.Windows.Forms.ComboBox();
            this.btnZapamtiTestove = new System.Windows.Forms.Button();
            this.btnObrisiTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(660, 35);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(266, 22);
            this.dtpDatum.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Grupa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Polaznik";
            // 
            // btnDodajTest
            // 
            this.btnDodajTest.Location = new System.Drawing.Point(512, 358);
            this.btnDodajTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajTest.Name = "btnDodajTest";
            this.btnDodajTest.Size = new System.Drawing.Size(184, 28);
            this.btnDodajTest.TabIndex = 24;
            this.btnDodajTest.Text = "Dodaj rezultat testa";
            this.btnDodajTest.UseVisualStyleBackColor = true;
            this.btnDodajTest.Click += new System.EventHandler(this.btnDodajTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Rezultat testa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Datum polaganja testa";
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(660, 86);
            this.txtRezultat.Margin = new System.Windows.Forms.Padding(4);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(266, 22);
            this.txtRezultat.TabIndex = 21;
            // 
            // btnDodajPolaznike
            // 
            this.btnDodajPolaznike.Location = new System.Drawing.Point(152, 89);
            this.btnDodajPolaznike.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajPolaznike.Name = "btnDodajPolaznike";
            this.btnDodajPolaznike.Size = new System.Drawing.Size(268, 28);
            this.btnDodajPolaznike.TabIndex = 30;
            this.btnDodajPolaznike.Text = "Izaberi polaznika iz grupe";
            this.btnDodajPolaznike.UseVisualStyleBackColor = true;
            this.btnDodajPolaznike.Click += new System.EventHandler(this.btnDodajPolaznike_Click);
            // 
            // cmbGrupe
            // 
            this.cmbGrupe.FormattingEnabled = true;
            this.cmbGrupe.Location = new System.Drawing.Point(152, 32);
            this.cmbGrupe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGrupe.Name = "cmbGrupe";
            this.cmbGrupe.Size = new System.Drawing.Size(266, 24);
            this.cmbGrupe.TabIndex = 32;
            // 
            // cmbPolaznik
            // 
            this.cmbPolaznik.FormattingEnabled = true;
            this.cmbPolaznik.Location = new System.Drawing.Point(154, 149);
            this.cmbPolaznik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPolaznik.Name = "cmbPolaznik";
            this.cmbPolaznik.Size = new System.Drawing.Size(266, 24);
            this.cmbPolaznik.TabIndex = 33;
            // 
            // btnZapamtiTestove
            // 
            this.btnZapamtiTestove.Location = new System.Drawing.Point(178, 302);
            this.btnZapamtiTestove.Margin = new System.Windows.Forms.Padding(4);
            this.btnZapamtiTestove.Name = "btnZapamtiTestove";
            this.btnZapamtiTestove.Size = new System.Drawing.Size(184, 28);
            this.btnZapamtiTestove.TabIndex = 34;
            this.btnZapamtiTestove.Text = "Zapamti testove";
            this.btnZapamtiTestove.UseVisualStyleBackColor = true;
            this.btnZapamtiTestove.Click += new System.EventHandler(this.btnZapamtiTestove_Click);
            // 
            // btnObrisiTest
            // 
            this.btnObrisiTest.Location = new System.Drawing.Point(719, 358);
            this.btnObrisiTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiTest.Name = "btnObrisiTest";
            this.btnObrisiTest.Size = new System.Drawing.Size(184, 28);
            this.btnObrisiTest.TabIndex = 35;
            this.btnObrisiTest.Text = "Obrisi rezultat testa";
            this.btnObrisiTest.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(441, 163);
            this.dataGridView1.TabIndex = 36;
            // 
            // FrmPrikaziTestove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnObrisiTest);
            this.Controls.Add(this.btnZapamtiTestove);
            this.Controls.Add(this.cmbPolaznik);
            this.Controls.Add(this.cmbGrupe);
            this.Controls.Add(this.btnDodajPolaznike);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRezultat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrikaziTestove";
            this.Text = "FrmPrikaziTestove";
            this.Load += new System.EventHandler(this.FrmPrikaziTestove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Button btnDodajPolaznike;
        private System.Windows.Forms.ComboBox cmbGrupe;
        private System.Windows.Forms.ComboBox cmbPolaznik;
        private System.Windows.Forms.Button btnZapamtiTestove;
        private System.Windows.Forms.Button btnObrisiTest;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}