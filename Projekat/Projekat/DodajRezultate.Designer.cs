namespace Projekat
{
    partial class DodajRezultate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajRezultate));
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZapamti = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupe = new System.Windows.Forms.ComboBox();
            this.btnGrupa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(267, 15);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(229, 22);
            this.txtPretrazi.TabIndex = 15;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pronađite test po polazniku";
            // 
            // btnZapamti
            // 
            this.btnZapamti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnZapamti.Location = new System.Drawing.Point(747, 393);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Size = new System.Drawing.Size(222, 44);
            this.btnZapamti.TabIndex = 13;
            this.btnZapamti.Text = "Zapamti rezultate testa";
            this.btnZapamti.UseVisualStyleBackColor = false;
            this.btnZapamti.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 188);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtPretrazi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 336);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Izaberite grupu za unos testova";
            // 
            // cmbGrupe
            // 
            this.cmbGrupe.FormattingEnabled = true;
            this.cmbGrupe.Location = new System.Drawing.Point(363, 37);
            this.cmbGrupe.Name = "cmbGrupe";
            this.cmbGrupe.Size = new System.Drawing.Size(260, 24);
            this.cmbGrupe.TabIndex = 20;
            // 
            // btnGrupa
            // 
            this.btnGrupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGrupa.Location = new System.Drawing.Point(672, 27);
            this.btnGrupa.Name = "btnGrupa";
            this.btnGrupa.Size = new System.Drawing.Size(267, 43);
            this.btnGrupa.TabIndex = 21;
            this.btnGrupa.Text = "Pronađi";
            this.btnGrupa.UseVisualStyleBackColor = false;
            this.btnGrupa.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajRezultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1086, 475);
            this.Controls.Add(this.btnGrupa);
            this.Controls.Add(this.cmbGrupe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZapamti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajRezultate";
            this.Text = "DodajRezultate";
            this.Load += new System.EventHandler(this.DodajRezultate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZapamti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupe;
        private System.Windows.Forms.Button btnGrupa;
    }
}