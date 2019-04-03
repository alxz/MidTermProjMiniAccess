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
    public partial class frmShowTable : Form
    {
        public frmShowTable()
        {
            InitializeComponent();
        }
        DBEngine dbe;
        Database myDB;
        Recordset recTblData;
        //Recordset recTblData; //global var for Courses Recordset
        string dbPath = Variables.OpenFilePath;
        private void frmShowTable_Load(object sender, EventArgs e)
        {
            string tblName = Variables.ShowTableName;
            txtTableName.Text = tblName;
            this.Text = "Database: " + dbPath;
            dbe = new DBEngine();
            try
            {
                myDB = dbe.OpenDatabase(dbPath);
                txtTableName.Enabled = false;
                txtRecordsCount.Enabled = false;
                gridTable.Rows.Clear();
                int numFld = 0;
                //show table info
                TableDef myTable = myDB.TableDefs[tblName];
                foreach (Field fldExtItem in ((Fields)myTable.Fields))
                {
                    gridTable.Columns.Add(fldExtItem.Name.ToString(), fldExtItem.Name.ToString());
                    numFld++;
                }
                //recTblData = myDB.OpenRecordset("SELECT * FROM " + myTable.Name, DAO.RecordsetTypeEnum.dbOpenForwardOnly);
                recTblData = myDB.OpenRecordset("SELECT * FROM " + myTable.Name, DAO.RecordsetTypeEnum.dbOpenDynaset);
                recTblData.MoveLast();
                recTblData.MoveFirst();
                txtRecordsCount.Text = recTblData.RecordCount.ToString();
                for (int i = 0; i < recTblData.RecordCount; i++)
                {
                    gridTable.Rows.Add(1);
                    for (int j = 0; j < numFld; j++)
                    {
                        gridTable.Rows[i].Cells[j].Value = (recTblData.Fields[j].Value.ToString());
                    }
                    recTblData.MoveNext();
                }
                myDB.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error openning database! \n" + ex.Message
                                    + "\n" + ex.HResult.ToString(), 
                                    "Failed to open data", MessageBoxButtons.OK, MessageBoxIcon.Error );
                
                this.Close();
                return;
            }

        }

        private void frmShowTable_ResizeEnd(object sender, EventArgs e)
        {
            gridTable.Size = new Size(this.Width - 40, this.Height - 100);
        }


    }
}
