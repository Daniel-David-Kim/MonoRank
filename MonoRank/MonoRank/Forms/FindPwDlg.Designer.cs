namespace MonoRank.Forms
{
    partial class FindPwDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindPwDlg));
            this.id = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Panel();
            this.findid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(174, 372);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(162, 21);
            this.id.TabIndex = 1;
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Transparent;
            this.find.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("find.BackgroundImage")));
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find.Location = new System.Drawing.Point(88, 445);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(77, 38);
            this.find.TabIndex = 2;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // findid
            // 
            this.findid.BackColor = System.Drawing.Color.Transparent;
            this.findid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findid.BackgroundImage")));
            this.findid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findid.Location = new System.Drawing.Point(228, 447);
            this.findid.Name = "findid";
            this.findid.Size = new System.Drawing.Size(97, 38);
            this.findid.TabIndex = 3;
            this.findid.Click += new System.EventHandler(this.findid_Click);
            // 
            // FindPwDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 587);
            this.Controls.Add(this.findid);
            this.Controls.Add(this.find);
            this.Controls.Add(this.id);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindPwDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindPwDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Panel find;
        private System.Windows.Forms.Panel findid;
    }
}