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
    public partial class Ranking : Form
    {
        private Arbiter arbiter;
        private List<Label> labels;
        private MemberController controller = new MemberController();
        private List<MemberVO> membersList;
        public Ranking()
        {
            InitializeComponent();
        }

        public Ranking(Arbiter arbiter) : this()
        {
            this.arbiter = arbiter;
            arbiter.RemovePrevPage();
            Dictionary<string, object> membersInfo = controller.GetMembersInfo();
            membersList = (List<MemberVO>)membersInfo["membersList"];
            labels = new List<Label>() { rank1, rank2, rank3, rank4 };
            var catTemp = from cat in DBExecutor.ScoreTbls
                          select cat;
            string[] cats = catTemp.ToArray();
            category.Items.AddRange(cats);
            category.SelectedIndex = 0;
            string selCat = category.Items[0].ToString();
            ShowRank(selCat);
        }

        private void ShowRank(string selCat)
        {
            Dictionary<string, int> resDict = null;
            Dictionary<string, string> nameDict = null;
            List<string> idList = null;
            switch(selCat) {
                case "eatcookie":
                    var temp = from member in membersList orderby member.Eatcookie descending
                               select new { member.Id, member.Name, member.Eatcookie };
                    resDict = temp.ToDictionary(member => member.Id, member => member.Eatcookie);
                    nameDict = temp.ToDictionary(member => member.Id, member => member.Name);
                    idList = (from member in membersList orderby member.Eatcookie descending select member.Id).ToList(); break;
                case "assaultcraft":
                    var temp2 = from member in membersList orderby member.Assaultcraft descending
                                select new { member.Id, member.Name, member.Assaultcraft };
                    resDict = temp2.ToDictionary(member => member.Id, member => member.Assaultcraft);
                    nameDict = temp2.ToDictionary(member => member.Id, member => member.Name);
                    idList = (from member in membersList orderby member.Assaultcraft descending select member.Id).ToList(); break;
                default: resDict = new Dictionary<string, int>(); break;
            }
            int i = 0;
            foreach (string id in resDict.Keys) {
                labels[i].Text = $"{nameDict[id]} : {resDict[id]}점";
                i++;
                if (i >= labels.Count) break;
            }
            int myScore = selCat.Equals("eatcookie") ? arbiter.User.Eatcookie : arbiter.User.Assaultcraft;
            myrank.Text = $"{idList.IndexOf(arbiter.User.Id) + 1}위 : {myScore}점";
        }

        private void back_Click(object sender, EventArgs e)
        {
            arbiter.PrevPage = this;
            MainForm mainForm = new MainForm(arbiter);
            arbiter.CurPage = mainForm;
            mainForm.Show();
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selCat = category.Items[category.SelectedIndex].ToString();
            ShowRank(selCat);
        }
    }
}
