namespace Windows_2001_MainOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemEinstellungen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.herunterfahrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProgramme = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 535);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProgramme,
            this.toolStripMenuItemEinstellungen,
            this.toolStripSeparator1,
            this.herunterfahrenToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButton1.Text = "Start";
            // 
            // toolStripMenuItemEinstellungen
            // 
            this.toolStripMenuItemEinstellungen.Name = "toolStripMenuItemEinstellungen";
            this.toolStripMenuItemEinstellungen.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEinstellungen.Text = "Einstellungen";
            this.toolStripMenuItemEinstellungen.Click += new System.EventHandler(this.toolStripMenuItemEinstellungen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // herunterfahrenToolStripMenuItem
            // 
            this.herunterfahrenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abmeldenToolStripMenuItem});
            this.herunterfahrenToolStripMenuItem.Name = "herunterfahrenToolStripMenuItem";
            this.herunterfahrenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.herunterfahrenToolStripMenuItem.Text = "Herunterfahren...";
            this.herunterfahrenToolStripMenuItem.Click += new System.EventHandler(this.herunterfahrenToolStripMenuItem_Click);
            // 
            // abmeldenToolStripMenuItem
            // 
            this.abmeldenToolStripMenuItem.Name = "abmeldenToolStripMenuItem";
            this.abmeldenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abmeldenToolStripMenuItem.Text = "Abmelden";
            this.abmeldenToolStripMenuItem.Click += new System.EventHandler(this.abmeldenToolStripMenuItem_Click);
            // 
            // toolStripMenuItemProgramme
            // 
            this.toolStripMenuItemProgramme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem});
            this.toolStripMenuItemProgramme.Name = "toolStripMenuItemProgramme";
            this.toolStripMenuItemProgramme.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemProgramme.Text = "Programme";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 560);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem herunterfahrenToolStripMenuItem;
        private ToolStripMenuItem abmeldenToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemEinstellungen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemProgramme;
        private ToolStripMenuItem editorToolStripMenuItem;
    }
}