using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_2001_MainOS.SystemForms.Settings.config
{
    public partial class frmNachRücksetzen : Form
    {
        public frmNachRücksetzen()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Neustarten")
            {
                Application.Restart();
            }

            else if (comboBox1.Text == "Herunterfahren")
            {
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Auswahl Treffen!!!");
            }
        }
    }
}
