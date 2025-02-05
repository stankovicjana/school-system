namespace Projekat
{
    partial class DodajGrupu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajGrupu));
            this.txtTermin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZapamtiGrupu = new System.Windows.Forms.Button();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnPrikaziGrupu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTermin
            // 
            this.txtTermin.Location = new System.Drawing.Point(124, 86);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(254, 22);
            this.txtTermin.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Termin:";
            // 
            // cmbKurs
            // 
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Location = new System.Drawing.Point(124, 137);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(252, 24);
            this.cmbKurs.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kurs:";
            // 
            // btnZapamtiGrupu
            // 
            this.btnZapamtiGrupu.BackColor = System.Drawing.Color.OldLace;
            this.btnZapamtiGrupu.Location = new System.Drawing.Point(62, 190);
            this.btnZapamtiGrupu.Name = "btnZapamtiGrupu";
            this.btnZapamtiGrupu.Size = new System.Drawing.Size(294, 58);
            this.btnZapamtiGrupu.TabIndex = 41;
            this.btnZapamtiGrupu.Text = "Zapamti novu grupu";
            this.btnZapamtiGrupu.UseVisualStyleBackColor = false;
            this.btnZapamtiGrupu.Click += new System.EventHandler(this.btnZapamtiGrupu_Click);
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(124, 33);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(254, 22);
            this.txtNazivGrupe.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Naziv grupe:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 215);
            this.dataGridView1.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtPretrazi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(20, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 359);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o grupama";
            this.groupBox1.Visible = false;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(379, 21);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(248, 22);
            this.txtPretrazi.TabIndex = 9;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pronađite grupu po nazivu :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1044, 273);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnPrikaziGrupu
            // 
            this.btnPrikaziGrupu.BackColor = System.Drawing.Color.OldLace;
            this.btnPrikaziGrupu.Location = new System.Drawing.Point(827, 669);
            this.btnPrikaziGrupu.Name = "btnPrikaziGrupu";
            this.btnPrikaziGrupu.Size = new System.Drawing.Size(263, 51);
            this.btnPrikaziGrupu.TabIndex = 10;
            this.btnPrikaziGrupu.Text = "Prikaži grupu";
            this.btnPrikaziGrupu.UseVisualStyleBackColor = false;
            this.btnPrikaziGrupu.Click += new System.EventHandler(this.btnPrikaziGrupu_Click);
            // 
            // DodajGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 286);
            this.Controls.Add(this.btnPrikaziGrupu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZapamtiGrupu);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label3);
            this.Name = "DodajGrupu";
            this.Text = "DodajGrupu";
            this.Load += new System.EventHandler(this.DodajGrupu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikaziGrupu;
    }
}