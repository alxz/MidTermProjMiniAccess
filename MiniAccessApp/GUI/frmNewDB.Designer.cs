namespace MiniAccessApp
{
    partial class frmNewDB
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
            this.lstTables = new System.Windows.Forms.ListBox();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.btnDelTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridTblFld = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTableMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRelations = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstRelDetails = new System.Windows.Forms.ListBox();
            this.btnDelRel = new System.Windows.Forms.Button();
            this.tabNewMDB = new System.Windows.Forms.TabControl();
            this.tabPageNewTable = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTblFld)).BeginInit();
            this.tabNewMDB.SuspendLayout();
            this.tabPageNewTable.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTables
            // 
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(10, 21);
            this.lstTables.Margin = new System.Windows.Forms.Padding(2);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(420, 95);
            this.lstTables.TabIndex = 3;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            // 
            // btnNewTable
            // 
            this.btnNewTable.Location = new System.Drawing.Point(464, 21);
            this.btnNewTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(103, 28);
            this.btnNewTable.TabIndex = 4;
            this.btnNewTable.Text = "Add New Table";
            this.btnNewTable.UseVisualStyleBackColor = true;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // btnDelTable
            // 
            this.btnDelTable.Location = new System.Drawing.Point(464, 53);
            this.btnDelTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.Size = new System.Drawing.Size(103, 28);
            this.btnDelTable.TabIndex = 5;
            this.btnDelTable.Text = "Delete Table";
            this.btnDelTable.UseVisualStyleBackColor = true;
            this.btnDelTable.Click += new System.EventHandler(this.btnDelTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Existing Tables:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(39, 311);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 27);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridTblFld
            // 
            this.gridTblFld.AllowUserToAddRows = false;
            this.gridTblFld.AllowUserToDeleteRows = false;
            this.gridTblFld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTblFld.Location = new System.Drawing.Point(10, 144);
            this.gridTblFld.Margin = new System.Windows.Forms.Padding(2);
            this.gridTblFld.Name = "gridTblFld";
            this.gridTblFld.ReadOnly = true;
            this.gridTblFld.RowTemplate.Height = 33;
            this.gridTblFld.Size = new System.Drawing.Size(418, 116);
            this.gridTblFld.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table Fields:";
            // 
            // btnTableMod
            // 
            this.btnTableMod.Location = new System.Drawing.Point(464, 24);
            this.btnTableMod.Margin = new System.Windows.Forms.Padding(2);
            this.btnTableMod.Name = "btnTableMod";
            this.btnTableMod.Size = new System.Drawing.Size(103, 28);
            this.btnTableMod.TabIndex = 6;
            this.btnTableMod.Text = "Add Relations";
            this.btnTableMod.UseVisualStyleBackColor = true;
            this.btnTableMod.Click += new System.EventHandler(this.btnTableMod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Relations:";
            // 
            // lstRelations
            // 
            this.lstRelations.FormattingEnabled = true;
            this.lstRelations.Location = new System.Drawing.Point(15, 24);
            this.lstRelations.Margin = new System.Windows.Forms.Padding(2);
            this.lstRelations.Name = "lstRelations";
            this.lstRelations.Size = new System.Drawing.Size(394, 95);
            this.lstRelations.TabIndex = 10;
            this.lstRelations.SelectedIndexChanged += new System.EventHandler(this.lstRelations_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Relations details:";
            // 
            // lstRelDetails
            // 
            this.lstRelDetails.FormattingEnabled = true;
            this.lstRelDetails.Location = new System.Drawing.Point(15, 152);
            this.lstRelDetails.Margin = new System.Windows.Forms.Padding(2);
            this.lstRelDetails.Name = "lstRelDetails";
            this.lstRelDetails.Size = new System.Drawing.Size(394, 108);
            this.lstRelDetails.TabIndex = 12;
            // 
            // btnDelRel
            // 
            this.btnDelRel.Location = new System.Drawing.Point(464, 56);
            this.btnDelRel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelRel.Name = "btnDelRel";
            this.btnDelRel.Size = new System.Drawing.Size(103, 28);
            this.btnDelRel.TabIndex = 14;
            this.btnDelRel.Text = "Delete Relations";
            this.btnDelRel.UseVisualStyleBackColor = true;
            this.btnDelRel.Click += new System.EventHandler(this.btnDelRel_Click);
            // 
            // tabNewMDB
            // 
            this.tabNewMDB.Controls.Add(this.tabPageNewTable);
            this.tabNewMDB.Controls.Add(this.tabPage2);
            this.tabNewMDB.Location = new System.Drawing.Point(6, 1);
            this.tabNewMDB.Margin = new System.Windows.Forms.Padding(2);
            this.tabNewMDB.Name = "tabNewMDB";
            this.tabNewMDB.SelectedIndex = 0;
            this.tabNewMDB.Size = new System.Drawing.Size(610, 306);
            this.tabNewMDB.TabIndex = 15;
            // 
            // tabPageNewTable
            // 
            this.tabPageNewTable.Controls.Add(this.label3);
            this.tabPageNewTable.Controls.Add(this.btnDelTable);
            this.tabPageNewTable.Controls.Add(this.label2);
            this.tabPageNewTable.Controls.Add(this.btnNewTable);
            this.tabPageNewTable.Controls.Add(this.lstTables);
            this.tabPageNewTable.Controls.Add(this.gridTblFld);
            this.tabPageNewTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewTable.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageNewTable.Name = "tabPageNewTable";
            this.tabPageNewTable.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageNewTable.Size = new System.Drawing.Size(602, 280);
            this.tabPageNewTable.TabIndex = 0;
            this.tabPageNewTable.Text = "Add New Table";
            this.tabPageNewTable.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelRel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lstRelations);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lstRelDetails);
            this.tabPage2.Controls.Add(this.btnTableMod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(602, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Table Relations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(474, 311);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 27);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(624, 346);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabNewMDB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNewDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New MDB Design";
            this.Activated += new System.EventHandler(this.frmNewDB_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewDB_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNewDB_FormClosed);
            this.Load += new System.EventHandler(this.frmNewDB_Load);
            this.ResizeEnd += new System.EventHandler(this.frmNewDB_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.gridTblFld)).EndInit();
            this.tabNewMDB.ResumeLayout(false);
            this.tabPageNewTable.ResumeLayout(false);
            this.tabPageNewTable.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnDelTable;
        private System.Windows.Forms.Button btnTableMod;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridTblFld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRelations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstRelDetails;
        private System.Windows.Forms.Button btnDelRel;
        private System.Windows.Forms.TabControl tabNewMDB;
        private System.Windows.Forms.TabPage tabPageNewTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClose;
    }
}