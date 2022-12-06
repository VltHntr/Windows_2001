using Windows_2001_MainOS.Forms;

namespace Windows_2001_MainOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void herunterfahrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmWelcome newWelcome = new frmWelcome();
            newWelcome.MdiParent = this;

            newWelcome.Show();
        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItemEinstellungen_Click(object sender, EventArgs e)
        {
            SystemForms.frmSettings frmSettings = new SystemForms.frmSettings();
            frmSettings.MdiParent = this;
            frmSettings.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Programs.Editor editor = new Programs.Editor();
            editor.MdiParent = this;
            editor.Show();
        }
    }
}