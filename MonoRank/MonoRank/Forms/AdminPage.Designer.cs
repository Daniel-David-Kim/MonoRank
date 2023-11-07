namespace MonoRank.Forms
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.members = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runcookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spacewar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.members)).BeginInit();
            this.SuspendLayout();
            // 
            // members
            // 
            this.members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pwd,
            this.name,
            this.findq,
            this.finda,
            this.contact,
            this.admin,
            this.runcookie,
            this.spacewar});
            this.members.Location = new System.Drawing.Point(96, 101);
            this.members.MultiSelect = false;
            this.members.Name = "members";
            this.members.ReadOnly = true;
            this.members.RowTemplate.Height = 23;
            this.members.Size = new System.Drawing.Size(769, 257);
            this.members.TabIndex = 0;
            this.members.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.members_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "아이디";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // pwd
            // 
            this.pwd.HeaderText = "비밀번호";
            this.pwd.Name = "pwd";
            this.pwd.ReadOnly = true;
            this.pwd.Width = 80;
            // 
            // name
            // 
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 65;
            // 
            // findq
            // 
            this.findq.HeaderText = "비밀번호 질문";
            this.findq.Name = "findq";
            this.findq.ReadOnly = true;
            this.findq.Width = 110;
            // 
            // finda
            // 
            this.finda.HeaderText = "비밀번호 답";
            this.finda.Name = "finda";
            this.finda.ReadOnly = true;
            this.finda.Width = 110;
            // 
            // contact
            // 
            this.contact.HeaderText = "연락처";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Width = 110;
            // 
            // admin
            // 
            this.admin.HeaderText = "운영자";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            this.admin.Width = 70;
            // 
            // runcookie
            // 
            this.runcookie.HeaderText = "런닝";
            this.runcookie.Name = "runcookie";
            this.runcookie.ReadOnly = true;
            this.runcookie.Width = 55;
            // 
            // spacewar
            // 
            this.spacewar.HeaderText = "슈팅";
            this.spacewar.Name = "spacewar";
            this.spacewar.ReadOnly = true;
            this.spacewar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.spacewar.Width = 55;
            // 
            // insert
            // 
            this.insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insert.BackgroundImage")));
            this.insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insert.Location = new System.Drawing.Point(96, 364);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(114, 50);
            this.insert.TabIndex = 1;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.update.Location = new System.Drawing.Point(312, 364);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(114, 50);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delete.Location = new System.Drawing.Point(531, 364);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 50);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.back.Location = new System.Drawing.Point(751, 364);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(114, 50);
            this.back.TabIndex = 4;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.members)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView members;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn findq;
        private System.Windows.Forms.DataGridViewTextBoxColumn finda;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn runcookie;
        private System.Windows.Forms.DataGridViewTextBoxColumn spacewar;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
    }
}