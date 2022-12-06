using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_2001_MainOS.Programs
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckEditor();
        }

        private void CheckEditor()
        {
            bool getEditorValue = string.IsNullOrEmpty(richTextBox1.Text);

            if (!getEditorValue)
            {
                MessageBox.Show("Der Inhalt geht verloren!");
                richTextBox1.Text = "";
            }
        }
    }
}
