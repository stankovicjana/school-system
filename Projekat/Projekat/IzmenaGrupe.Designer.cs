namespace Projekat
{
    partial class IzmenaGrupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmenaGrupe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzmeniGrupu = new System.Windows.Forms.Button();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTermin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(464, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 215);
            this.dataGridView1.TabIndex = 47;
            // 
            // btnIzmeniGrupu
            // 
            this.btnIzmeniGrupu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnIzmeniGrupu.BackColor = System.Drawing.Color.RosyBrown;
            this.btnIzmeniGrupu.Location = new System.Drawing.Point(60, 203);
            this.btnIzmeniGrupu.Name = "btnIzmeniGrupu";
            this.btnIzmeniGrupu.Size = new System.Drawing.Size(294, 58);
            this.btnIzmeniGrupu.TabIndex = 48;
            this.btnIzmeniGrupu.Text = "Izmeni grupu";
            this.btnIzmeniGrupu.UseVisualStyleBackColor = false;
            this.btnIzmeniGrupu.Click += new System.EventHandler(this.btnIzmeniGrupu_Click);
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(125, 29);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(254, 22);
            this.txtNazivGrupe.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Naziv grupe:";
            // 
            // txtTermin
            // 
            this.txtTermin.Location = new System.Drawing.Point(125, 83);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(254, 22);
            this.txtTermin.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Termin:";
            // 
            // cmbKurs
            // 
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Location = new System.Drawing.Point(125, 134);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(252, 24);
            this.cmbKurs.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Kurs:";
            // 
            // IzmenaGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1213, 383);
            this.Controls.Add(this.txtTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzmeniGrupu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IzmenaGrupe";
            this.Text = "IzmenaGrupe";
            this.Load += new System.EventHandler(this.IzmenaGrupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzmeniGrupu;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTermin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKurs;
        private System.Windows.Forms.Label label2;
    }
}