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
    public partial class frmDBStructure : Form
    {
        public frmDBStructure()
        {
            InitializeComponent();
        }
        DBEngine dbe;
        Database myDB;
        //Recordset recTblData; //global var for Courses Recordset
        string _dbPath = Variables.OpenFilePath;

        private void frmDBStructure_Load(object sender, EventArgs e)
        {
            this.Text = "DataBase structure report:" + Variables.OpenFilePath;
            txtDB.Enabled = false;
            //lstDBStruc.Enabled = false;
            txtDB.Text = Variables.OpenFilePath;
            getTableStructure(_dbPath);
            btnClose.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getTableStructure(string dbPath)
        {
            
            string message = "";
            dbe = new DBEngine();
            try
            {
                myDB = dbe.OpenDatabase(dbPath);
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
                return ;
            }

            message = message + ("Database Name: " + myDB.Name);
            try
            {
                foreach (TableDef myTable in myDB.TableDefs)
                {
                    if (myTable.Attributes == 0)
                    {
                        lstDBStruc.Items.Add("Table : " + myTable.Name);
                        foreach (Field fldExtItem in ((Fields)myTable.Fields))
                        {
                            lstDBStruc.Items.Add("\t-Field: " + fldExtItem.Name +
                                "\tsize: " + fldExtItem.Size + "\ttype: " +
                                TableField.decodeFldType(fldExtItem.Type));

                        }
                        //DisplayNameAttribute all the indexes (the fields that are indexed) 
                        foreach (Index idxItem in myTable.Indexes)
                        {
                            lstDBStruc.Items.Add("\t\t-Index: " + idxItem.Name);
                            foreach (Field fldItem in ((IndexFields)idxItem.Fields))
                            {
                                lstDBStruc.Items.Add("\t\t\t-IndexedField: " + (fldItem.Name));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database! \n" + ex);
                return ;
            }

            try //Reading DB relations schemas
            {
                foreach (Relation myRel in myDB.Relations)
                {
                    if (myRel.Attributes == 0)
                    {
                        lstDBStruc.Items.Add("Relation: " + myRel.Name);
                        lstDBStruc.Items.Add("\t- Primary Table: " + myRel.Table);
                        lstDBStruc.Items.Add("\t- Foreign Table: " + myRel.ForeignTable);
                        foreach (Field myFl in myRel.Fields)
                        {
                            lstDBStruc.Items.Add("\t\t- Primary Field: " + myFl.Name);
                            lstDBStruc.Items.Add("\t\t- Foreign Field: " + myFl.ForeignName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database relations! \n" + ex);
                return ;
            }
        }
    }
}
