using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoRank.Forms;
using MonoRank.org.monorank.vo;
using MonoRank.org.monorank.common;

namespace MonoRank.Forms
{
    public partial class MainForm : Form
    {
        private Arbiter arbiter;
        private bool IsAdmin = false;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Arbiter arbiter) : this()
        {
            this.arbiter = arbiter;
            if (arbiter.User.Admin == 1) IsAdmin = true;
            arbiter.RemovePrevPage();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                profile.BackgroundImage = Image.FromFile("img/adminprofile.png");
                setting.BackgroundImage = Image.FromFile("img/adminpage.png");
            }
            username.Text = arbiter.User.Name;
        }

        private void game_MouseHover(object sender, EventArgs e)
        {
            game.BackgroundImage = Image.FromFile("img/playhover.png");
        }

        private void game_MouseLeave(object sender, EventArgs e)
        {
            game.BackgroundImage = Image.FromFile("img/playgame.png");
        }

        private void ranking_MouseHover(object sender, EventArgs e)
        {
            ranking.BackgroundImage = Image.FromFile("img/rankboardhover.png");
        }

        private void ranking_MouseLeave(object sender, EventArgs e)
        {
            ranking.BackgroundImage = Image.FromFile("img/rankboard.png");
        }

        private void setting_MouseHover(object sender, EventArgs e)
        {
            if (IsAdmin) setting.BackgroundImage = Image.FromFile("img/adminpagehover.png");
            else setting.BackgroundImage = Image.FromFile("img/mypagehover.png");
        }

        private void setting_MouseLeave(object sender, EventArgs e)
        {
            if (IsAdmin) setting.BackgroundImage = Image.FromFile("img/adminpage.png");
            else setting.BackgroundImage = Image.FromFile("img/mypage.png");
        }

        // 로그아웃 로직. 어느 페이지든 이 두 줄만 써주면 언제든 로그아웃되고 메인 화면으로 돌아감.
        private void logout_Click(object sender, EventArgs e)
        {
            arbiter.Logout();
            Dispose();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                arbiter.PrevPage = this;
                AdminPage admin = new AdminPage(arbiter);
                arbiter.CurPage = admin;
                admin.Show();
            }
            else
            {
                arbiter.PrevPage = this;
                MyPage my = new MyPage(arbiter);
                arbiter.CurPage = my;
                my.Show();
            }
        }

        private void ranking_Click(object sender, EventArgs e)
        {
            arbiter.PrevPage = this;
            Ranking ranking = new Ranking(arbiter);
            arbiter.CurPage = ranking;
            ranking.Show();
        }

        private void game_Click(object sender, EventArgs e)
        {
            arbiter.PrevPage = this;
            SelectGame gameSel = new SelectGame(arbiter);
            arbiter.CurPage = gameSel;
            gameSel.Show();
        }
    }
}
