
namespace WindowsFormsApp1
{
    partial class fr_MP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_MP3));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grlist = new System.Windows.Forms.GroupBox();
            this.gr_media = new System.Windows.Forms.GroupBox();
            this.lst_nhac = new System.Windows.Forms.ListView();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grlist.SuspendLayout();
            this.gr_media.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(696, 388);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mP3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mP3ToolStripMenuItem
            // 
            this.mP3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveListToolStripMenuItem,
            this.loadPlayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mP3ToolStripMenuItem.Name = "mP3ToolStripMenuItem";
            this.mP3ToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.mP3ToolStripMenuItem.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // grlist
            // 
            this.grlist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grlist.Controls.Add(this.lst_nhac);
            this.grlist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grlist.Location = new System.Drawing.Point(726, 52);
            this.grlist.Name = "grlist";
            this.grlist.Size = new System.Drawing.Size(317, 511);
            this.grlist.TabIndex = 2;
            this.grlist.TabStop = false;
            this.grlist.Text = "List Nhạc";
            // 
            // gr_media
            // 
            this.gr_media.Controls.Add(this.axWindowsMediaPlayer1);
            this.gr_media.Location = new System.Drawing.Point(12, 52);
            this.gr_media.Name = "gr_media";
            this.gr_media.Size = new System.Drawing.Size(708, 511);
            this.gr_media.TabIndex = 3;
            this.gr_media.TabStop = false;
            // 
            // lst_nhac
            // 
            this.lst_nhac.HideSelection = false;
            this.lst_nhac.Location = new System.Drawing.Point(6, 17);
            this.lst_nhac.Name = "lst_nhac";
            this.lst_nhac.Size = new System.Drawing.Size(305, 484);
            this.lst_nhac.TabIndex = 0;
            this.lst_nhac.UseCompatibleStateImageBehavior = false;
            this.lst_nhac.View = System.Windows.Forms.View.List;
            this.lst_nhac.SelectedIndexChanged += new System.EventHandler(this.lst_nhac_SelectedIndexChanged);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveListToolStripMenuItem.Text = "Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // loadPlayToolStripMenuItem
            // 
            this.loadPlayToolStripMenuItem.Name = "loadPlayToolStripMenuItem";
            this.loadPlayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadPlayToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadPlayToolStripMenuItem.Text = "Load Play";
            this.loadPlayToolStripMenuItem.Click += new System.EventHandler(this.loadPlayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fr_MP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1055, 575);
            this.Controls.Add(this.gr_media);
            this.Controls.Add(this.grlist);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1073, 622);
            this.MinimumSize = new System.Drawing.Size(1073, 622);
            this.Name = "fr_MP3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_MP3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grlist.ResumeLayout(false);
            this.gr_media.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mP3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox grlist;
        private System.Windows.Forms.GroupBox gr_media;
        private System.Windows.Forms.ListView lst_nhac;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

