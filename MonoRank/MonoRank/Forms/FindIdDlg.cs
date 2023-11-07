using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoRank.Forms;
using System.Windows.Forms;
using MonoRank.org.monorank.vo;
using MonoRank.org.monorank.common;
using MonoRank.org.monorank.controller;

namespace MonoRank.Forms
{
    public partial class FindIdDlg : Form
    {
        private MemberController controller = new MemberController();
        public FindIdDlg()
        {
            InitializeComponent();
        }

        private void findpw_Click(object sender, EventArgs e)
        {
            FindPwDlg dlg = new FindPwDlg();
            Dispose();
            dlg.ShowDialog();
        }

        private void find_Click(object sender, EventArgs e)
        {
            string ipname = name.Text.ToString();
            string ipcontact = contact.Text.ToString();
            if (ipname.Equals("") || ipcontact.Equals("")) MessageBox.Show("모든 입력 항목은 필수입니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Tester.TestContactValid(ipcontact)) MessageBox.Show("휴대전화 형식에 맞지 않습니다.\n형식 : 010-xxxx-xxxx / 011-xxx-xxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                Dictionary<string, object> result = controller.FindAccountId(ipname, ipcontact);
                if ((bool)result["find"]) MessageBox.Show($"아이디는 {((MemberVO)result["result"]).Id}입니다.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("아이디를 찾을 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}