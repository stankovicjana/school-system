namespace Projekat
{
    partial class PrikazGrupe
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPolaznik = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzmeniGrupu = new System.Windows.Forms.Button();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTermin
            // 
            this.txtTermin.Location = new System.Drawing.Point(134, 152);
            this.txtTermin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(285, 26);
            this.txtTermin.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Termin:";
            // 
            // cmbKurs
            // 
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Location = new System.Drawing.Point(134, 215);
            this.cmbKurs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(283, 28);
            this.cmbKurs.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Kurs:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(855, 506);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(226, 72);
            this.btnObrisi.TabIndex = 46;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(544, 506);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(226, 72);
            this.btnDodaj.TabIndex = 45;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Polaznik";
            // 
            // cmbPolaznik
            // 
            this.cmbPolaznik.FormattingEnabled = true;
            this.cmbPolaznik.Location = new System.Drawing.Point(698, 377);
            this.cmbPolaznik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPolaznik.Name = "cmbPolaznik";
            this.cmbPolaznik.Size = new System.Drawing.Size(283, 28);
            this.cmbPolaznik.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(495, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(777, 269);
            this.dataGridView1.TabIndex = 40;
            // 
            // btnIzmeniGrupu
            // 
            this.btnIzmeniGrupu.Location = new System.Drawing.Point(59, 354);
            this.btnIzmeniGrupu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzmeniGrupu.Name = "btnIzmeniGrupu";
            this.btnIzmeniGrupu.Size = new System.Drawing.Size(331, 72);
            this.btnIzmeniGrupu.TabIndex = 42;
            this.btnIzmeniGrupu.Text = "Izmeni grupu";
            this.btnIzmeniGrupu.UseVisualStyleBackColor = true;
            this.btnIzmeniGrupu.Click += new System.EventHandler(this.btnIzmeniGrupu_Click);
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(134, 86);
            this.txtNazivGrupe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(285, 26);
            this.txtNazivGrupe.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Naziv grupe:";
            // 
            // PrikazGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 627);
            this.Controls.Add(this.txtTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPolaznik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzmeniGrupu);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label3);
            this.Name = "PrikazGrupe";
            this.Text = "PrikazGrupe";
            this.Load += new System.EventHandler(this.PrikazGrupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTermin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPolaznik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzmeniGrupu;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.Label label3;
    }
}