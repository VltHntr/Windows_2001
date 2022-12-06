namespace Windows_2001_MainOS.SystemForms.Settings.config
{
    partial class frmPATH_CONFIG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmdSavePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdSelectPath = new System.Windows.Forms.Button();
            this.chboxAlsTest = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Configuration";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(214, 119);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gebe hier den Ort an wo alle Daten und Datein für Windows 2001 gespeichert werden" +
    " sollen.\r\nWenn das System nur zu Test Zwecken genutzt wird, dann bitte die Check" +
    "Box \"Als Test Konfiguriren\" anwählen.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 223);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(184, 23);
            this.txtPath.TabIndex = 3;
            // 
            // cmdSavePath
            // 
            this.cmdSavePath.Location = new System.Drawing.Point(151, 305);
            this.cmdSavePath.Name = "cmdSavePath";
            this.cmdSavePath.Size = new System.Drawing.Size(75, 23);
            this.cmdSavePath.TabIndex = 4;
            this.cmdSavePath.Text = "Speichern";
            this.cmdSavePath.UseVisualStyleBackColor = true;
            this.cmdSavePath.Click += new System.EventHandler(this.cmdSavePath_Click);
            // 
            // cmdSelectPath
            // 
            this.cmdSelectPath.Location = new System.Drawing.Point(202, 223);
            this.cmdSelectPath.Name = "cmdSelectPath";
            this.cmdSelectPath.Size = new System.Drawing.Size(24, 23);
            this.cmdSelectPath.TabIndex = 5;
            this.cmdSelectPath.Text = "...";
            this.cmdSelectPath.UseVisualStyleBackColor = true;
            this.cmdSelectPath.Click += new System.EventHandler(this.cmdSelectPath_Click);
            // 
            // chboxAlsTest
            // 
            this.chboxAlsTest.AutoSize = true;
            this.chboxAlsTest.Checked = true;
            this.chboxAlsTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxAlsTest.Location = new System.Drawing.Point(92, 264);
            this.chboxAlsTest.Name = "chboxAlsTest";
            this.chboxAlsTest.Size = new System.Drawing.Size(134, 19);
            this.chboxAlsTest.TabIndex = 6;
            this.chboxAlsTest.Text = "Als Test Konfiguriren";
            this.chboxAlsTest.UseVisualStyleBackColor = true;
            this.chboxAlsTest.CheckedChanged += new System.EventHandler(this.chboxAlsTest_CheckedChanged);
            // 
            // frmPATH_CONFIG
            // 
            this.AcceptButton = this.cmdSavePath;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 340);
            this.Controls.Add(this.chboxAlsTest);
            this.Controls.Add(this.cmdSelectPath);
            this.Controls.Add(this.cmdSavePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPATH_CONFIG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 2001 Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPATH_CONFIG_FormClosing);
            this.Load += new System.EventHandler(this.frmPATH_CONFIG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPath;
        private Button cmdSavePath;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button cmdSelectPath;
        private CheckBox chboxAlsTest;
    }
}