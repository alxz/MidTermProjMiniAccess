namespace MiniAccessApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMainFrm = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDBItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDBItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitMainFrmItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDial1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDial1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMainFrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainFrm
            // 
            this.menuStripMainFrm.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripMainFrm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStripMainFrm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainFrm.Name = "menuStripMainFrm";
            this.menuStripMainFrm.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStripMainFrm.Size = new System.Drawing.Size(669, 24);
            this.menuStripMainFrm.TabIndex = 1;
            this.menuStripMainFrm.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDBItem,
            this.openDBItem,
            this.toolStripSeparator1,
            this.quitMainFrmItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // newDBItem
            // 
            this.newDBItem.Name = "newDBItem";
            this.newDBItem.Size = new System.Drawing.Size(163, 22);
            this.newDBItem.Text = "New Database...";
            this.newDBItem.Click += new System.EventHandler(this.newDBItem_Click);
            // 
            // openDBItem
            // 
            this.openDBItem.Name = "openDBItem";
            this.openDBItem.Size = new System.Drawing.Size(163, 22);
            this.openDBItem.Text = "Open Database...";
            this.openDBItem.Click += new System.EventHandler(this.openDBItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // quitMainFrmItem
            // 
            this.quitMainFrmItem.Name = "quitMainFrmItem";
            this.quitMainFrmItem.Size = new System.Drawing.Size(163, 22);
            this.quitMainFrmItem.Text = "Quit";
            this.quitMainFrmItem.Click += new System.EventHandler(this.quitMainFrmItem_Click);
            // 
            // openFileDial1
            // 
            this.openFileDial1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 328);
            this.Controls.Add(this.menuStripMainFrm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMainFrm;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMainFrm.ResumeLayout(false);
            this.menuStripMainFrm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainFrm;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDBItem;
        private System.Windows.Forms.ToolStripMenuItem openDBItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitMainFrmItem;
        private System.Windows.Forms.OpenFileDialog openFileDial1;
        private System.Windows.Forms.SaveFileDialog saveFileDial1;
    }
}

