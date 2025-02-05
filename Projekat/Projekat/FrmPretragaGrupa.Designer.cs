namespace Projekat
{
    partial class FrmPretragaGrupa
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
            this.btnPronadjiGrupu = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrikaziGrupu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPronadjiGrupu
            // 
            this.btnPronadjiGrupu.Location = new System.Drawing.Point(367, 31);
            this.btnPronadjiGrupu.Name = "btnPronadjiGrupu";
            this.btnPronadjiGrupu.Size = new System.Drawing.Size(212, 51);
            this.btnPronadjiGrupu.TabIndex = 8;
            this.btnPronadjiGrupu.Text = "Pronađi grupu";
            this.btnPronadjiGrupu.UseVisualStyleBackColor = true;
            this.btnPronadjiGrupu.Click += new System.EventHandler(this.btnPronadjiGrupu_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(81, 50);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(248, 22);
            this.txtNaziv.TabIndex = 7;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pronađite grupu po nazivu :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(81, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 305);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o grupama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPrikaziGrupu
            // 
            this.btnPrikaziGrupu.Location = new System.Drawing.Point(66, 437);
            this.btnPrikaziGrupu.Name = "btnPrikaziGrupu";
            this.btnPrikaziGrupu.Size = new System.Drawing.Size(263, 51);
            this.btnPrikaziGrupu.TabIndex = 9;
            this.btnPrikaziGrupu.Text = "Prikaži grupu";
            this.btnPrikaziGrupu.UseVisualStyleBackColor = true;
            this.btnPrikaziGrupu.Click += new System.EventHandler(this.btnPrikaziGrupu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmPretragaGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPronadjiGrupu);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikaziGrupu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPretragaGrupa";
            this.Text = "FrmPretragaGrupa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPronadjiGrupu;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrikaziGrupu;
        private System.Windows.Forms.Button button1;
    }
}