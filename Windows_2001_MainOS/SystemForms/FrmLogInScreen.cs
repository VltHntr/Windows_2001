using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_2001_MainOS.SystemForms
{
    public partial class FrmLogInScreen : Form
    {
        public FrmLogInScreen()
        {
            InitializeComponent();
        }

        private void cmdShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "root" && txtPassword.Text == "root")
            {
                this.Close();
            }
        }
    }
}
