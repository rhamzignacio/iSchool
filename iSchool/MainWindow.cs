using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSchool
{
    public partial class MainWindow : Form
    {
        License license = new License();

        public MainWindow()
        {
            InitializeComponent();

            lblNameOfSchool.Text = license.NameOfSchool;

            lblAddress.Text = license.AddressofSchool;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //About
        {
            panelMain.Controls.Clear();

            AboutPage aboutPage = new AboutPage();

            aboutPage.TopLevel = false;

            aboutPage.Visible = true;

            aboutPage.Dock = DockStyle.Fill;

            panelMain.Controls.Add(aboutPage);
        }
    }
}
