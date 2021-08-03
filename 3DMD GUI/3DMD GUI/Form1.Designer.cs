
namespace _3DMD_GUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteThemeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorThemeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteThemeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.darkBlueThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.colorThemeToolStripMenuItem,
            this.colorThemeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openToolStripMenuItem.Text = "Open File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.closeToolStripMenuItem.Text = "Close File";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // colorThemeToolStripMenuItem
            // 
            this.colorThemeToolStripMenuItem.Name = "colorThemeToolStripMenuItem";
            this.colorThemeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // whiteThemeToolStripMenuItem
            // 
            this.whiteThemeToolStripMenuItem.Name = "whiteThemeToolStripMenuItem";
            this.whiteThemeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // whiteThemeToolStripMenuItem1
            // 
            this.whiteThemeToolStripMenuItem1.Name = "whiteThemeToolStripMenuItem1";
            this.whiteThemeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // colorThemeToolStripMenuItem1
            // 
            this.colorThemeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkThemeToolStripMenuItem1,
            this.whiteThemeToolStripMenuItem2,
            this.darkBlueThemeToolStripMenuItem});
            this.colorThemeToolStripMenuItem1.Name = "colorThemeToolStripMenuItem1";
            this.colorThemeToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.colorThemeToolStripMenuItem1.Text = "Color Theme";
            // 
            // darkThemeToolStripMenuItem1
            // 
            this.darkThemeToolStripMenuItem1.Name = "darkThemeToolStripMenuItem1";
            this.darkThemeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.darkThemeToolStripMenuItem1.Text = "Dark Theme";
            this.darkThemeToolStripMenuItem1.Click += new System.EventHandler(this.darkThemeToolStripMenuItem1_Click);
            // 
            // whiteThemeToolStripMenuItem2
            // 
            this.whiteThemeToolStripMenuItem2.Name = "whiteThemeToolStripMenuItem2";
            this.whiteThemeToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.whiteThemeToolStripMenuItem2.Text = "White Theme";
            this.whiteThemeToolStripMenuItem2.Click += new System.EventHandler(this.whiteThemeToolStripMenuItem2_Click);
            // 
            // darkBlueThemeToolStripMenuItem
            // 
            this.darkBlueThemeToolStripMenuItem.Name = "darkBlueThemeToolStripMenuItem";
            this.darkBlueThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkBlueThemeToolStripMenuItem.Text = "Dark-Blue Theme";
            this.darkBlueThemeToolStripMenuItem.Click += new System.EventHandler(this.darkBlueThemeToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DMD GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteThemeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorThemeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem whiteThemeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem darkBlueThemeToolStripMenuItem;
    }
}

