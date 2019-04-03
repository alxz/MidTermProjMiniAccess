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
using MiniAccessApp.Business;
using DAO;
using MiniAccessApp.Validation;

namespace MiniAccessApp.GUI
{
    public partial class frmNewTable : Form
    {
        public frmNewTable()
        {
            InitializeComponent();
        }

        string dbPath = Variables.NewFilePath;
        string newTableName;// = Variables.newTableName;
        DBEngine dbE;
        Database myDB; //---- create database object
        TableDef myTb; //-----table object
        List<TableField> fliItemList; //new Fields List
        bool isPkeyAssigned = false;
        private void frmNewTable_Load(object sender, EventArgs e)
        {
            dbE = new DBEngine();
            try
            {
                myDB = dbE.OpenDatabase(dbPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error openning database! \n" + ex);
                this.Close();
            }            
            // datatype combobox
            cboDataType.Items.Add("dbInt");
            cboDataType.Items.Add("dbLong");
            cboDataType.Items.Add("dbText");
            cboDataType.Items.Add("dbBoolean");
            cboDataType.Items.Add("dbDate");
            cboDataType.SelectedIndex = 1;
            fliItemList = new List<TableField>();

            gridFields.Columns.Add("ColName","Name");
            gridFields.Columns.Add("ColNames", "Type");
            gridFields.Columns.Add("ColLength", "Length");
            gridFields.Columns.Add("ColPriKey", "Primary-Key");
            gridFields.Columns.Add("ColAutoNum", "AutoNumber");
            //grpNewTblCreate.Enabled = false;
            txtTblName.Focus();
        }

        private void fillInlstViewFields(List<TableField> tableFields)
        { //populate a list view with the list of fields
            int i = 0;
            gridFields.Rows.Clear();
            foreach (TableField fld in tableFields)
            {
                gridFields.Rows.Add(1);
                gridFields.Rows[i].Cells[0].Value = fld.FieldName;
                gridFields.Rows[i].Cells[1].Value = fld.FieldType;
                gridFields.Rows[i].Cells[2].Value = fld.FieldLength.ToString();
                if (fld.IsPkey)
                {
                    gridFields.Rows[i].Cells[3].Value = fld.IsPkey.ToString();
                }
                if (fld.IsAutoIncr)
                {
                    gridFields.Rows[i].Cells[4].Value = fld.IsAutoIncr.ToString();
                }
                ++i;
            }
        }



        private void btnFldAdd_Click(object sender, EventArgs e)
        {
            //====== Creating new Table Fields!!! =================  
            try
            {
                string fldName = txtFldName.Text.Trim();
                if (!Validator.isValidName(fldName))
                {
                    MessageBox.Show("Field Name should contains only alphanumeric characters \n" +
                        "and it is should not be empty!",
                        "Name the field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFldName.Focus();
                    return;
                }

                string fldType = cboDataType.Text;
                string fldLengthStr = txtFldLength.Text.Trim();
                int fldLenNum;
                DataTypeEnum fldTypeEnum;

                foreach (TableField fldItem in fliItemList)
                { //let verify if this FIELD name already in use
                    if (fldItem.FieldName == fldName)
                    {
                        MessageBox.Show("Field with this name already in the list:  " + fldName +
                            "\nCan not use the same field name! No filed will be added." +
                            "\nPlease choose another name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (fldItem.IsPkey)
                    {
                        isPkeyAssigned = true;
                    }
                }
                TableField newFlditem = new TableField();
                newFlditem.FieldName = fldName;
                newFlditem.FieldType = fldType;
                //create fields:
                switch (fldType)
                {
                    case "dbInt":
                        fldTypeEnum = DataTypeEnum.dbInteger;
                        break;
                    case "dbLong":
                        fldTypeEnum = DataTypeEnum.dbLong;
                        break;
                    case "dbText":
                        fldTypeEnum = DataTypeEnum.dbText;
                        break;
                    case "dbBoolean":
                        fldTypeEnum = DataTypeEnum.dbBoolean;
                        break;
                    case "dbDate":
                        fldTypeEnum = DataTypeEnum.dbDate;
                        break;
                    default:
                        MessageBox.Show("Unknown error during type defenition! \nDefault type will be TEXT!", "Error");
                        fldTypeEnum = DataTypeEnum.dbText;
                        break;
                }

                //creating a field:            
                if (fldTypeEnum == DataTypeEnum.dbText)
                {
                    //text field - length set to 50 by default
                    fldLenNum = (fldLengthStr != "") ? Convert.ToInt32(fldLengthStr) : 50;
                    //myFld = myTb.CreateField(fldName, DAO.DataTypeEnum.dbText, fldLenNum);
                }
                else if ((fldTypeEnum == DataTypeEnum.dbBoolean) || (fldTypeEnum == DataTypeEnum.dbDate))
                {
                    fldLenNum = 1;
                }
                else
                {
                    //numeric data field - default length =1 but it is not used anyway
                    fldLenNum = (fldLengthStr != "") ? Convert.ToInt32(fldLengthStr) : 1;
                    //myFld = myTb.CreateField(fldName, fldTypeEnum);
                    if (chkAutoIncr.Checked)
                    {
                        //Auto Increment numeric field if selected checkbox
                        if (fldType == "dbLong")
                        {
                            //myFld.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;
                            newFlditem.IsAutoIncr = true;
                        }
                        //Auto Increment numeric field not good with Integer type:
                        else if (fldType == "dbInt")
                        {
                            MessageBox.Show("Field type set to INTEGER could not be set to Autoincrement. \n" +
                                "(This is temporary technical limits of the program). \n" +
                                "Please change the type of the field to LONG...", "Attention Limitations!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            newFlditem.IsAutoIncr = false;
                            cboDataType.Focus();
                            return;
                        }
                    }
                }
                newFlditem.FieldLength = fldLenNum;
                if ((chkPKey.Checked) && (!isPkeyAssigned))
                {
                    newFlditem.IsPkey = true;
                }
                //add table field to the list of fields of the table
                fliItemList.Add(newFlditem);
                fillInlstViewFields(fliItemList);
                txtFldName.Clear();
                txtFldLength.Clear();
                chkAutoIncr.Checked = false;
                chkPKey.Checked = false;
                txtFldName.Focus();
                //myDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! \n" + ex.Message, "Error creating new field", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e) //save and close
        {            
            //saveTable button pressed - lets check the new table name and proceed:
            bool isTableNameUniqe = true;
            bool isFldCreated = false;
            newTableName = txtTblName.Text.Trim();
            if (!Validator.isValidName(newTableName))
            {
                txtTblName.Focus();
                return;
            }
            //verify if any fields existing:
            if (fliItemList.Count == 0)
            {
                MessageBox.Show("There is not fields in this new table found!" +
                    "\nSorry we can not create a table with no fields!" +
                    "\nPlease add a field or Cancel creation process!", "Warning new Table",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Table name verification if existing
            try
            {
                foreach (TableDef myTable in myDB.TableDefs)
                {
                    if (myTable.Attributes == 0)
                    {
                        if (myTable.Name.ToUpper() == newTableName.ToUpper())
                        {
                            MessageBox.Show("Can\'t create the new table! " +
                                "\nTable : " + myTable.Name + "\nAlready existing!");
                            gridFields.Rows.Clear();
                            int i = 0;
                            foreach (Field fldExtItem in ((Fields)myTable.Fields))
                            {
                                gridFields.Rows.Add(1);
                                gridFields.Rows[i].Cells[0].Value = fldExtItem.Name.ToString();
                                gridFields.Rows[i].Cells[1].Value = TableField.decodeFldType(fldExtItem.Type);
                                gridFields.Rows[i].Cells[2].Value = fldExtItem.Size.ToString();
                                i++;
                            }
                            isTableNameUniqe = false;
                            Variables.NewTableName = "";
                            grpNewTblCreate.Enabled = false;
                        }
                    }
                }
                if (isTableNameUniqe)
                {
                    Variables.NewTableName = newTableName;
                    //creating table object
                    myTb = myDB.CreateTableDef(newTableName);

                    foreach (TableField field in fliItemList)
                    {
                        isFldCreated = createTblField(field); //create field
                    }
                    myDB.TableDefs.Append(myTb); //adding table to the DataBase
                    grpNewTblCreate.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading database! \n" + ex);
                return;
            }
            myDB.Close();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myDB.Close();
            this.Close();
        }

        private void cboDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkAutoIncr.Checked = false;
            chkPKey.Checked = false;
            string fldType = cboDataType.Text;
            if ((fldType == "dbInt") || (fldType == "dbLong"))
            {
                chkAutoIncr.Enabled = true;
            }
            else
            {
                chkAutoIncr.Enabled = false;
            }
        }


        private bool createTblField(TableField newFld) //procedure of creating a field and adding it to the table
        {
            DataTypeEnum fldTypeEnum;
            Field myFld;
           
            string fldName = newFld.FieldName;
            string fldType = newFld.FieldType;
            int fldLenNum = newFld.FieldLength;
            bool isPkeyFld = newFld.IsPkey;
            bool isAutoIncr = newFld.IsAutoIncr;
            //create fields:
            switch (fldType)
            {
                case "dbInt":
                    fldTypeEnum = DataTypeEnum.dbInteger;
                    break;
                case "dbLong":
                    fldTypeEnum = DataTypeEnum.dbLong;
                    break;
                case "dbText":
                    fldTypeEnum = DataTypeEnum.dbText;
                    break;
                case "dbBoolean":
                    fldTypeEnum = DataTypeEnum.dbBoolean;
                    break;
                case "dbDate":
                    fldTypeEnum = DataTypeEnum.dbDate;
                    break;
                default:
                    MessageBox.Show("Unknown error during type defenition! \nDefault type will be TEXT!", "Error");
                    fldTypeEnum = DataTypeEnum.dbText;
                    break;
            }

            //creating a field:            
            if (fldTypeEnum == DataTypeEnum.dbText)
            {
                //text field - length set to 50 by default
                //fldLenNum = (fldLengthStr != "") ? Convert.ToInt32(fldLengthStr) : 50;
                myFld = myTb.CreateField(fldName, DAO.DataTypeEnum.dbText, fldLenNum);
            }
            else
            {
                //numeric data field - default length =1 but it is not used anyway
                //fldLenNum = (fldLengthStr != "") ? Convert.ToInt32(fldLengthStr) : 1;
                myFld = myTb.CreateField(fldName, fldTypeEnum);
                if (isAutoIncr)
                {
                    //Auto Increment numeric field if selected checkbox
                    if ((fldTypeEnum == DataTypeEnum.dbInteger) || (fldTypeEnum == DataTypeEnum.dbLong))
                    {
                        myFld.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;
                    }
                }
            }
            //lets try to append a field to the table:
            try
            {
                myTb.Fields.Append(myFld);
                if (isPkeyFld)
                {
                    //create the indexes
                    Index myInd = myTb.CreateIndex("PrimaryKey");
                    myFld = myInd.CreateField(fldName);
                    ((IndexFields)(myInd.Fields)).Append(myFld);
                    myInd.Primary = true;
                    myTb.Indexes.Append(myInd);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not create field: " + newFld.FieldName + "\n" + ex.Message,
                    "Error while creating new field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            
        }

        private void gridFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //click grid view action
        }

        private void btnRemoveFld_Click(object sender, EventArgs e)
        {
            //Remove table field from the list of fields of the table
            string fldNameDel;
            if (gridFields.SelectedRows.Count == 1)
            {
                //fliItemList.Add(newFlditem);
                fldNameDel = gridFields.SelectedRows[0].Cells[0].Value.ToString();
                gridFields.Rows.RemoveAt(gridFields.SelectedRows[0].Cells[0].RowIndex);

                foreach (TableField tblFld in fliItemList)
                {
                    if (tblFld.FieldName.ToString() == fldNameDel)
                    {
                        fliItemList.Remove(tblFld);
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("To delte a table field from the list: \n\n" +
                    "1) Please select a row in te list \n" +
                    "2)Click <Remove Field> button", "How to remove a field", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Int32 selectedRowCount = gridFields.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //if (selectedRowCount > 0)
            //{
            //    System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //    for (int i = 0; i < selectedRowCount; i++)
            //    {
            //        sb.Append("Row: ");
            //        //sb.Append(gridFields.SelectedRows[i].Index.ToString());
            //        sb.Append(gridFields.SelectedRows[i].Cells[0].Value.ToString());
            //        sb.Append(Environment.NewLine);
            //    }

            //    sb.Append("Total: " + selectedRowCount.ToString());
            //    MessageBox.Show(sb.ToString(), "Selected Rows");
            // }

        }
    }
}
