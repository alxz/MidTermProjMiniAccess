namespace MiniAccessApp.GUI
{
    partial class frmNewTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFldName = new System.Windows.Forms.TextBox();
            this.txtFldLength = new System.Windows.Forms.TextBox();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFldAdd = new System.Windows.Forms.Button();
            this.gridFields = new System.Windows.Forms.DataGridView();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkAutoIncr = new System.Windows.Forms.CheckBox();
            this.grpNewTblCreate = new System.Windows.Forms.GroupBox();
            this.chkPKey = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTblName = new System.Windows.Forms.TextBox();
            this.btnRemoveFld = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).BeginInit();
            this.grpNewTblCreate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length:";
            // 
            // txtFldName
            // 
            this.txtFldName.Location = new System.Drawing.Point(172, 47);
            this.txtFldName.Name = "txtFldName";
            this.txtFldName.Size = new System.Drawing.Size(470, 31);
            this.txtFldName.TabIndex = 1;
            // 
            // txtFldLength
            // 
            this.txtFldLength.Location = new System.Drawing.Point(516, 103);
            this.txtFldLength.Name = "txtFldLength";
            this.txtFldLength.Size = new System.Drawing.Size(126, 31);
            this.txtFldLength.TabIndex = 3;
            // 
            // cboDataType
            // 
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Location = new System.Drawing.Point(172, 101);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(192, 33);
            this.cboDataType.TabIndex = 2;
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Type:";
            // 
            // btnFldAdd
            // 
            this.btnFldAdd.Location = new System.Drawing.Point(903, 39);
            this.btnFldAdd.Name = "btnFldAdd";
            this.btnFldAdd.Size = new System.Drawing.Size(196, 46);
            this.btnFldAdd.TabIndex = 6;
            this.btnFldAdd.Text = "&Add Field";
            this.btnFldAdd.UseVisualStyleBackColor = true;
            this.btnFldAdd.Click += new System.EventHandler(this.btnFldAdd_Click);
            // 
            // gridFields
            // 
            this.gridFields.AllowUserToAddRows = false;
            this.gridFields.AllowUserToDeleteRows = false;
            this.gridFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFields.Location = new System.Drawing.Point(12, 311);
            this.gridFields.Name = "gridFields";
            this.gridFields.ReadOnly = true;
            this.gridFields.RowTemplate.Height = 33;
            this.gridFields.Size = new System.Drawing.Size(1164, 332);
            this.gridFields.TabIndex = 7;
            this.gridFields.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFields_CellContentClick);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveClose.Location = new System.Drawing.Point(646, 671);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(201, 46);
            this.btnSaveClose.TabIndex = 7;
            this.btnSaveClose.Text = "Save And Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(903, 671);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(208, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel And Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkAutoIncr
            // 
            this.chkAutoIncr.AutoSize = true;
            this.chkAutoIncr.Location = new System.Drawing.Point(685, 49);
            this.chkAutoIncr.Name = "chkAutoIncr";
            this.chkAutoIncr.Size = new System.Drawing.Size(182, 29);
            this.chkAutoIncr.TabIndex = 4;
            this.chkAutoIncr.Text = "AutoIncrement";
            this.chkAutoIncr.UseVisualStyleBackColor = true;
            // 
            // grpNewTblCreate
            // 
            this.grpNewTblCreate.Controls.Add(this.btnRemoveFld);
            this.grpNewTblCreate.Controls.Add(this.chkPKey);
            this.grpNewTblCreate.Controls.Add(this.txtFldName);
            this.grpNewTblCreate.Controls.Add(this.chkAutoIncr);
            this.grpNewTblCreate.Controls.Add(this.label1);
            this.grpNewTblCreate.Controls.Add(this.label2);
            this.grpNewTblCreate.Controls.Add(this.txtFldLength);
            this.grpNewTblCreate.Controls.Add(this.cboDataType);
            this.grpNewTblCreate.Controls.Add(this.btnFldAdd);
            this.grpNewTblCreate.Controls.Add(this.label3);
            this.grpNewTblCreate.Location = new System.Drawing.Point(12, 138);
            this.grpNewTblCreate.Name = "grpNewTblCreate";
            this.grpNewTblCreate.Size = new System.Drawing.Size(1158, 167);
            this.grpNewTblCreate.TabIndex = 11;
            this.grpNewTblCreate.TabStop = false;
            this.grpNewTblCreate.Text = "New Filed:";
            // 
            // chkPKey
            // 
            this.chkPKey.AutoSize = true;
            this.chkPKey.Location = new System.Drawing.Point(685, 105);
            this.chkPKey.Name = "chkPKey";
            this.chkPKey.Size = new System.Drawing.Size(157, 29);
            this.chkPKey.TabIndex = 5;
            this.chkPKey.Text = "Primary key";
            this.chkPKey.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Table Name:";
            // 
            // txtTblName
            // 
            this.txtTblName.Location = new System.Drawing.Point(172, 48);
            this.txtTblName.Name = "txtTblName";
            this.txtTblName.Size = new System.Drawing.Size(927, 31);
            this.txtTblName.TabIndex = 0;
            // 
            // btnRemoveFld
            // 
            this.btnRemoveFld.Location = new System.Drawing.Point(903, 101);
            this.btnRemoveFld.Name = "btnRemoveFld";
            this.btnRemoveFld.Size = new System.Drawing.Size(196, 46);
            this.btnRemoveFld.TabIndex = 7;
            this.btnRemoveFld.Text = "&Remove Field";
            this.btnRemoveFld.UseVisualStyleBackColor = true;
            this.btnRemoveFld.Click += new System.EventHandler(this.btnRemoveFld_Click);
            // 
            // frmNewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1195, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpNewTblCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.gridFields);
            this.Name = "frmNewTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNewTable";
//            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNewTable_FormClosed);
            this.Load += new System.EventHandler(this.frmNewTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).EndInit();
            this.grpNewTblCreate.ResumeLayout(false);
            this.grpNewTblCreate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFldName;
        private System.Windows.Forms.TextBox txtFldLength;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFldAdd;
        private System.Windows.Forms.DataGridView gridFields;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAutoIncr;
        private System.Windows.Forms.GroupBox grpNewTblCreate;
        private System.Windows.Forms.CheckBox chkPKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTblName;
        private System.Windows.Forms.Button btnRemoveFld;
    }
}