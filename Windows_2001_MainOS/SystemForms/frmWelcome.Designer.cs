namespace Windows_2001_MainOS.Forms
{
    partial class frmWelcome
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Willkommen zu...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 65);
            this.label5.TabIndex = 1;
            this.label5.Text = "Windows 2001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Preview";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(45, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 111);
            this.label7.TabIndex = 3;
            this.label7.Text = "Das komplett neue Windows!\r\n\r\nNeu geschrieben mit High-Level Languge C# im .NET F" +
    "ramework.\r\n\r\n##Dies ist eine Preview und enthält möglicherweiße Schwerwiegende f" +
    "ehler!##";
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Checked = true;
            this.cbShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShow.Location = new System.Drawing.Point(442, 287);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(121, 19);
            this.cbShow.TabIndex = 4;
            this.cbShow.Text = "Beim start zeigen?";
            this.cbShow.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(569, 283);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Schließen";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 318);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Willkommen zu Windows 2001";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox cbShow;
        private Button cmdClose;
    }
}