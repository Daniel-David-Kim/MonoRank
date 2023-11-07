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
using MonoRank.org.monorank.common;
using MonoRank.org.monorank.controller;

namespace MonoRank.Forms
{
    public partial class MyPage : Form
    {
        private Arbiter arbiter;
        private List<TextBox> list;
        private List<string> values;
        public MyPage()
        {
            InitializeComponent();
        }
        public MyPage(Arbiter arbiter) : this()
        {
            this.arbiter = arbiter;
            list = new List<TextBox>() { id, pwd1, pwd2, name, findq, finda, contact };
            MemberVO info = arbiter.User;
            values = new List<string>() { info.Id, info.Pwd, info.Pwd, info.Name, info.Findq, info.Finda, info.Contact };
            for (int i = 0; i < list.Count; i++) list[i].Text = values[i];
            id.ReadOnly = true;
        }

        private void MyPage_Load(object sender, EventArgs e)
        {
            arbiter.RemovePrevPage();
        }

        private void update_Click(object sender, EventArgs e)
        {
            bool same = true;
            bool contactSame = false;
            for (int i = 0; i < list.Count; i++)
                if (!list[i].Text.ToString().Equals(values[i])) same = false;
            if(same) {
                MessageBox.Show("변경 사항을 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (list[6].Text.ToString().Equals(values[6])) contactSame = true;
            Tester.CheckAndRegister(list, this, false, Tester.MemberAction.M_MODIFY, contactSame, idx:arbiter.Idx);
        }

        private void back_Click(object sender, EventArgs e)
        {
            arbiter.PrevPage = this;
            MainForm mainForm = new MainForm(arbiter);
            arbiter.CurPage = mainForm;
            mainForm.Show();
        }
    }
}
