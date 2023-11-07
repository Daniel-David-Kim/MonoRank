namespace MonoRank.Forms
{
    partial class InputEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputEditForm));
            this.id = new System.Windows.Forms.TextBox();
            this.pwd1 = new System.Windows.Forms.TextBox();
            this.pwd2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.findq = new System.Windows.Forms.TextBox();
            this.finda = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.TextBox();
            this.eatcookie = new System.Windows.Forms.TextBox();
            this.assaultcraft = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(286, 180);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(170, 21);
            this.id.TabIndex = 9;
            // 
            // pwd1
            // 
            this.pwd1.Location = new System.Drawing.Point(286, 207);
            this.pwd1.Name = "pwd1";
            this.pwd1.PasswordChar = '*';
            this.pwd1.Size = new System.Drawing.Size(170, 21);
            this.pwd1.TabIndex = 10;
            // 
            // pwd2
            // 
            this.pwd2.Location = new System.Drawing.Point(286, 236);
            this.pwd2.Name = "pwd2";
            this.pwd2.PasswordChar = '*';
            this.pwd2.Size = new System.Drawing.Size(170, 21);
            this.pwd2.TabIndex = 11;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(286, 266);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(170, 21);
            this.name.TabIndex = 12;
            // 
            // findq
            // 
            this.findq.Location = new System.Drawing.Point(286, 295);
            this.findq.Name = "findq";
            this.findq.Size = new System.Drawing.Size(170, 21);
            this.findq.TabIndex = 13;
            // 
            // finda
            // 
            this.finda.Location = new System.Drawing.Point(286, 324);
            this.finda.Name = "finda";
            this.finda.Size = new System.Drawing.Size(170, 21);
            this.finda.TabIndex = 14;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(286, 356);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(170, 21);
            this.contact.TabIndex = 15;
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(286, 385);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(170, 21);
            this.admin.TabIndex = 16;
            this.admin.Text = "0";
            // 
            // eatcookie
            // 
            this.eatcookie.Location = new System.Drawing.Point(286, 414);
            this.eatcookie.Name = "eatcookie";
            this.eatcookie.Size = new System.Drawing.Size(170, 21);
            this.eatcookie.TabIndex = 17;
            this.eatcookie.Text = "0";
            // 
            // assaultcraft
            // 
            this.assaultcraft.Location = new System.Drawing.Point(286, 444);
            this.assaultcraft.Name = "assaultcraft";
            this.assaultcraft.Size = new System.Drawing.Size(170, 21);
            this.assaultcraft.TabIndex = 19;
            this.assaultcraft.Text = "0";
            // 
            // submit
            // 
            this.submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit.BackgroundImage")));
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submit.Location = new System.Drawing.Point(219, 519);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(78, 27);
            this.submit.TabIndex = 20;
            this.submit.Click += new System.EventHandler(this.button_Click);
            // 
            // InputEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 675);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.assaultcraft);
            this.Controls.Add(this.eatcookie);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.finda);
            this.Controls.Add(this.findq);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pwd2);
            this.Controls.Add(this.pwd1);
            this.Controls.Add(this.id);
            this.Name = "InputEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputEditForm";
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
        private System.Windows.Forms.TextBox admin;
        private System.Windows.Forms.TextBox eatcookie;
        private System.Windows.Forms.TextBox assaultcraft;
        private System.Windows.Forms.Panel submit;
    }
}