using System;
using System.IO;
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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void cmdExecute_Click(object sender, EventArgs e)
        {
            Directory.Delete(Properties.Settings.Default.OS_path, true);

            Properties.Settings.Default.OS_path = "C:\\Temp";
            Properties.Settings.Default.pathExist = false;
            Properties.Settings.Default.Save();

            frmNachRücksetzen nachRücksetzen = new frmNachRücksetzen();
            nachRücksetzen.ShowDialog();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 2)
            {
                cmdExecute.Enabled = true;
            }
        }
    }
}
