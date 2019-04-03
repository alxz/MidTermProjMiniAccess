namespace MiniAccessApp.GUI
{
    partial class frmRelations
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
            this.txtRelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRelations = new System.Windows.Forms.DataGridView();
            this.btnRelSave = new System.Windows.Forms.Button();
            this.cboParentTbl = new System.Windows.Forms.ComboBox();
            this.cboChildTbl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstParentTbl = new System.Windows.Forms.ListBox();
            this.lstChldTbl = new System.Windows.Forms.ListBox();
            this.lblParentTbl = new System.Windows.Forms.Label();
            this.lblChildTbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRelName
            // 
            this.txtRelName.Location = new System.Drawing.Point(25, 38);
            this.txtRelName.Name = "txtRelName";
            this.txtRelName.Size = new System.Drawing.Size(817, 31);
            this.txtRelName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relation name:";
            // 
            // gridRelations
            // 
            this.gridRelations.AllowUserToAddRows = false;
            this.gridRelations.AllowUserToDeleteRows = false;
            this.gridRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelations.Location = new System.Drawing.Point(25, 420);
            this.gridRelations.Name = "gridRelations";
            this.gridRelations.ReadOnly = true;
            this.gridRelations.RowTemplate.Height = 33;
            this.gridRelations.Size = new System.Drawing.Size(817, 166);
            this.gridRelations.TabIndex = 2;
            // 
            // btnRelSave
            // 
            this.btnRelSave.Location = new System.Drawing.Point(307, 604);
            this.btnRelSave.Name = "btnRelSave";
            this.btnRelSave.Size = new System.Drawing.Size(221, 49);
            this.btnRelSave.TabIndex = 3;
            this.btnRelSave.Text = "Save and Close";
            this.btnRelSave.UseVisualStyleBackColor = true;
            this.btnRelSave.Click += new System.EventHandler(this.btnRelSave_Click);
            // 
            // cboParentTbl
            // 
            this.cboParentTbl.FormattingEnabled = true;
            this.cboParentTbl.Location = new System.Drawing.Point(25, 113);
            this.cboParentTbl.Name = "cboParentTbl";
            this.cboParentTbl.Size = new System.Drawing.Size(361, 33);
            this.cboParentTbl.TabIndex = 1;
            this.cboParentTbl.SelectedIndexChanged += new System.EventHandler(this.cboParentTbl_SelectedIndexChanged);
            // 
            // cboChildTbl
            // 
            this.cboChildTbl.FormattingEnabled = true;
            this.cboChildTbl.Location = new System.Drawing.Point(481, 113);
            this.cboChildTbl.Name = "cboChildTbl";
            this.cboChildTbl.Size = new System.Drawing.Size(361, 33);
            this.cboChildTbl.TabIndex = 2;
            this.cboChildTbl.SelectedIndexChanged += new System.EventHandler(this.cboChildTbl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parent Table:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Child Table:";
            // 
            // lstParentTbl
            // 
            this.lstParentTbl.FormattingEnabled = true;
            this.lstParentTbl.ItemHeight = 25;
            this.lstParentTbl.Location = new System.Drawing.Point(25, 183);
            this.lstParentTbl.Name = "lstParentTbl";
            this.lstParentTbl.Size = new System.Drawing.Size(361, 179);
            this.lstParentTbl.TabIndex = 8;
            this.lstParentTbl.SelectedIndexChanged += new System.EventHandler(this.lstParentTbl_SelectedIndexChanged);
            // 
            // lstChldTbl
            // 
            this.lstChldTbl.FormattingEnabled = true;
            this.lstChldTbl.ItemHeight = 25;
            this.lstChldTbl.Location = new System.Drawing.Point(481, 183);
            this.lstChldTbl.Name = "lstChldTbl";
            this.lstChldTbl.Size = new System.Drawing.Size(361, 179);
            this.lstChldTbl.TabIndex = 9;
            this.lstChldTbl.SelectedIndexChanged += new System.EventHandler(this.lstChldTbl_SelectedIndexChanged);
            // 
            // lblParentTbl
            // 
            this.lblParentTbl.AutoSize = true;
            this.lblParentTbl.Location = new System.Drawing.Point(30, 380);
            this.lblParentTbl.Name = "lblParentTbl";
            this.lblParentTbl.Size = new System.Drawing.Size(19, 25);
            this.lblParentTbl.TabIndex = 10;
            this.lblParentTbl.Text = "-";
            // 
            // lblChildTbl
            // 
            this.lblChildTbl.AutoSize = true;
            this.lblChildTbl.Location = new System.Drawing.Point(487, 380);
            this.lblChildTbl.Name = "lblChildTbl";
            this.lblChildTbl.Size = new System.Drawing.Size(19, 25);
            this.lblChildTbl.TabIndex = 11;
            this.lblChildTbl.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Child Field:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Parent Field:";
            // 
            // frmRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 664);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblChildTbl);
            this.Controls.Add(this.lblParentTbl);
            this.Controls.Add(this.lstChldTbl);
            this.Controls.Add(this.lstParentTbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboChildTbl);
            this.Controls.Add(this.cboParentTbl);
            this.Controls.Add(this.btnRelSave);
            this.Controls.Add(this.gridRelations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRelName);
            this.Name = "frmRelations";
            this.Text = "frmRelations";
            this.Load += new System.EventHandler(this.frmRelations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRelations;
        private System.Windows.Forms.Button btnRelSave;
        private System.Windows.Forms.ComboBox cboParentTbl;
        private System.Windows.Forms.ComboBox cboChildTbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstParentTbl;
        private System.Windows.Forms.ListBox lstChldTbl;
        private System.Windows.Forms.Label lblParentTbl;
        private System.Windows.Forms.Label lblChildTbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}