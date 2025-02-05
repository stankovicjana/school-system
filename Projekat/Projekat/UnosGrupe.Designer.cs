namespace Projekat
{
    partial class UnosGrupe
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
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPolaznik = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZapamtiGrupu = new System.Windows.Forms.Button();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTermin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKurs
            // 
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Location = new System.Drawing.Point(190, 210);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(252, 24);
            this.cmbKurs.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kurs:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(831, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 58);
            this.button2.TabIndex = 34;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 58);
            this.button1.TabIndex = 33;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Polaznik";
            // 
            // cmbPolaznik
            // 
            this.cmbPolaznik.FormattingEnabled = true;
            this.cmbPolaznik.Location = new System.Drawing.Point(692, 339);
            this.cmbPolaznik.Name = "cmbPolaznik";
            this.cmbPolaznik.Size = new System.Drawing.Size(252, 24);
            this.cmbPolaznik.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(511, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 215);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnZapamtiGrupu
            // 
            this.btnZapamtiGrupu.Location = new System.Drawing.Point(126, 432);
            this.btnZapamtiGrupu.Name = "btnZapamtiGrupu";
            this.btnZapamtiGrupu.Size = new System.Drawing.Size(294, 58);
            this.btnZapamtiGrupu.TabIndex = 30;
            this.btnZapamtiGrupu.Text = "Zapamti novu grupu";
            this.btnZapamtiGrupu.UseVisualStyleBackColor = true;
            this.btnZapamtiGrupu.Click += new System.EventHandler(this.btnZapamtiGrupu_Click);
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(190, 106);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(254, 22);
            this.txtNazivGrupe.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Naziv grupe:";
            // 
            // txtTermin
            // 
            this.txtTermin.Location = new System.Drawing.Point(190, 159);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(254, 22);
            this.txtTermin.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Termin:";
            // 
            // UnosGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 678);
            this.Controls.Add(this.txtTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPolaznik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnZapamtiGrupu);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UnosGrupe";
            this.Text = "DodajGrupu";
            this.Load += new System.EventHandler(this.UnosGrupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPolaznik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZapamtiGrupu;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTermin;
        private System.Windows.Forms.Label label1;
    }
}