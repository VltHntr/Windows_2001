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
using Windows_2001_MainOS.Programs.TextEditor;
using Microsoft.VisualBasic;

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
            bool getEditorValue = string.IsNullOrEmpty(txtContent.Text);

            if (!getEditorValue)
            {
                MessageBox.Show("Der Inhalt geht verloren!");
                txtContent.Text = "";
            }
        }

        private void überEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutEditor aboutEditor = new frmAboutEditor();
            aboutEditor.ShowDialog();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Interaction.InputBox("Name der Datei", "Editor - Speichern");
                string txtName = $"{fileName}.txt";
                string txtPath = $"{Properties.Settings.Default.OS_path}\\Editor\\{txtName}";

                StreamWriter str = new StreamWriter(txtPath);
                str.WriteLine(txtContent.Text);
                str.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                MessageBox.Show("Saved");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = $"{Properties.Settings.Default.OS_path}\\Editor";

            openFileDialog1.ShowDialog(this);
            string openPath = openFileDialog1.FileName;

            StreamReader reader = new StreamReader(openPath);
            string text = reader.ReadToEnd();

            txtContent.Text = text;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string EditorContent
        {
            get { return txtContent.Text; }
            set { txtContent.Text = value; }
        }
    }
}
