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
using MonoRank.org.monorank.controller;

namespace MonoRank.Forms
{
    public partial class FindPwDlg : Form
    {
        private MemberController controller = new MemberController();
        public FindPwDlg()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            string ipid = id.Text.ToString();
            if(ipid.Equals("")) MessageBox.Show("아이디를 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Dictionary<string, object> result = controller.GetUserQInfo(ipid);
                if(!((bool)result["get"])) MessageBox.Show("회원 정보 찾기에 실패했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else {
                    PwdQuestion dlg = new PwdQuestion((MemberVO)result["question"]);
                    Dispose();
                    dlg.ShowDialog();
                }
            }
        }

        private void findid_Click(object sender, EventArgs e)
        {
            FindIdDlg dlg = new FindIdDlg();
            Dispose();
            dlg.ShowDialog();
        }
    }
}