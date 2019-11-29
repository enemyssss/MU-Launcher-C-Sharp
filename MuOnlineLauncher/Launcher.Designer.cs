namespace MuOnlineLauncher
{
    partial class LauncherMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreen800x600 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreen1024x768 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreen1280x1024 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowScreen800x600 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowScreen1024x768 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowScreen1280x1024 = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulgarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.forum = new System.Windows.Forms.Button();
            this.website = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 12);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolutionToolStripMenuItem,
            this.soundToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // resolutionToolStripMenuItem
            // 
            resources.ApplyResources(this.resolutionToolStripMenuItem, "resolutionToolStripMenuItem");
            this.resolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.windowScreenToolStripMenuItem});
            this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            this.resolutionToolStripMenuItem.Click += new System.EventHandler(this.resolutionToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            this.fullScreenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreen800x600,
            this.fullScreen1024x768,
            this.fullScreen1280x1024});
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // fullScreen800x600
            // 
            resources.ApplyResources(this.fullScreen800x600, "fullScreen800x600");
            this.fullScreen800x600.Name = "fullScreen800x600";
            this.fullScreen800x600.Click += new System.EventHandler(this.fullScreen800x600_Click);
            // 
            // fullScreen1024x768
            // 
            resources.ApplyResources(this.fullScreen1024x768, "fullScreen1024x768");
            this.fullScreen1024x768.Name = "fullScreen1024x768";
            this.fullScreen1024x768.Click += new System.EventHandler(this.fullScreen1024x768_Click);
            // 
            // fullScreen1280x1024
            // 
            resources.ApplyResources(this.fullScreen1280x1024, "fullScreen1280x1024");
            this.fullScreen1280x1024.Name = "fullScreen1280x1024";
            this.fullScreen1280x1024.Click += new System.EventHandler(this.fullScreen1280x1024_Click);
            // 
            // windowScreenToolStripMenuItem
            // 
            resources.ApplyResources(this.windowScreenToolStripMenuItem, "windowScreenToolStripMenuItem");
            this.windowScreenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowScreen800x600,
            this.windowScreen1024x768,
            this.windowScreen1280x1024});
            this.windowScreenToolStripMenuItem.Name = "windowScreenToolStripMenuItem";
            this.windowScreenToolStripMenuItem.Click += new System.EventHandler(this.windowScreenToolStripMenuItem_Click);
            // 
            // windowScreen800x600
            // 
            resources.ApplyResources(this.windowScreen800x600, "windowScreen800x600");
            this.windowScreen800x600.Name = "windowScreen800x600";
            this.windowScreen800x600.Click += new System.EventHandler(this.windowScreen800x600_Click);
            // 
            // windowScreen1024x768
            // 
            resources.ApplyResources(this.windowScreen1024x768, "windowScreen1024x768");
            this.windowScreen1024x768.Name = "windowScreen1024x768";
            this.windowScreen1024x768.Click += new System.EventHandler(this.windowScreen1024x768_Click);
            // 
            // windowScreen1280x1024
            // 
            resources.ApplyResources(this.windowScreen1280x1024, "windowScreen1280x1024");
            this.windowScreen1280x1024.Name = "windowScreen1280x1024";
            this.windowScreen1280x1024.Click += new System.EventHandler(this.windowScreen1280x1024_Click);
            // 
            // soundToolStripMenuItem
            // 
            resources.ApplyResources(this.soundToolStripMenuItem, "soundToolStripMenuItem");
            this.soundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            // 
            // onToolStripMenuItem
            // 
            resources.ApplyResources(this.onToolStripMenuItem, "onToolStripMenuItem");
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            resources.ApplyResources(this.offToolStripMenuItem, "offToolStripMenuItem");
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.bulgarianToolStripMenuItem,
            this.spanishToolStripMenuItem,
            this.russianToolStripMenuItem,
            this.polishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.LanguageToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // bulgarianToolStripMenuItem
            // 
            resources.ApplyResources(this.bulgarianToolStripMenuItem, "bulgarianToolStripMenuItem");
            this.bulgarianToolStripMenuItem.Name = "bulgarianToolStripMenuItem";
            this.bulgarianToolStripMenuItem.Click += new System.EventHandler(this.bulgarianToolStripMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            resources.ApplyResources(this.spanishToolStripMenuItem, "spanishToolStripMenuItem");
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // polishToolStripMenuItem
            // 
            resources.ApplyResources(this.polishToolStripMenuItem, "polishToolStripMenuItem");
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            this.polishToolStripMenuItem.Click += new System.EventHandler(this.PolishToolStripMenuItem_Click);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Name = "close";
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // play
            // 
            resources.ApplyResources(this.play, "play");
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.play.Name = "play";
            this.play.TabStop = false;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // forum
            // 
            resources.ApplyResources(this.forum, "forum");
            this.forum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.forum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.forum.Name = "forum";
            this.forum.TabStop = false;
            this.forum.UseVisualStyleBackColor = false;
            this.forum.Click += new System.EventHandler(this.forum_Click);
            // 
            // website
            // 
            resources.ApplyResources(this.website, "website");
            this.website.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.website.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.website.Name = "website";
            this.website.TabStop = false;
            this.website.UseVisualStyleBackColor = false;
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // LauncherMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.forum);
            this.Controls.Add(this.website);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.play);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LauncherMenu";
            this.Load += new System.EventHandler(this.Launcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreen800x600;
        private System.Windows.Forms.ToolStripMenuItem fullScreen1024x768;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreen1280x1024;
        private System.Windows.Forms.ToolStripMenuItem windowScreen800x600;
        private System.Windows.Forms.ToolStripMenuItem windowScreen1024x768;
        private System.Windows.Forms.ToolStripMenuItem windowScreen1280x1024;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulgarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.Button forum;
        private System.Windows.Forms.Button website;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Button play;
        public System.Windows.Forms.Button close;
    }
}

