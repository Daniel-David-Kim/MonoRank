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
    public partial class SignInDlg : Form
    {
        private MemberController controller = new MemberController();
        public SignInDlg()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            List<TextBox> controls = new List<TextBox>() { id, pwd1, pwd2, name, findq, finda, contact };
            Tester.CheckAndRegister(controls, this);
        }
    }
}