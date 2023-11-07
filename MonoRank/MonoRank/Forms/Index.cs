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

// 창 크기 디폴트 사이즈 : (976, 579)  / 클라이언트 크기 디폴트 사이즈 : (960, 540) -> 16:9로 하기 위함.
// 모든 로직과 디자인 구현 완료!
namespace MonoRank.Forms
{
    public partial class Index : Form
    {
        private Arbiter arbiter = null;
        public Arbiter retArbiter {
            set { this.arbiter = value; }
        }
        private MemberController controller = new MemberController();

        public Index()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            FindIdDlg dlg = new FindIdDlg();
            dlg.ShowDialog();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string ipid = id.Text.ToString();
            string ippw = pw.Text.ToString();
            if(ipid.Equals("") || ippw.Equals(""))
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dictionary<string, object> result = controller.RequestLogin(ipid, ippw);
            if ((bool)result["login"])
            {
                Arbiter newArbiter = new Arbiter() { User = (MemberVO)result["member"], Idx=this };
                MainForm mainForm = new MainForm(newArbiter);
                newArbiter.CurPage = mainForm;
                id.Clear();
                pw.Clear();
                MessageBox.Show(String.Format("{0}{1}님 환영합니다!", newArbiter.User.Admin == 1? "[관리자] " : "", newArbiter.User.Name), "Welcome!");
                mainForm.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("계정 정보가 일치하지 않거나 없는 계정입니다.\n다시 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id.Focus();
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            SignInDlg dlg = new SignInDlg();
            dlg.ShowDialog();
        }

        private void Index_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("visibleChanged");
            if(this.Visible == true)
            {
                if (arbiter != null) arbiter = null;
            }
            if (arbiter == null) Console.WriteLine("arbiter is null");
            else Console.WriteLine("arbiter is not null");
        }
    }
}
