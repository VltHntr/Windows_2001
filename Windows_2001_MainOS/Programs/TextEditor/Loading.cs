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

namespace Windows_2001_MainOS.Programs.TextEditor
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private Editor editor = null;
        public Loading(Form callingForm)
        {
            editor = callingForm as Editor;
            InitializeComponent();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader($"{Properties.Settings.Default.OS_path}\\Editor\\{txtFileName.Text}");
            string line = reader.ReadLine();

            while ( line != null )
            {
                this.editor.EditorContent= line;
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo($"{Properties.Settings.Default.OS_path}\\Editor");

            FileInfo[] files= d.GetFiles("*.txt");
            //string str = "";

            foreach ( FileInfo file in files )
            {
                //str = str + file.Name;
                lstFiles.Items.Add(file.Name);
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = lstFiles.SelectedItem.ToString();
            txtFileName.Text = selected;
        }

        private void Loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
