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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stvoriDatotekeToolStripMenuItem,
            this.kriptirajAsimetričnoToolStripMenuItem,
            this.dekriptiranjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stvoriDatotekeToolStripMenuItem
            // 
            this.stvoriDatotekeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.ključevaToolStripMenuItem});
            this.stvoriDatotekeToolStripMenuItem.Name = "stvoriDatotekeToolStripMenuItem";
            this.stvoriDatotekeToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.stvoriDatotekeToolStripMenuItem.Text = "Stvaranje";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            this.datotekaToolStripMenuItem.Click += new System.EventHandler(this.DatotekaToolStripMenuItem_Click);
            // 
            // ključevaToolStripMenuItem
            // 
            this.ključevaToolStripMenuItem.Name = "ključevaToolStripMenuItem";
            this.ključevaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ključevaToolStripMenuItem.Text = "Ključeva";
            this.ključevaToolStripMenuItem.Click += new System.EventHandler(this.KljučevaToolStripMenuItem_Click);
            // 
            // kriptirajAsimetričnoToolStripMenuItem
            // 
            this.kriptirajAsimetričnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simetričnoToolStripMenuItem,
            this.asimetričnoToolStripMenuItem});
            this.kriptirajAsimetričnoToolStripMenuItem.Name = "kriptirajAsimetričnoToolStripMenuItem";
            this.kriptirajAsimetričnoToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.kriptirajAsimetričnoToolStripMenuItem.Text = "Kriptiranje";
            // 
            // simetričnoToolStripMenuItem
            // 
            this.simetričnoToolStripMenuItem.Name = "simetričnoToolStripMenuItem";
            this.simetričnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simetričnoToolStripMenuItem.Text = "Simetrično";
            // 
            // asimetričnoToolStripMenuItem
            // 
            this.asimetričnoToolStripMenuItem.Name = "asimetričnoToolStripMenuItem";
            this.asimetričnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asimetričnoToolStripMenuItem.Text = "Asimetrično";
            // 
            // dekriptiranjeToolStripMenuItem
            // 
            this.dekriptiranjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simetričnoToolStripMenuItem1,
            this.asimetričnoToolStripMenuItem1});
            this.dekriptiranjeToolStripMenuItem.Name = "dekriptiranjeToolStripMenuItem";
            this.dekriptiranjeToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.dekriptiranjeToolStripMenuItem.Text = "Dekriptiranje";
            // 
            // simetričnoToolStripMenuItem1
            // 
            this.simetričnoToolStripMenuItem1.Name = "simetričnoToolStripMenuItem1";
            this.simetričnoToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.simetričnoToolStripMenuItem1.Text = "Simetrično";
            // 
            // asimetričnoToolStripMenuItem1
            // 
            this.asimetričnoToolStripMenuItem1.Name = "asimetričnoToolStripMenuItem1";
            this.asimetričnoToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.asimetričnoToolStripMenuItem1.Text = "Asimetrično";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InitialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialForm";
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
    }
}