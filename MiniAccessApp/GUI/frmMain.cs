using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniAccessApp.Business;
using MiniAccessApp.GUI;

namespace MiniAccessApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void quitMainFrmItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit this increadable program?",
                    "Closing the application", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome newForm = new frmWelcome();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void openDBItem_Click(object sender, EventArgs e)
        {
            String path = "";
            openFileDial1.Filter = "Access files mdb|*.mbd|Access file accdb|*.accdb|All files|*.*";
            openFileDial1.DefaultExt = "*.mdb";
            openFileDial1.FileName = "*.mdb";
            openFileDial1.ShowDialog();
            path = openFileDial1.FileName;
            Variables.OpenFilePath = path;

            frmOpenDB newForm = new frmOpenDB();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void newDBItem_Click(object sender, EventArgs e)
        {
            String path = "";
            saveFileDial1.Filter = "Access files mdb|*.mdb";
            saveFileDial1.Title = "Select a database file";
            saveFileDial1.InitialDirectory = @"C:\";
            saveFileDial1.ShowDialog();
            path = saveFileDial1.FileName;
            Variables.NewFilePath = path;

            frmNewDB newForm = new frmNewDB();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}
