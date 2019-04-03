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
using DAO;

namespace MiniAccessApp.GUI
{
    public partial class frmOpenDB : Form
    {
        DBEngine dbe;
        Database myDB;
        //Recordset recTblData; //global var for Courses Recordset
        string _dbPath = Variables.OpenFilePath;
        //string openTab = Variables.showTableName;
        public frmOpenDB()
        {
            InitializeComponent();
        }
        
        private void frmOpenDB_Load(object sender, EventArgs e)
        {
            this.Text = "Database: " + _dbPath;
            dbe = new DBEngine();
            try
            {
                myDB = dbe.OpenDatabase(_dbPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error openning database! \n" + ex.Message 
                                    + "\n" + ex.HResult.ToString());
                try
                {
                    myDB.Close();
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Error openning database! \n" + exx.Message
                                    + "\n" + exx.HResult.ToString());
                }
                this.Close();
                return;
            }
            showTablesAndRelations();
            //creating columnd for a grid view to display tables fields:
            gridOpenTblView.Columns.Add("Names", "Name");
            gridOpenTblView.Columns.Add("Types", "Data Type");
            gridOpenTblView.Columns.Add("Sizes", "Size");
        }
             

        private void frmOpenDB_ResizeEnd(object sender, EventArgs e)
        {
            //lstOpenDBShow.Size = new Size(this.Width - 50, this.Height - 270);
        }

        private void lstViewOpenTbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewOpenTbl.SelectedIndices.Count <=0)
            {
                return;
            }
            int intselectedindex = lstViewOpenTbl.SelectedIndices[0];
            if (intselectedindex < 0)
            {
                return;
            }
            string tblName = lstViewOpenTbl.Items[intselectedindex].Text;
            gridOpenTblView.Rows.Clear();
            int i = 0;
            //show table info
            try
            {
                TableDef myTable = myDB.TableDefs[tblName];
                foreach (Field fldExtItem in ((Fields)myTable.Fields))
                {
                    gridOpenTblView.Rows.Add(1);
                    gridOpenTblView.Rows[i].Cells[0].Value = fldExtItem.Name.ToString();
                    gridOpenTblView.Rows[i].Cells[1].Value = TableField.decodeFldType(fldExtItem.Type);
                    gridOpenTblView.Rows[i].Cells[2].Value = fldExtItem.Size.ToString();                    
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database! \n" + ex);
                return;
            }
        }

        private void lstViewOpenTbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //to show the table content in the new window

            if (lstViewOpenTbl.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lstViewOpenTbl.SelectedIndices[0];
            if (intselectedindex < 0)
            {
                return;
            }
            string tblName = lstViewOpenTbl.Items[intselectedindex].Text;
            Variables.ShowTableName = tblName;
            //MessageBox.Show("Table to show: " + Variables.showTableName);
            //calling frmShowTable as modal form
            frmShowTable f = new frmShowTable();
            f.ShowDialog(frmMain.ActiveForm);

        }

        private void btnShowStruct_Click(object sender, EventArgs e)
        {
            //show structure view of the database
            //Variables.MsgToShow = ("Database Structure: \n" + getTableStructure(_dbPath));
            
            //calling frmShowTable as modal form
            frmDBStructure f = new frmDBStructure();
            f.ShowDialog(frmMain.ActiveForm);
        }


        

        public void showTablesAndRelations()
        {
            this.Text = "Database: " + _dbPath;
            dbe = new DBEngine();
            try
            {
                myDB = dbe.OpenDatabase(_dbPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error openning database! \n" + ex.Message
                                    + "\n" + ex.HResult.ToString());
                try //we will try to close the database
                {
                    myDB.Close();
                }
                catch (Exception exx)
                {//just ignore and exit
                }
                this.Close();
                return ;
            }
            //lets display the data tables and relations
            //lstOpenDBShow.Items.Clear();
            //lstOpenDBShow.Items.Add("Database Name: " + myDB.Name);
            //lstOpenDBShow.Items.Add("========================================================");
            try
            {
                foreach (TableDef myTable in myDB.TableDefs)
                {
                    if (myTable.Attributes == 0)
                    {
                        //lstOpenDBShow.Items.Add("Table : " + myTable.Name);
                        lstViewOpenTbl.Items.Add(myTable.Name);
                        //foreach (Field fldExtItem in ((Fields)myTable.Fields))
                        //{
                        //    //lstOpenDBShow.Items.Add("\t-Field: " + fldExtItem.Name +
                        //    //    "\tsize: " + fldExtItem.Size + "\ttype: " + TableField.decodeFldType(fldExtItem.Type));
                            
                        //}
                        ////DisplayNameAttribute all the indexes (the fields that are indexed) 
                        //foreach (Index idxItem in myTable.Indexes)
                        //{
                        //    lstOpenDBShow.Items.Add("\t\t-Index: " + idxItem.Name);
                        //    foreach (Field fldItem in ((IndexFields)idxItem.Fields))
                        //    {
                        //        lstOpenDBShow.Items.Add("\t\t\t-IndexedField: " + (fldItem.Name));
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database! \n" + ex);
                return;
            }

            try //Reading DB relations schemas
            {
                foreach (Relation myRel in myDB.Relations)
                {
                    if (myRel.Attributes == 0)
                    {
                        //lstOpenDBShow.Items.Add("Relation: " + myRel.Name);
                        //lstOpenDBShow.Items.Add("\t- Primary Table: " + myRel.Table);
                        //lstOpenDBShow.Items.Add("\t- Foreign Table: " + myRel.ForeignTable);
                        //foreach (Field myFl in myRel.Fields)
                        //{
                        //    lstOpenDBShow.Items.Add("\t\t- Primary Field: " + myFl.Name);
                        //    lstOpenDBShow.Items.Add("\t\t- Foreign Field: " + myFl.ForeignName);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database relations! \n" + ex);
                return ;
            }
        }

        private void btnShowTableView_Click(object sender, EventArgs e)
        {
            //frmMain.ActiveForm
            //to show the table content in the new window

            if (lstViewOpenTbl.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lstViewOpenTbl.SelectedIndices[0];
            if (intselectedindex < 0)
            {
                return;
            }
            string tblName = lstViewOpenTbl.Items[intselectedindex].Text;
            Variables.ShowTableName = tblName;
            //MessageBox.Show("Table to show: " + Variables.showTableName);
            //calling frmShowTable as modal form
            frmShowTable f = new frmShowTable();
            f.ShowDialog(frmMain.ActiveForm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
