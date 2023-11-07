using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoRank.org.monorank.vo;

namespace MonoRank.Forms
{
    public partial class PwdQuestion : Form
    {
        private MemberVO que;
        public PwdQuestion()
        {
            InitializeComponent();
        }
        public PwdQuestion(MemberVO qinfo) : this()
        {
            que = qinfo;
            question.Text = que.Findq;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string ipanswer = answer.Text.ToString();
            if (ipanswer.Equals("")) MessageBox.Show("답변을 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (ipanswer.Equals(que.Finda)) MessageBox.Show($"비밀번호는 {que.Pwd}입니다.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("답변이 틀렸습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }
    }
}