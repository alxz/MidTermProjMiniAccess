using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniAccessApp.GUI;

namespace MiniAccessApp
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit this increadable program?",
            "Closing the application", MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            // Initial setup:
            radNew.Checked = true; //by default new DB selected
        }

        private void radNew_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxOpen.Enabled = false;
            grpBoxNewDB.Enabled = true;
        }

        private void grpBoxWelcome_Enter(object sender, EventArgs e)
        {
        }

        private void radOpen_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxNewDB.Enabled = false;
            grpBoxOpen.Enabled = true;
            
        }

        private void btnOpenBrowse_Click(object sender, EventArgs e)
        {
            String path = "";
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Access files mdb|*.mbd|Access file accdb|*.accdb|All files|*.*";
            openDlg.DefaultExt = "*.mdb";
            openDlg.FileName = "*.mdb";

            // To fix open file already in use isssu:
            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/56fbbf9b-31d5-4e89-be85-83d9cb1d538c/openfiledialog-this-file-is-in-use?forum=netfxbcl
            //This helps
            openDlg.ValidateNames = false;
            DialogResult result = openDlg.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                
                try
                {
                    path = openDlg.FileName;
                    txtOpenFile.Text = path;
                    Variables.OpenFilePath = path;
                    openDlg = null;
                }
                catch (System.IO.IOException)
                {
                    openDlg = null;
                    Variables.OpenFilePath = "";
                }
                ////openFileDial1.Filter = "Access files mdb|*.mbd|Access file accdb|*.accdb|All files|*.*";
                ////openFileDial1.DefaultExt = "*.mdb";
                ////openFileDial1.FileName = "*.mdb";

                ////DialogResult result = openFileDial1.ShowDialog(); // Show the dialog.
                ////if (result == DialogResult.OK) // Test result.
                ////{
                ////    string file = openFileDial1.FileName;
                ////    try
                ////    {
                ////        path = openFileDial1.FileName;
                ////        txtOpenFile.Text = path;
                ////        Variables.OpenFilePath = path;
                ////    }
                ////    catch (System.IO.IOException)
                ////    {
                ////        openFileDial1 = null;
                ////        Variables.OpenFilePath = "";
                ////    }
                //openFileDial1.ShowDialog();
            }
            
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            //Button to Create New MDB ...
            if (txtNewDBFile.Text.Trim() == "")
            {
                MessageBox.Show("Please provide valid path to the file!", "File Creation",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewDBFile.Focus();
                return;
            }
            Variables.NewFilePath = txtNewDBFile.Text.Trim();
            if (File.Exists(Variables.NewFilePath))
            {
                MessageBox.Show("File already existing! \n Sorry, we can not overwrite this file, please choose another name!", "File Creation Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewDBFile.Focus();
                return;
            }
            else
            {
                frmNewDB newForm = new frmNewDB();
                newForm.Show(frmMain.ActiveForm);
            }
        }

        private void btnBrowseNewFile_Click(object sender, EventArgs e)
        {
            try
            {
                String path = "";

                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.Filter = "Access files mdb|*.mdb";
                SaveFileDialog1.Title = "Select a database file";
                SaveFileDialog1.InitialDirectory = @"C:\";
                //SaveFileDialog1.ShowDialog();

                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        path = SaveFileDialog1.FileName;
                        txtNewDBFile.Text = path;
                        Variables.NewFilePath = path;
                        SaveFileDialog1.Dispose();
                        SaveFileDialog1 = null;
                    }
                    catch (System.IO.IOException exp)
                    {
                        SaveFileDialog1 = null;
                    }
                    finally
                    {
                        if (SaveFileDialog1 != null)
                        {
                            SaveFileDialog1 = null;
                        }
                    }

                }


                //saveFileDial1.Filter = "Access files mdb|*.mdb";
                //saveFileDial1.Title = "Select a database file";
                //saveFileDial1.InitialDirectory = @"C:\";
                //saveFileDial1.ShowDialog();
                //path = saveFileDial1.FileName;
                //txtNewDBFile.Text = path;
                //Variables.NewFilePath = path;
                //saveFileDial1.Dispose();
                //saveFileDial1 = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error raised! \n" + ex, "Error SaveFile Dialog", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Variables.NewFilePath = "";
                Variables.OpenFilePath = "";
                saveFileDial1 = null;
                return;
            }
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            if (txtOpenFile.Text.Trim() == "")
            {
                MessageBox.Show("Please provide valid path to the file!", "Open Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOpenFile.Focus();
                return;
            }
            string path = txtOpenFile.Text.Trim();
            if (File.Exists(path))
            {
                Variables.OpenFilePath = path;
                frmOpenDB newForm = new frmOpenDB();
                newForm.ShowDialog(frmMain.ActiveForm);
            }
            else
            {
                Variables.OpenFilePath = "";
                MessageBox.Show("Please provide valid path to the file!", "Open Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOpenFile.Focus();
                return;
            }
            
        }
    }
}
