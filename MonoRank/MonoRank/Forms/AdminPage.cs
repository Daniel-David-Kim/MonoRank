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
    public partial class AdminPage : Form
    {
        private Arbiter arbiter;
        private MemberController controller = new MemberController();
        private List<MemberVO> membersList;
        private int rowCount;
        private int selectedRowNum;
        public AdminPage()
        {
            InitializeComponent();
        }
        public AdminPage(Arbiter arbiter) : this()
        {
            this.arbiter = arbiter;
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            members.ClearSelection();
            selectedRowNum = 0;
            members.Rows.Clear();
            Dictionary<string, object> membersDict = controller.GetMembersInfo();
            membersList = (List<MemberVO>)membersDict["membersList"];
            rowCount = (int)membersDict["rowCount"];
            foreach (MemberVO m in membersList)
                members.Rows.Add(m.Id, m.Pwd, m.Name, m.Findq, m.Finda, m.Contact, m.Admin, m.Eatcookie, m.Assaultcraft);
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            arbiter.RemovePrevPage();
            members.Left = (this.ClientSize.Width-members.Width) / 2;
        }
        private void insert_Click(object sender, EventArgs e)
        {
            InputEditForm dlg = new InputEditForm(true);
            DialogResult result = dlg.ShowDialog();
            if(result == DialogResult.OK) RefreshGrid();
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (selectedRowNum == rowCount) return;
            DataGridViewRow sel = members.Rows[selectedRowNum];
            MemberVO info = new MemberVO() { Id=sel.Cells[0].Value.ToString(), Pwd=sel.Cells[1].Value.ToString(), Name=sel.Cells[2].Value.ToString(), Findq=sel.Cells[3].Value.ToString(),
                Finda=sel.Cells[4].Value.ToString(), Contact=sel.Cells[5].Value.ToString(), Admin=(int)sel.Cells[6].Value, Eatcookie=(int)sel.Cells[7].Value, Assaultcraft=(int)sel.Cells[8].Value};
            InputEditForm dlg = new InputEditForm(false, member:info, arbiter:arbiter);
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK) RefreshGrid();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedRowNum == rowCount) return;
            DialogResult res = MessageBox.Show("한 번 삭제하면 되돌릴 수 없습니다.\n계속하시겠습니까?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(res == DialogResult.OK) {
                string id = members.Rows[selectedRowNum].Cells[0].Value.ToString();
                bool result = controller.RemoveMember(id);
                if(result) {
                    MessageBox.Show("삭제가 완료되었습니다.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }
            }
        }
        private void members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowNum = e.RowIndex;
        }

        private void back_Click(object sender, EventArgs e)
        {
            MemberVO refresh = controller.GetMemberById(arbiter.User.Id);
            arbiter = new Arbiter() { Idx = arbiter.Idx, User = refresh, PrevPage = this };
            MainForm mainForm = new MainForm(arbiter);
            arbiter.CurPage = mainForm;
            mainForm.Show();
        }
    }
}
