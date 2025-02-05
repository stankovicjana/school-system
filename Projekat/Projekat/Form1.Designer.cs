namespace Projekat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKrajRada = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prikaziPolaznikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPolaznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaPolaznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziTestoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurseviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polazniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastavniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uspehNastavnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKrajRada
            // 
            this.btnKrajRada.BackColor = System.Drawing.Color.OldLace;
            this.btnKrajRada.Location = new System.Drawing.Point(40, 329);
            this.btnKrajRada.Margin = new System.Windows.Forms.Padding(4);
            this.btnKrajRada.Name = "btnKrajRada";
            this.btnKrajRada.Size = new System.Drawing.Size(222, 50);
            this.btnKrajRada.TabIndex = 5;
            this.btnKrajRada.Text = "Kraj rada";
            this.btnKrajRada.UseVisualStyleBackColor = false;
            this.btnKrajRada.Click += new System.EventHandler(this.btnKrajRada_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.ForeColor = System.Drawing.Color.Red;
            this.lblPoruka.Location = new System.Drawing.Point(510, 359);
            this.lblPoruka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(227, 20);
            this.lblPoruka.TabIndex = 4;
            this.lblPoruka.Text = "Nije povezan sa serverom";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziPolaznikeToolStripMenuItem,
            this.grupeToolStripMenuItem,
            this.testoviToolStripMenuItem,
            this.kurseviToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(750, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prikaziPolaznikeToolStripMenuItem
            // 
            this.prikaziPolaznikeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPolaznikaToolStripMenuItem,
            this.izmenaPolaznikaToolStripMenuItem});
            this.prikaziPolaznikeToolStripMenuItem.Name = "prikaziPolaznikeToolStripMenuItem";
            this.prikaziPolaznikeToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.prikaziPolaznikeToolStripMenuItem.Text = "Polaznici";
            this.prikaziPolaznikeToolStripMenuItem.Click += new System.EventHandler(this.prikaziPolaznikeToolStripMenuItem_Click);
            // 
            // dodajPolaznikaToolStripMenuItem
            // 
            this.dodajPolaznikaToolStripMenuItem.Name = "dodajPolaznikaToolStripMenuItem";
            this.dodajPolaznikaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.dodajPolaznikaToolStripMenuItem.Text = "Dodaj polaznika";
            this.dodajPolaznikaToolStripMenuItem.Click += new System.EventHandler(this.dodajPolaznikaToolStripMenuItem_Click_1);
            // 
            // izmenaPolaznikaToolStripMenuItem
            // 
            this.izmenaPolaznikaToolStripMenuItem.Name = "izmenaPolaznikaToolStripMenuItem";
            this.izmenaPolaznikaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.izmenaPolaznikaToolStripMenuItem.Text = "Izmena polaznika";
            this.izmenaPolaznikaToolStripMenuItem.Click += new System.EventHandler(this.izmenaPolaznikaToolStripMenuItem_Click);
            // 
            // grupeToolStripMenuItem
            // 
            this.grupeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajGrupuToolStripMenuItem,
            this.izmeniGrupuToolStripMenuItem});
            this.grupeToolStripMenuItem.Name = "grupeToolStripMenuItem";
            this.grupeToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.grupeToolStripMenuItem.Text = "Grupe";
            this.grupeToolStripMenuItem.Click += new System.EventHandler(this.grupeToolStripMenuItem_Click);
            // 
            // dodajGrupuToolStripMenuItem
            // 
            this.dodajGrupuToolStripMenuItem.Name = "dodajGrupuToolStripMenuItem";
            this.dodajGrupuToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.dodajGrupuToolStripMenuItem.Text = "Dodaj grupu";
            this.dodajGrupuToolStripMenuItem.Click += new System.EventHandler(this.dodajGrupuToolStripMenuItem_Click_1);
            // 
            // izmeniGrupuToolStripMenuItem
            // 
            this.izmeniGrupuToolStripMenuItem.Name = "izmeniGrupuToolStripMenuItem";
            this.izmeniGrupuToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.izmeniGrupuToolStripMenuItem.Text = "Izmeni grupu";
            this.izmeniGrupuToolStripMenuItem.Click += new System.EventHandler(this.izmeniGrupuToolStripMenuItem_Click);
            // 
            // testoviToolStripMenuItem
            // 
            this.testoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajTestToolStripMenuItem,
            this.prikaziTestoveToolStripMenuItem});
            this.testoviToolStripMenuItem.Name = "testoviToolStripMenuItem";
            this.testoviToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.testoviToolStripMenuItem.Text = "Testovi";
            // 
            // dodajTestToolStripMenuItem
            // 
            this.dodajTestToolStripMenuItem.Name = "dodajTestToolStripMenuItem";
            this.dodajTestToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.dodajTestToolStripMenuItem.Text = "Zakaži test";
            this.dodajTestToolStripMenuItem.Click += new System.EventHandler(this.dodajTestToolStripMenuItem_Click);
            // 
            // prikaziTestoveToolStripMenuItem
            // 
            this.prikaziTestoveToolStripMenuItem.Name = "prikaziTestoveToolStripMenuItem";
            this.prikaziTestoveToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.prikaziTestoveToolStripMenuItem.Text = "Unesi rezultate";
            this.prikaziTestoveToolStripMenuItem.Click += new System.EventHandler(this.prikaziTestoveToolStripMenuItem_Click);
            // 
            // kurseviToolStripMenuItem
            // 
            this.kurseviToolStripMenuItem.Name = "kurseviToolStripMenuItem";
            this.kurseviToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.kurseviToolStripMenuItem.Text = "Kursevi";
            this.kurseviToolStripMenuItem.Click += new System.EventHandler(this.kurseviToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polazniciToolStripMenuItem,
            this.nastavniciToolStripMenuItem,
            this.uspehNastavnikaToolStripMenuItem});
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // polazniciToolStripMenuItem
            // 
            this.polazniciToolStripMenuItem.Name = "polazniciToolStripMenuItem";
            this.polazniciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.polazniciToolStripMenuItem.Text = "Polaznici";
            this.polazniciToolStripMenuItem.Click += new System.EventHandler(this.polazniciToolStripMenuItem_Click);
            // 
            // nastavniciToolStripMenuItem
            // 
            this.nastavniciToolStripMenuItem.Name = "nastavniciToolStripMenuItem";
            this.nastavniciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nastavniciToolStripMenuItem.Text = "Nastavnici";
            this.nastavniciToolStripMenuItem.Click += new System.EventHandler(this.nastavniciToolStripMenuItem_Click);
            // 
            // uspehNastavnikaToolStripMenuItem
            // 
            this.uspehNastavnikaToolStripMenuItem.Name = "uspehNastavnikaToolStripMenuItem";
            this.uspehNastavnikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uspehNastavnikaToolStripMenuItem.Text = "Uspeh nastavnika";
            this.uspehNastavnikaToolStripMenuItem.Click += new System.EventHandler(this.uspehNastavnikaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 406);
            this.Controls.Add(this.btnKrajRada);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Meni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKrajRada;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prikaziPolaznikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziTestoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurseviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polazniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastavniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPolaznikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaPolaznikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uspehNastavnikaToolStripMenuItem;
    }
}