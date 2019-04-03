namespace MiniAccessApp
{
    partial class frmWelcome
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
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.grpBoxWelcome = new System.Windows.Forms.GroupBox();
            this.radOpen = new System.Windows.Forms.RadioButton();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.grpBoxOpen = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenBrowse = new System.Windows.Forms.Button();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.grpBoxNewDB = new System.Windows.Forms.GroupBox();
            this.btnBrowseNewFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewDBFile = new System.Windows.Forms.TextBox();
            this.openFileDial1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDial1 = new System.Windows.Forms.SaveFileDialog();
            this.grpBoxWelcome.SuspendLayout();
            this.grpBoxOpen.SuspendLayout();
            this.grpBoxNewDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(174, 73);
            this.cmdCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(116, 37);
            this.cmdCreate.TabIndex = 0;
            this.cmdCreate.Text = "Create Database";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(172, 76);
            this.cmdOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(118, 37);
            this.cmdOpen.TabIndex = 4;
            this.cmdOpen.Text = "Open Database";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO miniAccess DBMS";
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(14, 211);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(118, 37);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "&Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // grpBoxWelcome
            // 
            this.grpBoxWelcome.Controls.Add(this.radOpen);
            this.grpBoxWelcome.Controls.Add(this.radNew);
            this.grpBoxWelcome.Controls.Add(this.cmdExit);
            this.grpBoxWelcome.Location = new System.Drawing.Point(13, 43);
            this.grpBoxWelcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxWelcome.Name = "grpBoxWelcome";
            this.grpBoxWelcome.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxWelcome.Size = new System.Drawing.Size(163, 267);
            this.grpBoxWelcome.TabIndex = 4;
            this.grpBoxWelcome.TabStop = false;
            this.grpBoxWelcome.Enter += new System.EventHandler(this.grpBoxWelcome_Enter);
            // 
            // radOpen
            // 
            this.radOpen.AutoSize = true;
            this.radOpen.Location = new System.Drawing.Point(14, 76);
            this.radOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radOpen.Name = "radOpen";
            this.radOpen.Size = new System.Drawing.Size(109, 17);
            this.radOpen.TabIndex = 1;
            this.radOpen.TabStop = true;
            this.radOpen.Text = "Open Database...";
            this.radOpen.UseVisualStyleBackColor = true;
            this.radOpen.CheckedChanged += new System.EventHandler(this.radOpen_CheckedChanged);
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.Location = new System.Drawing.Point(14, 38);
            this.radNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(105, 17);
            this.radNew.TabIndex = 0;
            this.radNew.TabStop = true;
            this.radNew.Text = "New Database...";
            this.radNew.UseVisualStyleBackColor = true;
            this.radNew.CheckedChanged += new System.EventHandler(this.radNew_CheckedChanged);
            // 
            // grpBoxOpen
            // 
            this.grpBoxOpen.Controls.Add(this.cmdOpen);
            this.grpBoxOpen.Controls.Add(this.label2);
            this.grpBoxOpen.Controls.Add(this.btnOpenBrowse);
            this.grpBoxOpen.Controls.Add(this.txtOpenFile);
            this.grpBoxOpen.Location = new System.Drawing.Point(179, 178);
            this.grpBoxOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxOpen.Name = "grpBoxOpen";
            this.grpBoxOpen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxOpen.Size = new System.Drawing.Size(321, 132);
            this.grpBoxOpen.TabIndex = 6;
            this.grpBoxOpen.TabStop = false;
            this.grpBoxOpen.Text = "Open Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File path:";
            // 
            // btnOpenBrowse
            // 
            this.btnOpenBrowse.Location = new System.Drawing.Point(30, 76);
            this.btnOpenBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenBrowse.Name = "btnOpenBrowse";
            this.btnOpenBrowse.Size = new System.Drawing.Size(118, 37);
            this.btnOpenBrowse.TabIndex = 3;
            this.btnOpenBrowse.Text = "Choose File";
            this.btnOpenBrowse.UseVisualStyleBackColor = true;
            this.btnOpenBrowse.Click += new System.EventHandler(this.btnOpenBrowse_Click);
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(18, 39);
            this.txtOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.Size = new System.Drawing.Size(286, 20);
            this.txtOpenFile.TabIndex = 2;
            // 
            // grpBoxNewDB
            // 
            this.grpBoxNewDB.Controls.Add(this.btnBrowseNewFile);
            this.grpBoxNewDB.Controls.Add(this.label4);
            this.grpBoxNewDB.Controls.Add(this.txtNewDBFile);
            this.grpBoxNewDB.Controls.Add(this.cmdCreate);
            this.grpBoxNewDB.Location = new System.Drawing.Point(179, 43);
            this.grpBoxNewDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxNewDB.Name = "grpBoxNewDB";
            this.grpBoxNewDB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxNewDB.Size = new System.Drawing.Size(318, 132);
            this.grpBoxNewDB.TabIndex = 5;
            this.grpBoxNewDB.TabStop = false;
            this.grpBoxNewDB.Text = "Create New";
            // 
            // btnBrowseNewFile
            // 
            this.btnBrowseNewFile.Location = new System.Drawing.Point(26, 73);
            this.btnBrowseNewFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowseNewFile.Name = "btnBrowseNewFile";
            this.btnBrowseNewFile.Size = new System.Drawing.Size(120, 37);
            this.btnBrowseNewFile.TabIndex = 7;
            this.btnBrowseNewFile.Text = "Choose File";
            this.btnBrowseNewFile.UseVisualStyleBackColor = true;
            this.btnBrowseNewFile.Click += new System.EventHandler(this.btnBrowseNewFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "File path:";
            // 
            // txtNewDBFile
            // 
            this.txtNewDBFile.Location = new System.Drawing.Point(18, 45);
            this.txtNewDBFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewDBFile.Name = "txtNewDBFile";
            this.txtNewDBFile.Size = new System.Drawing.Size(286, 20);
            this.txtNewDBFile.TabIndex = 5;
            // 
            // openFileDial1
            // 
            this.openFileDial1.FileName = "openFileDial1";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 326);
            this.Controls.Add(this.grpBoxOpen);
            this.Controls.Add(this.grpBoxNewDB);
            this.Controls.Add(this.grpBoxWelcome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.grpBoxWelcome.ResumeLayout(false);
            this.grpBoxWelcome.PerformLayout();
            this.grpBoxOpen.ResumeLayout(false);
            this.grpBoxOpen.PerformLayout();
            this.grpBoxNewDB.ResumeLayout(false);
            this.grpBoxNewDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.GroupBox grpBoxWelcome;
        private System.Windows.Forms.RadioButton radOpen;
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.GroupBox grpBoxNewDB;
        private System.Windows.Forms.GroupBox grpBoxOpen;
        private System.Windows.Forms.Button btnOpenBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDial1;
        private System.Windows.Forms.SaveFileDialog saveFileDial1;
        private System.Windows.Forms.Button btnBrowseNewFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewDBFile;
    }
}