namespace MonoRank.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.profile = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Panel();
            this.setting = new System.Windows.Forms.Panel();
            this.game = new System.Windows.Forms.Panel();
            this.ranking = new System.Windows.Forms.Panel();
            this.profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(203, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 48);
            this.panel1.TabIndex = 0;
            // 
            // profile
            // 
            this.profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile.BackgroundImage")));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile.Controls.Add(this.username);
            this.profile.Controls.Add(this.logout);
            this.profile.Location = new System.Drawing.Point(511, 54);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(232, 244);
            this.profile.TabIndex = 1;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.username.Location = new System.Drawing.Point(15, 151);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(201, 15);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Location = new System.Drawing.Point(80, 194);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(69, 23);
            this.logout.TabIndex = 0;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // setting
            // 
            this.setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setting.BackgroundImage")));
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting.Location = new System.Drawing.Point(168, 351);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(107, 187);
            this.setting.TabIndex = 2;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            this.setting.MouseLeave += new System.EventHandler(this.setting_MouseLeave);
            this.setting.MouseHover += new System.EventHandler(this.setting_MouseHover);
            // 
            // game
            // 
            this.game.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("game.BackgroundImage")));
            this.game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game.Location = new System.Drawing.Point(479, 351);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(107, 187);
            this.game.TabIndex = 3;
            this.game.Click += new System.EventHandler(this.game_Click);
            this.game.MouseLeave += new System.EventHandler(this.game_MouseLeave);
            this.game.MouseHover += new System.EventHandler(this.game_MouseHover);
            // 
            // ranking
            // 
            this.ranking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ranking.BackgroundImage")));
            this.ranking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ranking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ranking.Location = new System.Drawing.Point(686, 351);
            this.ranking.Name = "ranking";
            this.ranking.Size = new System.Drawing.Size(107, 187);
            this.ranking.TabIndex = 4;
            this.ranking.Click += new System.EventHandler(this.ranking_Click);
            this.ranking.MouseLeave += new System.EventHandler(this.ranking_MouseLeave);
            this.ranking.MouseHover += new System.EventHandler(this.ranking_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.ranking);
            this.Controls.Add(this.game);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonoRank";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.profile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel profile;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel logout;
        private System.Windows.Forms.Panel setting;
        private System.Windows.Forms.Panel game;
        private System.Windows.Forms.Panel ranking;
    }
}