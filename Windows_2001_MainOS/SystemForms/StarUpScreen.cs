using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_2001_MainOS.SystemForms.Settings.config;

namespace Windows_2001_MainOS.SystemForms
{
    public partial class StarUpScreen : Form
    {
        public StarUpScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;

                if (Properties.Settings.Default.pathExist == false)
                {
                    MessageBox.Show("No PATH!");
                    frmPATH_CONFIG pATH_CONFIG = new frmPATH_CONFIG();
                    pATH_CONFIG.ShowDialog();
                }

                this.Hide();

                Form1 main = new Form1();
                main.ShowDialog();
            }
        }
    }
}
