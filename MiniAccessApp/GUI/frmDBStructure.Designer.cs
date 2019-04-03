namespace MiniAccessApp.GUI
{
    partial class frmDBStructure
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
            this.lstDBStruc = new System.Windows.Forms.ListBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDBStruc
            // 
            this.lstDBStruc.FormattingEnabled = true;
            this.lstDBStruc.ItemHeight = 25;
            this.lstDBStruc.Location = new System.Drawing.Point(12, 74);
            this.lstDBStruc.Name = "lstDBStruc";
            this.lstDBStruc.Size = new System.Drawing.Size(1217, 404);
            this.lstDBStruc.TabIndex = 0;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(182, 12);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(1047, 31);
            this.txtDB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DataBase:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1048, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDBStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 553);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.lstDBStruc);
            this.Name = "frmDBStructure";
            this.Text = "frmDBStructure";
            this.Load += new System.EventHandler(this.frmDBStructure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDBStruc;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}