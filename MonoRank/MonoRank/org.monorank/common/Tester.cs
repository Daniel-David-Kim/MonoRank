using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoRank.Forms;
using MonoRank.org.monorank.vo;
using MonoRank.org.monorank.controller;

namespace MonoRank.org.monorank.common
{
    public static class Tester
    {
        private static MemberController controller = new MemberController();
        private static int validLength = 4;
        public enum MemberAction
        {
            M_SIGNIN=0, A_ENROLL=1, M_MODIFY=2, A_UPDATE=3
        }
        public static int ValidLength
        {
            get { return validLength; }
        }
        public static bool TestPwdLengthValid(string pwd)
        {
            return pwd.Length >= validLength;
        }

        public static bool TestContactValid(string contact)
        {
            Regex regex010 = new Regex("^(010)-[1-9][0-9]{3}-[0-9]{4}$");
            Regex regex011 = new Regex("^(011)-[1-9][0-9]{2}-[0-9]{4}$");
            MatchCollection matches010 = regex010.Matches(contact);
            MatchCollection matches011 = regex011.Matches(contact);
            Console.WriteLine("result count : 010 : {0} /  011 : {1}", matches010.Count, matches011.Count);
            return matches010.Count != 0 || matches011.Count != 0;
        }

        public static bool TestIdContactValid(string id, string category)
        {
            return controller.TestNewIdContact(id, category);
        }

        
        public static void CheckAndRegister(List<TextBox> controls, Form dlg, bool insert=true, MemberAction action=MemberAction.M_SIGNIN, bool contactSame=false, Index idx=null)
        {
            foreach (TextBox control in controls)
            {
                if (control.Text.Equals(""))
                {
                    MessageBox.Show("모든 입력값은 필수입니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    control.Focus();
                    return;
                }
            }
            if (insert&&!TestIdContactValid(controls[0].Text.ToString(), "id"))
            {
                MessageBox.Show("중복되는 아이디입니다.\n다시 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controls[0].Focus();
                return;
            }
            else if (!controls[1].Text.ToString().Equals(controls[2].Text.ToString()))
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controls[1].Focus();
                return;
            }
            else if (!TestPwdLengthValid(controls[1].Text.ToString()))
            {
                MessageBox.Show($"비밀번호는 최소 {ValidLength}자 이상이어야 합니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controls[1].Focus();
                return;
            }
            else if (!TestContactValid(controls[6].Text.ToString()))
            {
                MessageBox.Show("휴대전화 형식에 맞지 않습니다.\n형식 : 010-xxxx-xxxx / 011-xxx-xxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controls[6].Focus();
                return;
            }
            else if (!(!insert && contactSame)&&(!TestIdContactValid(controls[6].Text.ToString(), "contact")))
            {
                MessageBox.Show("중복되는 휴대폰 번호입니다.\n다시 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controls[6].Focus();
                return;
            }
            MemberVO newbie = null;
            string title = "";
            bool success = false;
            switch (action) {
                case MemberAction.M_SIGNIN: 
                case MemberAction.M_MODIFY:
                    newbie = new MemberVO() { Id = controls[0].Text.ToString(), Pwd = controls[1].Text.ToString(), Name = controls[3].Text.ToString(), Findq = controls[4].Text.ToString(), Finda = controls[5].Text.ToString(), Contact = controls[6].Text.ToString() };
                    title = action==MemberAction.M_SIGNIN ? "회원 가입" : "회원 정보 수정"; break;
                case MemberAction.A_ENROLL:
                case MemberAction.A_UPDATE:
                    newbie = new MemberVO() { Id = controls[0].Text.ToString(), Pwd = controls[1].Text.ToString(), Name = controls[3].Text.ToString(), Findq = controls[4].Text.ToString(), Finda = controls[5].Text.ToString(), Contact = controls[6].Text.ToString(), Admin = Int32.Parse(controls[7].Text), Eatcookie=Int32.Parse(controls[8].Text), Assaultcraft=Int32.Parse(controls[9].Text) };
                    title = action == MemberAction.A_ENROLL ? "회원 등록" : "회원 정보 수정"; break;
            }
            switch(action) {
                case MemberAction.M_SIGNIN:
                case MemberAction.A_ENROLL: success = controller.RegisterMember(newbie); break;
                case MemberAction.M_MODIFY:
                case MemberAction.A_UPDATE: success = controller.UpdateMember(newbie, action); break;
            }
            if (success) {
                MessageBox.Show($"{title}에 성공했습니다!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dlg.DialogResult = DialogResult.OK;
                if(action == MemberAction.M_MODIFY)
                {
                    MemberVO refresh = controller.GetMemberById(newbie.Id);
                    Arbiter arbiter = new Arbiter() { Idx=idx, User=refresh, PrevPage=dlg };
                    MainForm mainForm = new MainForm(arbiter);
                    arbiter.CurPage = mainForm;
                    mainForm.Show();
                    return;
                }
                dlg.Dispose();
            }
            else MessageBox.Show($"{title} 도중 오류가 발생했습니다.\n다시 시도해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
