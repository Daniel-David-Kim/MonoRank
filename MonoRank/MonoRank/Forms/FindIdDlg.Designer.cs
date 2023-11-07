namespace MonoRank.Forms
{
    partial class FindIdDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindIdDlg));
            this.name = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Panel();
            this.findpw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(174, 356);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(182, 21);
            this.name.TabIndex = 4;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(174, 395);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(182, 21);
            this.contact.TabIndex = 5;
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Transparent;
            this.find.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("find.BackgroundImage")));
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find.Location = new System.Drawing.Point(89, 450);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(66, 32);
            this.find.TabIndex = 6;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // findpw
            // 
            this.findpw.BackColor = System.Drawing.Color.Transparent;
            this.findpw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findpw.BackgroundImage")));
            this.findpw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findpw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findpw.Location = new System.Drawing.Point(226, 450);
            this.findpw.Name = "findpw";
            this.findpw.Size = new System.Drawing.Size(106, 36);
            this.findpw.TabIndex = 7;
            this.findpw.Click += new System.EventHandler(this.findpw_Click);
            // 
            // FindIdDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 587);
            this.Controls.Add(this.findpw);
            this.Controls.Add(this.find);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindIdDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Id";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Panel find;
        private System.Windows.Forms.Panel findpw;
    }
}