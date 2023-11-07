namespace MonoRank.Forms
{
    partial class PwdQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwdQuestion));
            this.question = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.BackColor = System.Drawing.Color.Transparent;
            this.question.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.question.Location = new System.Drawing.Point(37, 98);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(41, 16);
            this.question.TabIndex = 0;
            this.question.Text = "label1";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(39, 127);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(199, 21);
            this.answer.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm.BackgroundImage")));
            this.confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.Location = new System.Drawing.Point(174, 165);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(64, 23);
            this.confirm.TabIndex = 3;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // PwdQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 219);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.question);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PwdQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 찾기 질문";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Panel confirm;
    }
}