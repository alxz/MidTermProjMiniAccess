using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniAccessApp.GUI;
using MiniAccessApp.Validation;
using MiniAccessApp.Business;

using DAO; //we need it to use ms access

namespace MiniAccessApp
{
    public partial class frmNewDB : Form
    {
        public frmNewDB()
        {
            InitializeComponent();
        }
        //string newMDBPath = Variables.NewFilePath;
        DBEngine dbE;
        Database myDB; //---- create database object
        //TableDef myTb; //-----table object

        private void frmNewDB_Load(object sender, EventArgs e)
        {
            this.Text = "New DataBase: " + Variables.NewFilePath;
            //First things first - lets create a new file!
            dbE = new DBEngine();
            try //------------------------------ create database object as myDB: 
            {
                myDB = dbE.CreateDatabase(Variables.NewFilePath, DAO.LanguageConstants.dbLangGeneral);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error Creating new Database!!! \n" +
                //    "File path: " + newMDBPath  +"\n" + ex, 
                //                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorMsgDB(ex.ToString());
                this.Close();
            }
            //creating columnd for a grid view to display tables fields:
            gridTblFld.Columns.Add("Names", "Name");
            gridTblFld.Columns.Add("ColNames", "Type");
            gridTblFld.Columns.Add("ColLength", "Length");
            gridTblFld.Rows.Clear();
            
        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            frmNewTable newForm = new frmNewTable();
            newForm.ShowDialog(frmMain.ActiveForm);
        }

        private void frmNewDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                myDB.Connection.Close();
                myDB.Close(); //this is necessary to close DB object!!! Otherwise we wont be able to open it for viewing                
            }
            catch (Exception ex)
            {
                //this.Close();
            }
        }

        private void frmNewDB_Activated(object sender, EventArgs e)
        {
            // this event triggers refresh of the form data to show the changes in the database
            refreshFormData();
            lstRelations.Items.Clear();
            lstRelDetails.Items.Clear();
            showRelations();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshFormData();
        }

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string dbPath = Variables.NewFilePath;
            try
            {
                myDB = dbE.OpenDatabase(Variables.NewFilePath);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error openning database! \n" +
                //    "File path: " + dbPath + "\n" + ex,
                //    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorMsgDB(ex.ToString());
                return;
            }
            //show tables fields
            if (lstTables.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lstTables.SelectedIndices[0];
            if (intselectedindex < 0)
            {
                return;
            }
            string tblName = lstTables.Text;
            gridTblFld.Rows.Clear();
            int i = 0;
            //show table info
            try
            {
                TableDef myTable = myDB.TableDefs[tblName];
                foreach (Field fldExtItem in ((Fields)myTable.Fields))
                {
                    gridTblFld.Rows.Add(1);
                    gridTblFld.Rows[i].Cells[0].Value = fldExtItem.Name.ToString();
                    gridTblFld.Rows[i].Cells[1].Value = TableField.decodeFldType(fldExtItem.Type);
                    gridTblFld.Rows[i].Cells[2].Value = fldExtItem.Size.ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error reading database! \n" +
                //    "File path: " + Variables.NewFilePath + "\n" + ex,
                //    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                errorMsgDB(ex.ToString());
                return;
            }
        }

        private void frmNewDB_ResizeEnd(object sender, EventArgs e)
        {
            //change size of the form objects
            gridTblFld.Size = new Size(this.Width - 70, gridTblFld.Height);
            tabNewMDB.Size = new Size(this.Width - 50, tabNewMDB.Height);
        }

        private void btnTableMod_Click(object sender, EventArgs e)
        { //This event is used to call to Create New Table Relationship form
            if (lstTables.Items.Count < 2)
            {
                MessageBox.Show("More than 1 table required to build any relationships between tables for the crrent database");
                return;
            }
            frmRelations relForm = new frmRelations();
            relForm.ShowDialog(frmMain.ActiveForm);
            
        }

        private void lstRelations_SelectedIndexChanged(object sender, EventArgs e)
        {
            string relName = lstRelations.SelectedItem.ToString();
            showRelationsDetails(relName);
        }

        private void btnDelRel_Click(object sender, EventArgs e)
        {
            //to remove relationship from the database
            try
            {
                if (lstRelations.Items.Count > 0) //we only proceed if there are any relations found
                {
                    string relName = lstRelations.SelectedItem.ToString();
                    if (myDB != null)
                    {
                        foreach (Relation myRel in myDB.Relations)
                        {
                            if (myRel.Attributes == 0)
                            {
                                if (myRel.Name == relName)
                                {
                                    DialogResult isDelRel = new DialogResult();
                                    isDelRel = MessageBox.Show("Are you sure you want to remove tables relation: \n"
                                                        + myRel.Name.ToString() + " ?\n\n",
                                                        "Delete relation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (isDelRel == DialogResult.Yes)
                                    { //if yes - try to remove relations
                                        myDB.Relations.Delete(myRel.Name);
                                        myDB.Relations.Refresh();
                                        showRelations();
                                    }
                                    else
                                    {
                                        //cancelled
                                        return;
                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                errorMsgDB(ex.ToString());
                return;
            }
        }


        private void  showRelations()
        {
            lstRelations.Items.Clear();
            foreach (Relation myRel in myDB.Relations)
            {
                if (myRel.Attributes == 0)
                {
                    lstRelations.Items.Add(myRel.Name);
                }
            }
        }

        private void showTablesList()
        {
            lstTables.Items.Clear();
            string dbPath = Variables.NewFilePath;
            try
            {
                myDB = dbE.OpenDatabase(dbPath);

                //to show existing tables
                foreach (TableDef myTable in myDB.TableDefs)
                {
                    if (myTable.Attributes == 0)
                    {
                        lstTables.Items.Add(myTable.Name);
                    }
                }
                //to show existing relations
                lstRelations.Items.Clear();
                lstRelDetails.Items.Clear();
                showRelations();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error openning database! \n" + ex);
                errorMsgDB(ex.ToString());
                return;
            }
        }

        private void showRelationsDetails(string relName)
        { //show relations details for a selected table relations
            try
            {
                if (relName != "")
                {
                    lstRelDetails.Items.Clear();
                    foreach (Relation myRel in myDB.Relations)
                    {
                        if (myRel.Attributes == 0)
                        {
                            if (myRel.Name == relName)
                            {
                                lstRelDetails.Items.Add("Primary Table: " + myRel.Table);
                                lstRelDetails.Items.Add("Foreign Table: " + myRel.ForeignTable);
                                foreach (Field myFl in myRel.Fields)
                                {
                                    lstRelDetails.Items.Add("\t\t- Primary Field: " + myFl.Name);
                                    lstRelDetails.Items.Add("\t\t- Foreign Field: " + myFl.ForeignName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMsgDB(ex.ToString());
            }
            
        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {
            //Actions to remove a Table from the database
            if (lstTables.Items.Count > 0)
            {
                if (lstTables.SelectedIndex < 0)
                {
                    MessageBox.Show("No table to delete selected! \n" +
                        "Please select a table and try again...", 
                        "Deleting a table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                try
                { //try-catch for deleting the table================================
                    string tabName = lstTables.SelectedItem.ToString();
                    string dbPath = Variables.NewFilePath;
                    myDB = dbE.OpenDatabase(dbPath);

                    if (myDB != null)
                    {
                        foreach (TableDef myTab in myDB.TableDefs) //foreach (TableDef myTable in myDB.TableDefs)
                        {
                            if (myTab.Attributes == 0)
                            {
                                if (myTab.Name == tabName) //To confirm the table exists by its Name
                                {
                                    DialogResult isDelTab = new DialogResult();
                                    isDelTab = MessageBox.Show("Are you sure you want to remove table: \n"
                                                        + myTab.Name.ToString() + "?",
                                                        "Delete Tables", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (isDelTab == DialogResult.Yes)
                                    {
                                        myDB.TableDefs.Delete(myTab.Name);
                                        myDB.TableDefs.Refresh();
                                        refreshFormData();
                                    }
                                    else
                                    {
                                        //cancelled
                                        return;
                                    }
                                }
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting a table! \n" + ex.Message,
                                        "Error Deleting Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//try-catch for deleting the table================================
            }
            
        }

        private void frmNewDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                myDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while closing database \n" + ex.Message, 
                    "Error Closing Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void refreshFormData()
        {
            lstTables.Items.Clear();
            gridTblFld.Rows.Clear();
            string dbPath = Variables.NewFilePath;
            try
            {
                myDB = dbE.OpenDatabase(dbPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error openning database! \n" + ex);
                return;
            }
            try //checking Tables
            {
                //to show existing tables
                foreach (TableDef myTable in myDB.TableDefs)
                {
                    if (myTable.Attributes == 0)
                    {
                        lstTables.Items.Add(myTable.Name);
                    }
                }
                //to show existing relations
                lstRelations.Items.Clear();
                lstRelDetails.Items.Clear();
                showRelations();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database! \n" + ex);
                return;
            }
        }

        private void errorMsgDB(string errMessage)
        { //to show the error message with message specific to the error
            MessageBox.Show("Error operating database! \n" +
                    "File path: " + Variables.NewFilePath + "\n" + errMessage,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this operation?",
                    "Closing New Fatabase Creation Process", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }            
        }
    }
}
