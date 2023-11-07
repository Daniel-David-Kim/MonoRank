namespace MonoRank.Forms
{
    partial class SelectGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectGame));
            this.logout = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Panel();
            this.eatcookie = new System.Windows.Forms.Panel();
            this.assaultcraft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.housepanel = new System.Windows.Forms.Panel();
            this.userpanel = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Location = new System.Drawing.Point(194, 91);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(81, 23);
            this.logout.TabIndex = 7;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(921, 23);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(27, 49);
            this.back.TabIndex = 6;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // eatcookie
            // 
            this.eatcookie.BackColor = System.Drawing.Color.Transparent;
            this.eatcookie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eatcookie.BackgroundImage")));
            this.eatcookie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eatcookie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eatcookie.Location = new System.Drawing.Point(480, 250);
            this.eatcookie.Name = "eatcookie";
            this.eatcookie.Size = new System.Drawing.Size(231, 291);
            this.eatcookie.TabIndex = 5;
            this.eatcookie.Click += new System.EventHandler(this.eatcookie_Click);
            this.eatcookie.MouseLeave += new System.EventHandler(this.eatcookie_MouseLeave);
            this.eatcookie.MouseHover += new System.EventHandler(this.eatcookie_MouseHover);
            // 
            // assaultcraft
            // 
            this.assaultcraft.BackColor = System.Drawing.Color.Transparent;
            this.assaultcraft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("assaultcraft.BackgroundImage")));
            this.assaultcraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.assaultcraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assaultcraft.Location = new System.Drawing.Point(242, 250);
            this.assaultcraft.Name = "assaultcraft";
            this.assaultcraft.Size = new System.Drawing.Size(232, 291);
            this.assaultcraft.TabIndex = 4;
            this.assaultcraft.Click += new System.EventHandler(this.assaultcraft_Click);
            this.assaultcraft.MouseLeave += new System.EventHandler(this.assaultcraft_MouseLeave);
            this.assaultcraft.MouseHover += new System.EventHandler(this.assaultcraft_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 59);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.userpanel);
            this.panel2.Controls.Add(this.housepanel);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Location = new System.Drawing.Point(587, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 134);
            this.panel2.TabIndex = 9;
            // 
            // housepanel
            // 
            this.housepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("housepanel.BackgroundImage")));
            this.housepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.housepanel.Location = new System.Drawing.Point(36, 30);
            this.housepanel.Name = "housepanel";
            this.housepanel.Size = new System.Drawing.Size(73, 72);
            this.housepanel.TabIndex = 10;
            // 
            // userpanel
            // 
            this.userpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userpanel.BackgroundImage")));
            this.userpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userpanel.Location = new System.Drawing.Point(115, 12);
            this.userpanel.Name = "userpanel";
            this.userpanel.Size = new System.Drawing.Size(86, 33);
            this.userpanel.TabIndex = 10;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.username.Location = new System.Drawing.Point(115, 51);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(175, 34);
            this.username.TabIndex = 11;
            this.username.Text = "label1";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.eatcookie);
            this.Controls.Add(this.assaultcraft);
            this.DoubleBuffered = true;
            this.Name = "SelectGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Game";
            this.Load += new System.EventHandler(this.SelectGame_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logout;
        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Panel eatcookie;
        private System.Windows.Forms.Panel assaultcraft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel userpanel;
        private System.Windows.Forms.Panel housepanel;
        private System.Windows.Forms.Label username;
    }
}