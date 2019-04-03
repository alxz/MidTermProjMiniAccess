namespace MiniAccessApp.GUI
{
    partial class frmOpenDB
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
            this.lstViewOpenTbl = new System.Windows.Forms.ListView();
            this.gridOpenTblView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowTableView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowStruct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOpenTblView)).BeginInit();
            this.SuspendLayout();
            // 
            // lstViewOpenTbl
            // 
            this.lstViewOpenTbl.Location = new System.Drawing.Point(26, 103);
            this.lstViewOpenTbl.MultiSelect = false;
            this.lstViewOpenTbl.Name = "lstViewOpenTbl";
            this.lstViewOpenTbl.Size = new System.Drawing.Size(491, 272);
            this.lstViewOpenTbl.TabIndex = 4;
            this.lstViewOpenTbl.TileSize = new System.Drawing.Size(20, 20);
            this.lstViewOpenTbl.UseCompatibleStateImageBehavior = false;
            this.lstViewOpenTbl.View = System.Windows.Forms.View.List;
            this.lstViewOpenTbl.SelectedIndexChanged += new System.EventHandler(this.lstViewOpenTbl_SelectedIndexChanged);
            this.lstViewOpenTbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstViewOpenTbl_MouseDoubleClick);
            // 
            // gridOpenTblView
            // 
            this.gridOpenTblView.AllowUserToAddRows = false;
            this.gridOpenTblView.AllowUserToDeleteRows = false;
            this.gridOpenTblView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOpenTblView.Location = new System.Drawing.Point(523, 103);
            this.gridOpenTblView.Name = "gridOpenTblView";
            this.gridOpenTblView.ReadOnly = true;
            this.gridOpenTblView.RowTemplate.Height = 33;
            this.gridOpenTblView.Size = new System.Drawing.Size(680, 272);
            this.gridOpenTblView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tables:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table - Fields:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(661, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database Structure and Tables View";
            // 
            // btnShowTableView
            // 
            this.btnShowTableView.Location = new System.Drawing.Point(26, 435);
            this.btnShowTableView.Name = "btnShowTableView";
            this.btnShowTableView.Size = new System.Drawing.Size(230, 53);
            this.btnShowTableView.TabIndex = 10;
            this.btnShowTableView.Text = "View Table Data";
            this.btnShowTableView.UseVisualStyleBackColor = true;
            this.btnShowTableView.Click += new System.EventHandler(this.btnShowTableView_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(995, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 53);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowStruct
            // 
            this.btnShowStruct.Location = new System.Drawing.Point(287, 435);
            this.btnShowStruct.Name = "btnShowStruct";
            this.btnShowStruct.Size = new System.Drawing.Size(230, 53);
            this.btnShowStruct.TabIndex = 12;
            this.btnShowStruct.Text = "&Database Structure";
            this.btnShowStruct.UseVisualStyleBackColor = true;
            this.btnShowStruct.Click += new System.EventHandler(this.btnShowStruct_Click);
            // 
            // frmOpenDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 526);
            this.Controls.Add(this.btnShowStruct);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowTableView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridOpenTblView);
            this.Controls.Add(this.lstViewOpenTbl);
            this.Name = "frmOpenDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOpenDB";
            this.Load += new System.EventHandler(this.frmOpenDB_Load);
            this.ResizeEnd += new System.EventHandler(this.frmOpenDB_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.gridOpenTblView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstViewOpenTbl;
        private System.Windows.Forms.DataGridView gridOpenTblView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowTableView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowStruct;
    }
}