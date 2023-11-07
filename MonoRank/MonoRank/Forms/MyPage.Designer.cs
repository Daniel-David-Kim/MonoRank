namespace MonoRank.Forms
{
    partial class MyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPage));
            this.contact = new System.Windows.Forms.TextBox();
            this.finda = new System.Windows.Forms.TextBox();
            this.findq = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.pwd2 = new System.Windows.Forms.TextBox();
            this.pwd1 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(271, 426);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(180, 21);
            this.contact.TabIndex = 29;
            // 
            // finda
            // 
            this.finda.Location = new System.Drawing.Point(271, 394);
            this.finda.Name = "finda";
            this.finda.Size = new System.Drawing.Size(180, 21);
            this.finda.TabIndex = 28;
            // 
            // findq
            // 
            this.findq.Location = new System.Drawing.Point(271, 361);
            this.findq.Name = "findq";
            this.findq.Size = new System.Drawing.Size(180, 21);
            this.findq.TabIndex = 27;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(271, 330);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(180, 21);
            this.name.TabIndex = 26;
            // 
            // pwd2
            // 
            this.pwd2.Location = new System.Drawing.Point(271, 298);
            this.pwd2.Name = "pwd2";
            this.pwd2.PasswordChar = '*';
            this.pwd2.Size = new System.Drawing.Size(180, 21);
            this.pwd2.TabIndex = 25;
            // 
            // pwd1
            // 
            this.pwd1.Location = new System.Drawing.Point(271, 267);
            this.pwd1.Name = "pwd1";
            this.pwd1.PasswordChar = '*';
            this.pwd1.Size = new System.Drawing.Size(180, 21);
            this.pwd1.TabIndex = 24;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(271, 234);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(180, 21);
            this.id.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(135, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 35);
            this.panel1.TabIndex = 30;
            this.panel1.Click += new System.EventHandler(this.update_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(301, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 33);
            this.panel2.TabIndex = 31;
            this.panel2.Click += new System.EventHandler(this.back_Click);
            // 
            // MyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.finda);
            this.Controls.Add(this.findq);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pwd2);
            this.Controls.Add(this.pwd1);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPage";
            this.Load += new System.EventHandler(this.MyPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox finda;
        private System.Windows.Forms.TextBox findq;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pwd2;
        private System.Windows.Forms.TextBox pwd1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}