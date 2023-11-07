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

namespace MonoRank.Forms
{
    public partial class InputEditForm : Form
    {
        private bool insert;
        private Arbiter arbiter;
        private MemberVO member;
        private List<TextBox> list;
        private List<string> data;
        public InputEditForm()
        {
            InitializeComponent();
        }
        public InputEditForm(bool insert, MemberVO member=null, Arbiter arbiter=null) : this()
        {
            list = new List<TextBox>() { id, pwd1, pwd2, name, findq, finda, contact, admin, eatcookie, assaultcraft };
            this.insert = insert;
            if (insert) {
                //button.Text = "Insert";
            } else {
                this.arbiter = arbiter;
                this.member = member;
                data = new List<string>() { member.Id.ToString(), member.Pwd.ToString(), member.Pwd.ToString(), member.Name.ToString(), member.Findq.ToString(), member.Finda.ToString(), member.Contact.ToString(), member.Admin.ToString(), member.Eatcookie.ToString(), member.Assaultcraft.ToString() };
                for (int i = 0; i < list.Count; i++) list[i].Text = data[i];
                id.ReadOnly = true;
                //button.Text = "Update";
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            bool same = true;
            bool contactSame = false;
            if(!insert) {
                for (int i = 0; i < list.Count; i++) 
                    if(!list[i].Text.ToString().Equals(data[i])) same = false;
                if (same) {
                    MessageBox.Show("변경 사항을 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(list[6].Text.ToString().Equals(data[6])) contactSame = true;
            }
            Tester.CheckAndRegister(list, this, insert?true:false, insert?Tester.MemberAction.A_ENROLL:Tester.MemberAction.A_UPDATE, contactSame:contactSame);
        }
    }
}