namespace MonoRank.Forms
{
    partial class Ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            this.rank1 = new System.Windows.Forms.Label();
            this.rank2 = new System.Windows.Forms.Label();
            this.rank3 = new System.Windows.Forms.Label();
            this.rank4 = new System.Windows.Forms.Label();
            this.myrank = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rank1
            // 
            this.rank1.AutoSize = true;
            this.rank1.BackColor = System.Drawing.Color.Transparent;
            this.rank1.Font = new System.Drawing.Font("함초롬돋움", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rank1.ForeColor = System.Drawing.Color.White;
            this.rank1.Location = new System.Drawing.Point(266, 296);
            this.rank1.Name = "rank1";
            this.rank1.Size = new System.Drawing.Size(77, 30);
            this.rank1.TabIndex = 0;
            this.rank1.Text = "label1";
            // 
            // rank2
            // 
            this.rank2.AutoSize = true;
            this.rank2.BackColor = System.Drawing.Color.Transparent;
            this.rank2.Font = new System.Drawing.Font("함초롬돋움", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rank2.ForeColor = System.Drawing.Color.White;
            this.rank2.Location = new System.Drawing.Point(266, 362);
            this.rank2.Name = "rank2";
            this.rank2.Size = new System.Drawing.Size(77, 30);
            this.rank2.TabIndex = 1;
            this.rank2.Text = "label2";
            // 
            // rank3
            // 
            this.rank3.AutoSize = true;
            this.rank3.BackColor = System.Drawing.Color.Transparent;
            this.rank3.Font = new System.Drawing.Font("함초롬돋움", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rank3.ForeColor = System.Drawing.Color.White;
            this.rank3.Location = new System.Drawing.Point(266, 428);
            this.rank3.Name = "rank3";
            this.rank3.Size = new System.Drawing.Size(77, 30);
            this.rank3.TabIndex = 2;
            this.rank3.Text = "label3";
            // 
            // rank4
            // 
            this.rank4.AutoSize = true;
            this.rank4.BackColor = System.Drawing.Color.Transparent;
            this.rank4.Font = new System.Drawing.Font("함초롬돋움", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rank4.ForeColor = System.Drawing.Color.White;
            this.rank4.Location = new System.Drawing.Point(266, 492);
            this.rank4.Name = "rank4";
            this.rank4.Size = new System.Drawing.Size(77, 30);
            this.rank4.TabIndex = 3;
            this.rank4.Text = "label4";
            // 
            // myrank
            // 
            this.myrank.BackColor = System.Drawing.Color.Transparent;
            this.myrank.Font = new System.Drawing.Font("함초롬돋움", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myrank.ForeColor = System.Drawing.Color.White;
            this.myrank.Location = new System.Drawing.Point(1, 612);
            this.myrank.Name = "myrank";
            this.myrank.Size = new System.Drawing.Size(510, 27);
            this.myrank.TabIndex = 4;
            this.myrank.Text = "label5";
            this.myrank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(255, 238);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(130, 20);
            this.category.TabIndex = 5;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(440, 44);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(22, 33);
            this.back.TabIndex = 6;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 820);
            this.Controls.Add(this.back);
            this.Controls.Add(this.category);
            this.Controls.Add(this.myrank);
            this.Controls.Add(this.rank4);
            this.Controls.Add(this.rank3);
            this.Controls.Add(this.rank2);
            this.Controls.Add(this.rank1);
            this.DoubleBuffered = true;
            this.Name = "Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rank1;
        private System.Windows.Forms.Label rank2;
        private System.Windows.Forms.Label rank3;
        private System.Windows.Forms.Label rank4;
        private System.Windows.Forms.Label myrank;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Panel back;
    }
}