namespace MonoRank.Forms
{
    partial class SignInDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInDlg));
            this.id = new System.Windows.Forms.TextBox();
            this.pwd1 = new System.Windows.Forms.TextBox();
            this.pwd2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.findq = new System.Windows.Forms.TextBox();
            this.finda = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(224, 151);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(173, 21);
            this.id.TabIndex = 8;
            // 
            // pwd1
            // 
            this.pwd1.Location = new System.Drawing.Point(224, 176);
            this.pwd1.Name = "pwd1";
            this.pwd1.PasswordChar = '*';
            this.pwd1.Size = new System.Drawing.Size(173, 21);
            this.pwd1.TabIndex = 9;
            // 
            // pwd2
            // 
            this.pwd2.Location = new System.Drawing.Point(224, 202);
            this.pwd2.Name = "pwd2";
            this.pwd2.PasswordChar = '*';
            this.pwd2.Size = new System.Drawing.Size(173, 21);
            this.pwd2.TabIndex = 10;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(224, 229);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(173, 21);
            this.name.TabIndex = 11;
            // 
            // findq
            // 
            this.findq.Location = new System.Drawing.Point(224, 256);
            this.findq.Name = "findq";
            this.findq.Size = new System.Drawing.Size(173, 21);
            this.findq.TabIndex = 12;
            // 
            // finda
            // 
            this.finda.Location = new System.Drawing.Point(224, 283);
            this.finda.Name = "finda";
            this.finda.Size = new System.Drawing.Size(173, 21);
            this.finda.TabIndex = 13;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(224, 309);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(173, 21);
            this.contact.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(174, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "format(010-xxxx-xxxx/011-xxx-xxxx)";
            // 
            // signin
            // 
            this.signin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signin.BackgroundImage")));
            this.signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin.Location = new System.Drawing.Point(173, 381);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(85, 31);
            this.signin.TabIndex = 17;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // SignInDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 503);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.finda);
            this.Controls.Add(this.findq);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pwd2);
            this.Controls.Add(this.pwd1);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignInDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pwd1;
        private System.Windows.Forms.TextBox pwd2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox findq;
        private System.Windows.Forms.TextBox finda;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel signin;
    }
}