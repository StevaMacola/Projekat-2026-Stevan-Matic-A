namespace Projekat_2026_Stevan_Matic_A
{
    partial class Glavna
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
            this.dokumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napraviTermineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentiToolStripMenuItem,
            this.izvestajToolStripMenuItem,
            this.podaciToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dokumentiToolStripMenuItem
            // 
            this.dokumentiToolStripMenuItem.Name = "dokumentiToolStripMenuItem";
            this.dokumentiToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.dokumentiToolStripMenuItem.Text = "Dokumenti";
            // 
            // izvestajToolStripMenuItem
            // 
            this.izvestajToolStripMenuItem.Name = "izvestajToolStripMenuItem";
            this.izvestajToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.izvestajToolStripMenuItem.Text = "Podaci";
            // 
            // podaciToolStripMenuItem
            // 
            this.podaciToolStripMenuItem.Name = "podaciToolStripMenuItem";
            this.podaciToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.podaciToolStripMenuItem.Text = "Izvestaj";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.napraviTermineToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // napraviTermineToolStripMenuItem
            // 
            this.napraviTermineToolStripMenuItem.Name = "napraviTermineToolStripMenuItem";
            this.napraviTermineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.napraviTermineToolStripMenuItem.Text = "napravi termine";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Projekat_2026_Stevan_Matic_A.Properties.Resources._360_F_882005624_0qntE6qpXTzPgiUuBYnKcYIQOQPRUW6S;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 485);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dokumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napraviTermineToolStripMenuItem;
    }
}