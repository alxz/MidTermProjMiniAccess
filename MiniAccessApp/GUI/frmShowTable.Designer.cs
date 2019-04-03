namespace MiniAccessApp.GUI
{
    partial class frmShowTable
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
            this.gridTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtRecordsCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTable
            // 
            this.gridTable.AllowUserToAddRows = false;
            this.gridTable.AllowUserToDeleteRows = false;
            this.gridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTable.Location = new System.Drawing.Point(12, 66);
            this.gridTable.Name = "gridTable";
            this.gridTable.ReadOnly = true;
            this.gridTable.RowTemplate.Height = 33;
            this.gridTable.Size = new System.Drawing.Size(1149, 651);
            this.gridTable.TabIndex = 0;
//            this.gridTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(91, 22);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(589, 31);
            this.txtTableName.TabIndex = 2;
            // 
            // txtRecordsCount
            // 
            this.txtRecordsCount.Location = new System.Drawing.Point(1031, 22);
            this.txtRecordsCount.Name = "txtRecordsCount";
            this.txtRecordsCount.Size = new System.Drawing.Size(130, 31);
            this.txtRecordsCount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Records:";
            // 
            // frmShowTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.txtRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTable);
            this.Name = "frmShowTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowTable";
            this.Load += new System.EventHandler(this.frmShowTable_Load);
            this.ResizeEnd += new System.EventHandler(this.frmShowTable_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtRecordsCount;
        private System.Windows.Forms.Label label2;
    }
}