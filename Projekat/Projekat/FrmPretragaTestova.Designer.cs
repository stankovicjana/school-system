namespace Projekat
{
    partial class FrmPretragaTestova
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
            this.btnPrikaziTest = new System.Windows.Forms.Button();
            this.btnNadjiTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPronadjeniTestovi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPolaznik = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniTestovi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikaziTest
            // 
            this.btnPrikaziTest.Location = new System.Drawing.Point(125, 484);
            this.btnPrikaziTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrikaziTest.Name = "btnPrikaziTest";
            this.btnPrikaziTest.Size = new System.Drawing.Size(235, 59);
            this.btnPrikaziTest.TabIndex = 17;
            this.btnPrikaziTest.Text = "Prikaži test";
            this.btnPrikaziTest.UseVisualStyleBackColor = true;
            this.btnPrikaziTest.Click += new System.EventHandler(this.btnPrikaziTest_Click);
            // 
            // btnNadjiTest
            // 
            this.btnNadjiTest.Location = new System.Drawing.Point(633, 47);
            this.btnNadjiTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNadjiTest.Name = "btnNadjiTest";
            this.btnNadjiTest.Size = new System.Drawing.Size(195, 59);
            this.btnNadjiTest.TabIndex = 14;
            this.btnNadjiTest.Text = "Pronadji test";
            this.btnNadjiTest.UseVisualStyleBackColor = true;
            this.btnNadjiTest.Click += new System.EventHandler(this.btnNadjiTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPronadjeniTestovi);
            this.groupBox1.Location = new System.Drawing.Point(102, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(726, 316);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o pronađenim testovima";
            // 
            // dgvPronadjeniTestovi
            // 
            this.dgvPronadjeniTestovi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPronadjeniTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPronadjeniTestovi.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPronadjeniTestovi.Location = new System.Drawing.Point(11, 36);
            this.dgvPronadjeniTestovi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPronadjeniTestovi.Name = "dgvPronadjeniTestovi";
            this.dgvPronadjeniTestovi.RowHeadersWidth = 62;
            this.dgvPronadjeniTestovi.RowTemplate.Height = 24;
            this.dgvPronadjeniTestovi.Size = new System.Drawing.Size(680, 245);
            this.dgvPronadjeniTestovi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unesite polaznika za kog želite da vidite rezultate testa";
            // 
            // cmbPolaznik
            // 
            this.cmbPolaznik.FormattingEnabled = true;
            this.cmbPolaznik.Location = new System.Drawing.Point(113, 78);
            this.cmbPolaznik.Name = "cmbPolaznik";
            this.cmbPolaznik.Size = new System.Drawing.Size(232, 28);
            this.cmbPolaznik.TabIndex = 18;
            // 
            // FrmPretragaTestova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 590);
            this.Controls.Add(this.cmbPolaznik);
            this.Controls.Add(this.btnPrikaziTest);
            this.Controls.Add(this.btnNadjiTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPretragaTestova";
            this.Text = "FrmPretragaTestova";
            this.Load += new System.EventHandler(this.FrmPretragaTestova_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPronadjeniTestovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziTest;
        private System.Windows.Forms.Button btnNadjiTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPronadjeniTestovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPolaznik;
    }
}