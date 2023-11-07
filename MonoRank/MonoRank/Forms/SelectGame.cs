using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoRank.org.monorank.common;

namespace MonoRank.Forms
{
    public partial class SelectGame : Form
    {
        private Arbiter arbiter;
        public SelectGame()
        {
            InitializeComponent();
        }

        public SelectGame(Arbiter arbiter) : this()
        {
            this.arbiter = arbiter;
            arbiter.RemovePrevPage();
        }

        private void assaultcraft_Click(object sender, EventArgs e)
        {
            arbiter.CurGameCode = Arbiter.GameCode.ASSAULTCRAFT;
            arbiter.PrevPage = this;

            Game game = new Game(arbiter);
            arbiter.CurPage = game;
            game.Show();
        }

        private void eatcookie_Click(object sender, EventArgs e)
        {
            arbiter.CurGameCode = Arbiter.GameCode.EATCOOKIE;
            arbiter.PrevPage = this;
            Game game = new Game(arbiter);
            arbiter.CurPage = game;
            game.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            arbiter.Logout();
            Dispose();
        }

        private void back_Click(object sender, EventArgs e)
        {
            arbiter.PrevPage = this;
            MainForm mainForm = new MainForm(arbiter);
            arbiter.CurPage = mainForm;
            mainForm.Show();
        }

        private void eatcookie_MouseHover(object sender, EventArgs e)
        {
            eatcookie.BackgroundImage = Image.FromFile("img/invitecard.png");
        }

        private void eatcookie_MouseLeave(object sender, EventArgs e)
        {
            eatcookie.BackgroundImage = Image.FromFile("img/eccard.png");
        }

        private void assaultcraft_MouseHover(object sender, EventArgs e)
        {
            assaultcraft.BackgroundImage = Image.FromFile("img/AC1.jpg");
        }

        private void assaultcraft_MouseLeave(object sender, EventArgs e)
        {
            assaultcraft.BackgroundImage = Image.FromFile("img/accard.png");
        }

        private void SelectGame_Load(object sender, EventArgs e)
        {
            switch(arbiter.User.Admin)
            {
                case 0: housepanel.BackgroundImage = Image.FromFile("img/rh.png");
                    userpanel.BackgroundImage = Image.FromFile("img/memberlabel.png"); break;
                case 1: housepanel.BackgroundImage = Image.FromFile("img/gh.png");
                    userpanel.BackgroundImage = Image.FromFile("img/adminlabel.png"); break;
                default: break;
            }
            username.Text = arbiter.User.Name;
        }
    }
}
