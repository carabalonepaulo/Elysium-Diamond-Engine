﻿namespace LoginServer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.file_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableLogin_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearsec_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSList_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadVersion_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config_TabPage = new System.Windows.Forms.TabControl();
            this.general_TabPage = new System.Windows.Forms.TabPage();
            this.general_textbox = new System.Windows.Forms.RichTextBox();
            this.trm_cleartext = new System.Windows.Forms.Timer(this.components);
            this.trm_showfps = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.config_TabPage.SuspendLayout();
            this.general_TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_MenuItem,
            this.manutençãoToolStripMenuItem,
            this.config_MenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(565, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // file_MenuItem
            // 
            this.file_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.min_MenuItem,
            this.quit_MenuItem});
            this.file_MenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_MenuItem.Name = "file_MenuItem";
            this.file_MenuItem.Size = new System.Drawing.Size(40, 20);
            this.file_MenuItem.Text = "File";
            // 
            // min_MenuItem
            // 
            this.min_MenuItem.Name = "min_MenuItem";
            this.min_MenuItem.Size = new System.Drawing.Size(127, 22);
            this.min_MenuItem.Text = "Minimize";
            this.min_MenuItem.Click += new System.EventHandler(this.min_MenuItem_Click);
            // 
            // quit_MenuItem
            // 
            this.quit_MenuItem.Name = "quit_MenuItem";
            this.quit_MenuItem.Size = new System.Drawing.Size(127, 22);
            this.quit_MenuItem.Text = "Exit";
            this.quit_MenuItem.Click += new System.EventHandler(this.quit_MenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableLogin_MenuItem});
            this.manutençãoToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.manutençãoToolStripMenuItem.Text = "Maintenance";
            // 
            // disableLogin_MenuItem
            // 
            this.disableLogin_MenuItem.CheckOnClick = true;
            this.disableLogin_MenuItem.Name = "disableLogin_MenuItem";
            this.disableLogin_MenuItem.Size = new System.Drawing.Size(208, 22);
            this.disableLogin_MenuItem.Text = "Disable login attempt";
            this.disableLogin_MenuItem.Click += new System.EventHandler(this.disableLogin_MenuItem_Click);
            // 
            // config_MenuItem
            // 
            this.config_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clear_MenuItem,
            this.reloadSList_MenuItem,
            this.reloadVersion_MenuItem});
            this.config_MenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config_MenuItem.Name = "config_MenuItem";
            this.config_MenuItem.Size = new System.Drawing.Size(104, 20);
            this.config_MenuItem.Text = "Configuration";
            // 
            // clear_MenuItem
            // 
            this.clear_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearsec_MenuItem});
            this.clear_MenuItem.Name = "clear_MenuItem";
            this.clear_MenuItem.Size = new System.Drawing.Size(217, 22);
            this.clear_MenuItem.Text = "Clear screen";
            this.clear_MenuItem.Click += new System.EventHandler(this.clear_MenuItem_Click);
            // 
            // clearsec_MenuItem
            // 
            this.clearsec_MenuItem.Name = "clearsec_MenuItem";
            this.clearsec_MenuItem.Size = new System.Drawing.Size(185, 22);
            this.clearsec_MenuItem.Text = "Every 30 seconds";
            this.clearsec_MenuItem.Click += new System.EventHandler(this.clearsec_MenuItem_Click);
            // 
            // reloadSList_MenuItem
            // 
            this.reloadSList_MenuItem.Name = "reloadSList_MenuItem";
            this.reloadSList_MenuItem.Size = new System.Drawing.Size(217, 22);
            this.reloadSList_MenuItem.Text = "Reload world sever list";
            this.reloadSList_MenuItem.Click += new System.EventHandler(this.reload_MenuItem_Click);
            // 
            // reloadVersion_MenuItem
            // 
            this.reloadVersion_MenuItem.Name = "reloadVersion_MenuItem";
            this.reloadVersion_MenuItem.Size = new System.Drawing.Size(217, 22);
            this.reloadVersion_MenuItem.Text = "Reload version";
            this.reloadVersion_MenuItem.Click += new System.EventHandler(this.reloadVersion_MenuItem_Click);
            // 
            // config_TabPage
            // 
            this.config_TabPage.Controls.Add(this.general_TabPage);
            this.config_TabPage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config_TabPage.Location = new System.Drawing.Point(16, 33);
            this.config_TabPage.Name = "config_TabPage";
            this.config_TabPage.SelectedIndex = 0;
            this.config_TabPage.Size = new System.Drawing.Size(537, 345);
            this.config_TabPage.TabIndex = 1;
            // 
            // general_TabPage
            // 
            this.general_TabPage.BackColor = System.Drawing.SystemColors.Control;
            this.general_TabPage.Controls.Add(this.general_textbox);
            this.general_TabPage.Location = new System.Drawing.Point(4, 23);
            this.general_TabPage.Name = "general_TabPage";
            this.general_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.general_TabPage.Size = new System.Drawing.Size(529, 318);
            this.general_TabPage.TabIndex = 0;
            this.general_TabPage.Text = "General";
            // 
            // general_textbox
            // 
            this.general_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.general_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.general_textbox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.general_textbox.Location = new System.Drawing.Point(3, 3);
            this.general_textbox.Name = "general_textbox";
            this.general_textbox.ReadOnly = true;
            this.general_textbox.Size = new System.Drawing.Size(523, 312);
            this.general_textbox.TabIndex = 0;
            this.general_textbox.Text = "";
            // 
            // trm_cleartext
            // 
            this.trm_cleartext.Interval = 30000;
            this.trm_cleartext.Tick += new System.EventHandler(this.trm_cleartext_Tick);
            // 
            // trm_showfps
            // 
            this.trm_showfps.Enabled = true;
            this.trm_showfps.Interval = 850;
            this.trm_showfps.Tick += new System.EventHandler(this.trm_showfps_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.config_TabPage);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Server @ 0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.config_TabPage.ResumeLayout(false);
            this.general_TabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem file_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem min_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem quit_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem config_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSList_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem clear_MenuItem;
        private System.Windows.Forms.TabControl config_TabPage;
        private System.Windows.Forms.TabPage general_TabPage;
        public System.Windows.Forms.RichTextBox general_textbox;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableLogin_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadVersion_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearsec_MenuItem;
        private System.Windows.Forms.Timer trm_cleartext;
        private System.Windows.Forms.Timer trm_showfps;
    }
}

