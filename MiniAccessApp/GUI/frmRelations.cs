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
using MiniAccessApp.Validation;

namespace MiniAccessApp.GUI
{
    public partial class frmRelations : Form
    {
        public frmRelations()
        {
            InitializeComponent();
        }

        string dbPath = Variables.NewFilePath;
        DBEngine dbE;
        Database myDB; //---- create database object
        //TableDef myTb; //-----table object

        private void btnRelSave_Click(object sender, EventArgs e)
        {
            //reating a relations in the table:
            Field myFl;
            string tabParent = cboParentTbl.Text;
            string tabChild = cboChildTbl.Text;
            string relName = txtRelName.Text.Trim();
            if (relName =="")
            {
                MessageBox.Show("Relatin Name could not be empty! \nPlease provide valid name.", 
                    "Error Relation Ceation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtRelName.Focus();
                return;
            }
            try
            {
                string tabParentFld = lstParentTbl.SelectedItem.ToString();
                string tabChldFld = lstChldTbl.SelectedItem.ToString();
                Relation myRel = myDB.CreateRelation(relName, tabParent, tabChild);
                //myRel.Table = tabParent;
                //myRel.ForeignTable = tabChild;
                myFl = myRel.CreateField(tabParentFld);
                myFl.ForeignName = tabChldFld;

                myRel.Fields.Append(myFl);
                myDB.Relations.Append(myRel);
                MessageBox.Show("Relation creatd! \n Going back...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Creating relations!!! \n" + ex.Message,
                    "Error Relation Ceation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            this.Close();
        }

        private void frmRelations_Load(object sender, EventArgs e)
        {
            this.Text = "Database: " + dbPath;
            dbE = new DBEngine();
            try
            {
                myDB = dbE.OpenDatabase(dbPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error openning database! \n" + ex);
                return;
            }
            //pre-loading comboboxes with table names
            try
            {
                foreach (TableDef myTable in myDB.TableDefs)
                {
                    if (myTable.Attributes == 0)
                    {
                        cboParentTbl.Items.Add(myTable.Name);
                        cboChildTbl.Items.Add(myTable.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database! \n" + ex);
                return;
            }
            gridRelations.Columns.Add("RelName", "Relation_Name");
            gridRelations.Columns.Add("ParentTable", "Parent_Table");
            gridRelations.Columns.Add("ChildTable", "Child_Table");
            int i = 0;
            try
            {
                foreach (Relation myRel in myDB.Relations)
                {
                    if (myRel.Attributes == 0)
                    {
                        foreach (Field myFl in myRel.Fields)
                        {
                            gridRelations.Rows.Add(1);
                            gridRelations.Rows[i].Cells[0].Value = myRel.Name.ToString();
                            gridRelations.Rows[i].Cells[1].Value = myRel.Table.ToString();
                            gridRelations.Rows[i].Cells[2].Value = myRel.ForeignTable.ToString();
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database relations! \n" + ex);
                return;
            }
        }

        private void cboParentTbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstParentTbl.Items.Clear();
            string tabParent = cboParentTbl.Text;
            if (tabParent == "")
            {
                MessageBox.Show("Please choose correct table!");
                return;
            }
            foreach (TableDef myTable in myDB.TableDefs)
            {
                if (myTable.Attributes == 0)
                {
                    if (myTable.Name == cboParentTbl.Text)
                    {
                        foreach (Field fldExtItem in ((Fields)myTable.Fields))
                        {
                            lstParentTbl.Items.Add(fldExtItem.Name);
                        }
                    }

                }
            }
        }

        private void cboChildTbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstChldTbl.Items.Clear();
            string tabParent = cboParentTbl.Text;
            if (tabParent == "")
            {
                MessageBox.Show("Please choose correct table!");
                return;
            }
            foreach (TableDef myTable in myDB.TableDefs)
            {
                if (myTable.Attributes == 0)
                {
                    if (myTable.Name == cboChildTbl.Text)
                    {
                        foreach (Field fldExtItem in ((Fields)myTable.Fields))
                        {
                            lstChldTbl.Items.Add(fldExtItem.Name);
                        }
                    }
                        
                }
            }
        }

        private void lstParentTbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstParentTbl.SelectedIndex >= 0)
            {
                lblParentTbl.Text = lstParentTbl.SelectedItem.ToString();
            }
            
        }

        private void lstChldTbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChldTbl.SelectedIndex >= 0)
            {
                lblChildTbl.Text = lstChldTbl.SelectedItem.ToString();
            }
        }

        internal object GetValue()
        {
            String relName = txtRelName.Text.Trim();
            return relName;
        }
    }
}
