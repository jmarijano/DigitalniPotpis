namespace DigitalniPotpisUI
{
    partial class InitialForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stvoriDatotekeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ključevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kriptirajAsimetričnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simetričnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asimetričnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dekriptiranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simetričnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asimetričnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalniPotpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potpišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provjeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jasniTekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kriptiraniTekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simetričnoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.asimetričnoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ključToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tajniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privatniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sažetakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalniPotpisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uiShowData = new System.Windows.Forms.RichTextBox();
            this.uiShowDataLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stvoriDatotekeToolStripMenuItem,
            this.kriptirajAsimetričnoToolStripMenuItem,
            this.dekriptiranjeToolStripMenuItem,
            this.digitalniPotpisToolStripMenuItem,
            this.prikažiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stvoriDatotekeToolStripMenuItem
            // 
            this.stvoriDatotekeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.ključevaToolStripMenuItem});
            this.stvoriDatotekeToolStripMenuItem.Name = "stvoriDatotekeToolStripMenuItem";
            this.stvoriDatotekeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.stvoriDatotekeToolStripMenuItem.Text = "Stvaranje";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            this.datotekaToolStripMenuItem.Click += new System.EventHandler(this.DatotekaToolStripMenuItem_Click);
            // 
            // ključevaToolStripMenuItem
            // 
            this.ključevaToolStripMenuItem.Name = "ključevaToolStripMenuItem";
            this.ključevaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ključevaToolStripMenuItem.Text = "Ključeva";
            this.ključevaToolStripMenuItem.Click += new System.EventHandler(this.KljučevaToolStripMenuItem_Click);
            // 
            // kriptirajAsimetričnoToolStripMenuItem
            // 
            this.kriptirajAsimetričnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simetričnoToolStripMenuItem,
            this.asimetričnoToolStripMenuItem});
            this.kriptirajAsimetričnoToolStripMenuItem.Name = "kriptirajAsimetričnoToolStripMenuItem";
            this.kriptirajAsimetričnoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.kriptirajAsimetričnoToolStripMenuItem.Text = "Kriptiranje";
            // 
            // simetričnoToolStripMenuItem
            // 
            this.simetričnoToolStripMenuItem.Name = "simetričnoToolStripMenuItem";
            this.simetričnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simetričnoToolStripMenuItem.Text = "Simetrično";
            this.simetričnoToolStripMenuItem.Click += new System.EventHandler(this.SimetričnoToolStripMenuItem_Click);
            // 
            // asimetričnoToolStripMenuItem
            // 
            this.asimetričnoToolStripMenuItem.Name = "asimetričnoToolStripMenuItem";
            this.asimetričnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asimetričnoToolStripMenuItem.Text = "Asimetrično";
            this.asimetričnoToolStripMenuItem.Click += new System.EventHandler(this.AsimetričnoToolStripMenuItem_Click);
            // 
            // dekriptiranjeToolStripMenuItem
            // 
            this.dekriptiranjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simetričnoToolStripMenuItem1,
            this.asimetričnoToolStripMenuItem1});
            this.dekriptiranjeToolStripMenuItem.Name = "dekriptiranjeToolStripMenuItem";
            this.dekriptiranjeToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.dekriptiranjeToolStripMenuItem.Text = "Dekriptiranje";
            this.dekriptiranjeToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // simetričnoToolStripMenuItem1
            // 
            this.simetričnoToolStripMenuItem1.Name = "simetričnoToolStripMenuItem1";
            this.simetričnoToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.simetričnoToolStripMenuItem1.Text = "Simetrično";
            this.simetričnoToolStripMenuItem1.Click += new System.EventHandler(this.SimetričnoToolStripMenuItem1_Click);
            // 
            // asimetričnoToolStripMenuItem1
            // 
            this.asimetričnoToolStripMenuItem1.Name = "asimetričnoToolStripMenuItem1";
            this.asimetričnoToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.asimetričnoToolStripMenuItem1.Text = "Asimetrično";
            this.asimetričnoToolStripMenuItem1.Click += new System.EventHandler(this.AsimetričnoToolStripMenuItem1_Click);
            // 
            // digitalniPotpisToolStripMenuItem
            // 
            this.digitalniPotpisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.potpišiToolStripMenuItem,
            this.provjeriToolStripMenuItem});
            this.digitalniPotpisToolStripMenuItem.Name = "digitalniPotpisToolStripMenuItem";
            this.digitalniPotpisToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.digitalniPotpisToolStripMenuItem.Text = "Digitalni potpis";
            // 
            // potpišiToolStripMenuItem
            // 
            this.potpišiToolStripMenuItem.Name = "potpišiToolStripMenuItem";
            this.potpišiToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.potpišiToolStripMenuItem.Text = "Potpiši";
            this.potpišiToolStripMenuItem.Click += new System.EventHandler(this.PotpišiToolStripMenuItem_Click);
            // 
            // provjeriToolStripMenuItem
            // 
            this.provjeriToolStripMenuItem.Name = "provjeriToolStripMenuItem";
            this.provjeriToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.provjeriToolStripMenuItem.Text = "Provjeri";
            this.provjeriToolStripMenuItem.Click += new System.EventHandler(this.ProvjeriToolStripMenuItem_Click);
            // 
            // prikažiToolStripMenuItem
            // 
            this.prikažiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jasniTekstToolStripMenuItem,
            this.kriptiraniTekstToolStripMenuItem,
            this.ključToolStripMenuItem,
            this.sažetakToolStripMenuItem,
            this.digitalniPotpisToolStripMenuItem1});
            this.prikažiToolStripMenuItem.Name = "prikažiToolStripMenuItem";
            this.prikažiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.prikažiToolStripMenuItem.Text = "Prikaži";
            // 
            // jasniTekstToolStripMenuItem
            // 
            this.jasniTekstToolStripMenuItem.Name = "jasniTekstToolStripMenuItem";
            this.jasniTekstToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.jasniTekstToolStripMenuItem.Text = "Jasni tekst";
            this.jasniTekstToolStripMenuItem.Click += new System.EventHandler(this.JasniTekstToolStripMenuItem_Click);
            // 
            // kriptiraniTekstToolStripMenuItem
            // 
            this.kriptiraniTekstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simetričnoToolStripMenuItem2,
            this.asimetričnoToolStripMenuItem2});
            this.kriptiraniTekstToolStripMenuItem.Name = "kriptiraniTekstToolStripMenuItem";
            this.kriptiraniTekstToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kriptiraniTekstToolStripMenuItem.Text = "Kriptirani tekst";
            // 
            // simetričnoToolStripMenuItem2
            // 
            this.simetričnoToolStripMenuItem2.Name = "simetričnoToolStripMenuItem2";
            this.simetričnoToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.simetričnoToolStripMenuItem2.Text = "Simetrično";
            this.simetričnoToolStripMenuItem2.Click += new System.EventHandler(this.SimetričnoToolStripMenuItem2_Click);
            // 
            // asimetričnoToolStripMenuItem2
            // 
            this.asimetričnoToolStripMenuItem2.Name = "asimetričnoToolStripMenuItem2";
            this.asimetričnoToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.asimetričnoToolStripMenuItem2.Text = "Asimetrično";
            this.asimetričnoToolStripMenuItem2.Click += new System.EventHandler(this.AsimetričnoToolStripMenuItem2_Click);
            // 
            // ključToolStripMenuItem
            // 
            this.ključToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tajniToolStripMenuItem,
            this.javniToolStripMenuItem,
            this.privatniToolStripMenuItem});
            this.ključToolStripMenuItem.Name = "ključToolStripMenuItem";
            this.ključToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ključToolStripMenuItem.Text = "Ključ";
            // 
            // tajniToolStripMenuItem
            // 
            this.tajniToolStripMenuItem.Name = "tajniToolStripMenuItem";
            this.tajniToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.tajniToolStripMenuItem.Text = "Tajni";
            this.tajniToolStripMenuItem.Click += new System.EventHandler(this.TajniToolStripMenuItem_Click);
            // 
            // javniToolStripMenuItem
            // 
            this.javniToolStripMenuItem.Name = "javniToolStripMenuItem";
            this.javniToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.javniToolStripMenuItem.Text = "Javni";
            this.javniToolStripMenuItem.Click += new System.EventHandler(this.JavniToolStripMenuItem_Click);
            // 
            // privatniToolStripMenuItem
            // 
            this.privatniToolStripMenuItem.Name = "privatniToolStripMenuItem";
            this.privatniToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.privatniToolStripMenuItem.Text = "Privatni";
            this.privatniToolStripMenuItem.Click += new System.EventHandler(this.PrivatniToolStripMenuItem_Click);
            // 
            // sažetakToolStripMenuItem
            // 
            this.sažetakToolStripMenuItem.Name = "sažetakToolStripMenuItem";
            this.sažetakToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sažetakToolStripMenuItem.Text = "Sažetak";
            this.sažetakToolStripMenuItem.Click += new System.EventHandler(this.SažetakToolStripMenuItem_Click);
            // 
            // digitalniPotpisToolStripMenuItem1
            // 
            this.digitalniPotpisToolStripMenuItem1.Name = "digitalniPotpisToolStripMenuItem1";
            this.digitalniPotpisToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.digitalniPotpisToolStripMenuItem1.Text = "Digitalni potpis";
            this.digitalniPotpisToolStripMenuItem1.Click += new System.EventHandler(this.DigitalniPotpisToolStripMenuItem1_Click);
            // 
            // uiShowData
            // 
            this.uiShowData.Location = new System.Drawing.Point(286, 74);
            this.uiShowData.Name = "uiShowData";
            this.uiShowData.ReadOnly = true;
            this.uiShowData.Size = new System.Drawing.Size(671, 499);
            this.uiShowData.TabIndex = 2;
            this.uiShowData.Text = "";
            // 
            // uiShowDataLabel
            // 
            this.uiShowDataLabel.AutoSize = true;
            this.uiShowDataLabel.Location = new System.Drawing.Point(190, 77);
            this.uiShowDataLabel.Name = "uiShowDataLabel";
            this.uiShowDataLabel.Size = new System.Drawing.Size(90, 13);
            this.uiShowDataLabel.TabIndex = 3;
            this.uiShowDataLabel.Text = "Sadržaj datoteke:";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(992, 615);
            this.Controls.Add(this.uiShowDataLabel);
            this.Controls.Add(this.uiShowData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InitialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialForm";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stvoriDatotekeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kriptirajAsimetričnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ključevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simetričnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asimetričnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dekriptiranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simetričnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asimetričnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem digitalniPotpisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potpišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provjeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jasniTekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kriptiraniTekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simetričnoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem asimetričnoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ključToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tajniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privatniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sažetakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalniPotpisToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox uiShowData;
        private System.Windows.Forms.Label uiShowDataLabel;
    }
}