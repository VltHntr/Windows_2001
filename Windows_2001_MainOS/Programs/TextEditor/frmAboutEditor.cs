using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_2001_MainOS.Programs.TextEditor;

namespace Windows_2001_MainOS.Programs.TextEditor
{
    public partial class frmAboutEditor : Form
    {
        public frmAboutEditor()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            EditorConfig editorConfig = new EditorConfig();
            string version = editorConfig.EditorVersion();

            lblVersion.Text = version;
        }
    }
}
