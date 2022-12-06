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
    public partial class frmPATH_CONFIG : Form
    {
        public frmPATH_CONFIG()
        {
            InitializeComponent();
        }

        private void frmPATH_CONFIG_Load(object sender, EventArgs e)
        {
            checkIfTest();
        }

        private void chboxAlsTest_CheckedChanged(object sender, EventArgs e)
        {
            checkIfTest();
        }

        private void checkIfTest()
        {
            if (chboxAlsTest.Checked)
            {
                txtPath.Enabled = false;
                cmdSelectPath.Enabled = false;
            }

            else
            {
                txtPath.Enabled = true;
                cmdSelectPath.Enabled = true;
            }
        }

        private void cmdSelectPath_Click(object sender, EventArgs e)
        {
            string pathFileDialog;
            
            folderBrowserDialog1.ShowDialog(this);
            pathFileDialog = folderBrowserDialog1.SelectedPath;

            txtPath.Text = pathFileDialog;
        }

        private void frmPATH_CONFIG_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Die eintellungen werden nicht gespeichert!");
            
            if (String.IsNullOrEmpty(txtPath.Text) && chboxAlsTest.Checked == false)
            {
                MessageBox.Show("Keinen PATH angegeben!\nPATH wird auf 'C:/Temp' angelegt.");
            }

            else
            {
                MessageBox.Show("PATH wird auf 'C:/Temp' angelegt.");
            }
        }

        private void cmdSavePath_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPath.Text) && chboxAlsTest.Checked == false)
            {
                MessageBox.Show("Bitte einen PATH auswählen!\nWenn kein PATH angegeben werden soll bitte die CheckBox auswählen.");
            }
        }
    }
}
